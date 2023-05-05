using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 特效类
        /// </summary>
        public class SpecialEffect
        {
            int pictureNumber;
            string dirName;
            string fileName;
            string soundFileName;
        }

        /// <summary>
        /// 枚举类型,表示不同的特效
        /// </summary>
        public enum SpecialEffectType {None,Cat,Grass};

        Graphics g;

        int idx1 = 0;
        int idx2 = 0;
        /// <summary>
        /// 绘图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            g.DrawImage(imgGirl,0,0);

            if(sType == SpecialEffectType.Cat)
            {
                //画猫耳朵
                g.DrawImage(imgEars[idx1], 100, 0);
                g.DrawImage(imgMoustacheos[idx1], 103, 183);
            }

            else if(sType == SpecialEffectType.Grass)
            {
                //画草
                g.DrawImage(imgGrass[idx2], 95, 0);
                g.DrawImage(imgYuan[idx2], 180, 183);
            }
 

        }

        Image imgGirl;

        //猫耳朵
        Image[] imgEars;
        Image[] imgMoustacheos;

        //草
        Image[] imgGrass;
        Image[] imgYuan;

        SpecialEffectType sType = SpecialEffectType.None ;
        /// <summary>
        /// 载入资源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

            imgGirl = Image.FromFile("girl/girl1.jpg");

            //猫耳朵数组
            imgEars = new Image[80];
            imgMoustacheos = new Image[80];


            //草数组
            imgGrass = new Image[61];
            imgYuan = new Image[61];


            for (int i = 0; i < 80; i++)
            {
                imgEars[i] = Image.FromFile("ear/ear_" + i.ToString("D3") + ".png");   //d3是补全数字三位
            }
            for (int i = 0; i < 80; i++)
            {
                imgMoustacheos[i] = Image.FromFile("moustache/moustache_" + i.ToString("D3") + ".png");   //d3是补全数字三位
            }


            for (int i = 0; i < 61; i++)
            {
                imgGrass[i] = Image.FromFile("grass/grass_" + i.ToString("D3") + ".png");   //d3是补全数字三位
            }
            for (int i = 0; i < 61; i++)
            {
                imgYuan[i] = Image.FromFile("yuan/yuan_" + i.ToString("D3") + ".png");   //d3是补全数字三位
            }
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            idx1++;
            idx2++;
            if (idx1 > 79)
            {
                idx1= 0;
            }
            if(idx2 > 60)
            {
                idx2= 0;
            }
            pictureBox1.Invalidate();
        }

        

        private void btnEar_Click(object sender, EventArgs e)
        {
            sType = SpecialEffectType.Cat;
            idx1= 0;
        }

        private void btnGrass_Click(object sender, EventArgs e)
        {
            sType = SpecialEffectType.Grass;
            idx2= 0;
        }
    }
}
