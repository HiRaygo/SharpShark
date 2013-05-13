using System;
using System.Drawing;
using System.Windows.Forms;
using SharpShark;

public class PieChart
{
    public PieChart()
    {
    }

    /// <summary>
    /// 绘制一个图片
    /// </summary>
    /// <param name="title">图名称</param>
    /// <param name="subtitle">图的副名称</param>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <param name="chartData">数据</param>
    /// <returns></returns>
    public static Image render(string title, string subtitle, int width, int height, packetKind[] chartData)
    {
        const int side_length = 400;
        const int pie_diameter = 200;

        //通过输入参数，取得饼图中的总基数
        float sumData = 0;
        for (int i = 0; i < chartData.Length; i++)
        {
            sumData += chartData[i].count;
        }
        //产生一个image对象，并由此产生一个graphics对象  
        Bitmap bmp = new Bitmap(width, height);
        Graphics g = Graphics.FromImage(bmp);

        try
        {
            //设置对象g的属性
            g.ScaleTransform((Convert.ToSingle(width)) / side_length, (Convert.ToSingle(height)) / side_length);

            //用白色清空画布
            g.Clear(Color.White);
            g.DrawRectangle(Pens.Black, 0, 0, side_length - 1, side_length - 1);
            //画饼图标题  
            g.DrawString(title, new Font("tahoma", 14), Brushes.Black, new PointF(5, 5));
            g.DrawString(subtitle, new Font("tahoma", 12), Brushes.Black, new PointF(7, 35));

            //画饼图
            float currentAngle = 0;
            float totalAngle = 0;
            for (int i = 0; i < chartData.Length; i++)
            {
                currentAngle = Convert.ToSingle(chartData[i].count) / sumData * 360;
                g.FillPie(new SolidBrush(getColor(i)), 100, 65, pie_diameter, pie_diameter, totalAngle, currentAngle);
                g.DrawPie(Pens.Black, 100, 65, pie_diameter, pie_diameter, totalAngle, currentAngle);
                totalAngle += currentAngle;
            }
            //画图例框及其文字  
            g.DrawRectangle(Pens.Black, 200, 300, 199, 99);
            g.DrawString("图表说明", new Font("tahoma", 12, FontStyle.Bold), Brushes.Black, new PointF(200, 300));

            //画图例各项  
            PointF box = new PointF(210, 330);
            PointF text = new PointF(235, 326);
            float percent = 0;
            for (int i = 0; i < chartData.Length; i++)
            {
                g.FillRectangle(new SolidBrush(getColor(i)), box.X, box.Y, 20, 10);
                g.DrawRectangle(Pens.Black, box.X, box.Y, 20, 10);
                percent = Convert.ToSingle(chartData[i].count) / sumData * 100;
                g.DrawString((i+1).ToString()+ " - " + chartData[i].protocol + " (" + percent.ToString("0") + "%)", new Font("tahoma", 10), Brushes.Black, text);
                box.Y += 15;
                text.Y += 15;
            }
        }
        catch (Exception ex) 
        {
            MessageBox.Show(ex.TargetSite.ToString());
        }
        return (Image)bmp;
    }

    private static Color getColor(int i)
    {
        switch (i)
        {
            case 0: return Color.AliceBlue;
            case 1: return Color.AntiqueWhite;
            case 2: return Color.Aqua;
            case 3: return Color.Yellow; 
            case 4: return Color.Red; 
            case 5: return Color.Green; 
            case 6: return Color.HotPink;
            case 7: return Color.Chocolate;
            case 8: return Color.Brown;
            case 9: return Color.AliceBlue; 
            case 10: return Color.AliceBlue; 
            case 11: return Color.AliceBlue; 
            case 12: return Color.AliceBlue; 
            case 13: return Color.AliceBlue; 
            case 14: return Color.AliceBlue; 
            case 15: return Color.AliceBlue; 
            default: return Color.Black;
        }
    }

    public static Image drawPicture(int width, int height, string msg)
    {
        Bitmap bmp = new Bitmap(width,height);
        Graphics g = Graphics.FromImage(bmp);
        g.Clear(Color.CadetBlue);
        PointF p = new PointF(100,100);
        Font f = new Font("宋体",20,FontStyle.Regular);
        g.DrawString(msg,f,Brushes.Beige ,p);
        return (Image)bmp;
    }
}