using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuwomusic
{
    public partial class Form1 : Form
    {
        Lyric kl = new Lyric();
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 找到一个目录下的所有文件
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="pattern"></param>
        /// <param name="fileList"></param>
        public void GetFiles(DirectoryInfo directory, string pattern, ref List<string> fileList)
        {
            if (directory.Exists || pattern.Trim() != string.Empty)
            {
                try
                {
                    foreach (FileInfo info in directory.GetFiles(pattern))
                    {
                        fileList.Add(info.Name.Remove(info.Name.LastIndexOf(".")).ToString());
                    }
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                foreach (DirectoryInfo info in directory.GetDirectories())//获取文件夹下的子文件夹
                {
                    GetFiles(info, pattern, ref fileList);//递归调用该函数，获取子文件夹下的文件
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //显示播放时间
            lblTime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString
                + " / " + axWindowsMediaPlayer1.currentMedia.durationString;

            //根据歌曲播放，显示歌词
            for(int i = 0;i <kl.lstLyric.Count;i++)
            {
                if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition > kl.lstLyric[i].time &&
                    axWindowsMediaPlayer1.Ctlcontrols.currentPosition < kl.lstLyric[i + 1].time)
                {
                    lblLyric.Text = kl.lstLyric[i].text;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //获取文件夹下面的所有MP3文件信息
            List<string> lstAllMp3FileName = new List<string>();
            string dir = Environment.CurrentDirectory + "/mp3";
            GetFiles(new DirectoryInfo(dir), "*.*",ref lstAllMp3FileName);

            //显示到我的listbox
            listBox1.Items.AddRange(lstAllMp3FileName.ToArray());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curMp3Name = listBox1.SelectedItem.ToString();

            kl = new Lyric();
            kl.Load("Lyric/" + curMp3Name + ".lrc");

            axWindowsMediaPlayer1.URL = "mp3/" + curMp3Name + ".mp3";

            this.BackgroundImage = Image.FromFile(axWindowsMediaPlayer1.URL);

            timer1.Enabled = true;


        }
    }
}
