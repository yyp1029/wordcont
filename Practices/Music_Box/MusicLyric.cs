using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Box
{  
    /// <summary>
    /// 一行歌词
    /// </summary>
    class LyricLine
    {
        public double time;
        public string text;
    }

    /// <summary>
    /// 专门处理歌词的类
    /// </summary>
    internal class MusicLyric
    {
        public List<LyricLine> lstyric = new List<LyricLine>();
        public void Load(String fileName)
        {
            //读取歌词文件
            //类名 对象名 = new 类名()
            Encoding en = Encoding.GetEncoding("GB2312"); //如果有乱码就改编码方式
            FileStream fs = new FileStream(fileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs,en);


            //循环读取
            while (true)
            {
                //读一行
                string str = sr.ReadLine();
                if (str == "")
                {
                    continue;
                }
                //读完时
                if (str == null)
                {
                    break;
                }

                //时间信息
                string strMinute = str.Substring(1, 2);
                string strSecond = str.Substring(4, 5);
                double time = double.Parse(strMinute) * 60 + double.Parse(strSecond);//获取秒数


                //歌词信息
                string strLyric = str.Substring(10);

                //创建单行歌词的对象
                LyricLine ll = new LyricLine();
                ll.time = time;
                ll.text = strLyric;

                //添加到链表中去
                lstyric.Add(ll);

            }
            //关闭
            sr.Close();
            fs.Close();
        }
    }
}
