using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Box
{
    public partial class frmMusicBox : Form
    {
        public frmMusicBox()
        {
            InitializeComponent();
        }

        MusicLyric curSongLyric = new MusicLyric();
        bool isPlay = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picPlay_Click(object sender, EventArgs e)
        {

            if (isPlay)
            {
                //如果正在播放，图片切换
                picPlay.BackgroundImage = Properties.Resources.play;
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
            else
            {
                picPlay.BackgroundImage = Properties.Resources.pause;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            isPlay = !isPlay;
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

        private void frmMusicBox_Load(object sender, EventArgs e)
        {
            //获取 文件夹下所有的mp3文件信息
            List<string > lstAllMp3FileName = new List<string>();
            string dir = Environment.CurrentDirectory + "/Song";
            GetFiles(new DirectoryInfo(dir), "*.*",ref lstAllMp3FileName);

            //显示到我的listbox
            listBox1.Items.AddRange(lstAllMp3FileName.ToArray());
        }


        //保存当前歌曲的名称
        string curSongName = "";
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             curSongName = listBox1.SelectedItem.ToString();

            //  //载入用户选择的歌曲歌词
            curSongLyric.Load("Lyric/" + curSongName + ".lrc");
            //播放歌曲文件
            axWindowsMediaPlayer1.URL = "song/" + curSongName + ".mp3";
            isPlay = true;
            picPlay.BackgroundImage = Properties.Resources.pause;
            //替换背景图片
            this.BackgroundImage = Image.FromFile("bg/" + curSongName + ".jpg");
            timer1.Enabled = true; 
            
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }


        int curLyicIdx = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            double progress = axWindowsMediaPlayer1.Ctlcontrols.currentPosition / axWindowsMediaPlayer1.currentMedia.duration * 100;
            userControl11.ProgressValue = (int)progress;
            label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString
                + " / " + axWindowsMediaPlayer1.currentMedia.durationString;
            //歌词显示
            curLyicIdx++;
            if (curLyicIdx < curSongLyric.lstyric.Count)
            {
                lblSongLyric.Text = curSongLyric.lstyric[curLyicIdx].text;
            }
            //时间显示
            label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString + "/" + axWindowsMediaPlayer1.currentMedia.durationString;
            //显示正确的歌词
            for (int i = 0; i < curSongLyric.lstyric.Count; i++)
            {
                if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition > curSongLyric.lstyric[i].time)
                {
                    lblSongLyric.Text = curSongLyric.lstyric[i].text;
                }
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
