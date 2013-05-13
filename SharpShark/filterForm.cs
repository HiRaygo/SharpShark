using System;
using System.Collections;
using System.Windows.Forms;
using System.IO;

namespace SharpShark
{
    public partial class filterForm : Form
    {
        public filterForm()
        {
            InitializeComponent();
        }

        //存在过滤器文件则直接加载到ListBox里面
        private void filterForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(filterClass.filterFilePath))
            {
                MessageBox.Show("wireSharkFilter.txt这个过滤器配置文件丢失，请检查！");
                this.Close();
            }
            else
            {
                ArrayList structArrayList = filterClass.Filters;
                foreach (filter filterA in structArrayList)
                {
                    lstbFilter.Items.Add(filterA.filterName);
                }
            }
        }

        //用户点击一个过滤器名称时，在下面显示其名称和过滤表达式
        private void lstbFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedName = this.lstbFilter.SelectedItem.ToString();
            ArrayList structArrayList = filterClass.Filters;
            foreach (filter filterA in structArrayList)
            {
                if (selectedName == filterA.filterName)
                {
                    txtbFilterName.Text = filterA.filterName;
                    txtbFilterExpression.Text = filterA.filterExpression;
                }
            }
        }

        //用户点击新建过滤器按钮
        private void btnFilterNew_Click(object sender, EventArgs e)
        {
            txtbFilterName.Text = "请输入过滤器名称";
            txtbFilterExpression.Text = "请输入过滤表达式";
        }

        //删除某个过滤器时
        private void btnFilterDelete_Click(object sender, EventArgs e)
        {
            ArrayList structArrayList = filterClass.Filters;
            string selectedName = this.lstbFilter.SelectedItem.ToString();
            for (int i = 0; i < structArrayList.Count; i++)
            {
                if (((filter)structArrayList[i]).filterName == selectedName)
                {
                    structArrayList.RemoveAt(i);
                }
            }
            filterClass.saveFilters(structArrayList);
            //将内存中的Filters重新加载，因为此时内存中的Filters和文件中的已经不一致了
            filterClass.Filters = filterClass.getFilters();
            refresh();
        }

        //点击取消按钮
        private void btnFilterCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //点击保存按钮
        private void btnFilterOK_Click(object sender, EventArgs e)
        {
            ArrayList structArrayList = filterClass.Filters;
            //保存操作的过滤器可能是新增的，也可能是修改的。
            //如果过滤器列表中有其名字，则是修改，则将老的删掉
            for (int i = 0; i < structArrayList.Count; i++)
            {
                if (((filter)structArrayList[i]).filterName == txtbFilterName.Text)
                {
                    structArrayList.RemoveAt(i);
                }
            }
            filter filterNew = new filter(txtbFilterName.Text, txtbFilterExpression.Text);
            structArrayList.Add(filterNew);
            filterClass.saveFilters(structArrayList);
            refresh();
        }

        //刷新界面
        private void refresh()
        {
            ArrayList structArrayList = filterClass.getFilters();
            lstbFilter.Items.Clear();
            foreach (filter filterA in structArrayList)
            {
                lstbFilter.Items.Add(filterA.filterName);
            }
            txtbFilterName.Text = "";
            txtbFilterExpression.Text = "";
        }

        private void txtbFilterName_Enter(object sender, EventArgs e)
        {
            txtbFilterName.Text = "";
        }

        private void txtbFilterExpression_Enter(object sender, EventArgs e)
        {
            txtbFilterExpression.Text = "";
        }
    }
}