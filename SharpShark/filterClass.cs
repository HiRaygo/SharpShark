using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Collections;

namespace SharpShark
{
    /// <summary>
    /// 代表一个过滤器项
    /// </summary>
    public struct filter
    {
        public string filterName;
        public string filterExpression;

        public filter(string filterNamePara, string filterExpressionPara)
        {
            filterName = filterNamePara;
            filterExpression = filterExpressionPara;
        }
    }

    class filterClass
    {
        internal const string filterFilePath = "wireSharkFilter.txt";

        private static ArrayList _Filters;

        public static ArrayList Filters
        {
            get
            {
                if (_Filters != null)
                    return _Filters;
                else
                    return getFilters();
            }
            set
            {
                _Filters = value;
            }
        }

        //读取过滤器配置文件为一个ArrayList
        public static ArrayList getFilters()
        {
            StreamReader sr = new StreamReader(filterFilePath);
            ArrayList al = new ArrayList();
            while (sr.Peek() != -1)
            {
                string tmp = sr.ReadLine();
                al.Add(createFilter(tmp));
            }
            sr.Close();
            return al;
        }

        //将配置文件里面的一行（一个过滤器）转换成一个filter结构
        public static filter createFilter(string txt)
        {
            filter filterNew = new filter();
            int lastYinHao = txt.LastIndexOf('"');
            filterNew.filterName = txt.Substring(1, lastYinHao - 1);
            filterNew.filterExpression = txt.Substring(lastYinHao + 2);
            return filterNew;
        }

        //用由filter结构组成的ArrayList写一个过滤器文件（覆盖原来的）
        internal static void saveFilters(ArrayList al)
        {
            StreamWriter sw = new StreamWriter(filterFilePath, false, Encoding.Default, 512);
            foreach (filter filterTmp in al)
            {
                //目标行格式："TCP only" tcp
                sw.WriteLine('"' + filterTmp.filterName + '"' + " " + filterTmp.filterExpression);
            }
            sw.Flush();
            sw.Close();
        }
    }
}