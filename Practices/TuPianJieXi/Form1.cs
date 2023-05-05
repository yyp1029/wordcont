﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuPianJieXi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("image.ppm", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string fileFormat = sr.ReadLine();
            string res = sr.ReadLine();//1024 768
            string maxColor = sr.ReadLine();
            string[] resArr = res.Split(' ');
            int resW = int.Parse(resArr[0]);
            int resH = int.Parse(resArr[1]);

            string strData = sr.ReadToEnd();
            string[] strDataArr = strData.Split(' ');

            
            Bitmap bmp = new Bitmap (resW, resH);
            int index = 0;
            for (int i = 0; i < resH; i++)
            {
                for(int j=0;j<resW; j++)
                {
                    int r = int.Parse(strDataArr[index++]);
                    int g = int.Parse(strDataArr[index++]);
                    int b = int.Parse(strDataArr[index++]);
                    Color color= Color.FromArgb(r,g,b);
                    bmp.SetPixel(j, i, color); 
                }
            }
            pictureBox1.BackgroundImage = bmp;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
