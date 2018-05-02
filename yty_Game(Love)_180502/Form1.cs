using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yty_Game_Love__180502
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 当鼠标进入按钮的可见的部分的时候,给按钮一个新的坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hate_MouseEnter(object sender, EventArgs e)
        {
            //给按钮一个新的坐标轴
            //这个按钮的活动最大宽度是 窗体的宽度减去按钮的宽度
            int x = this.ClientSize.Width - hate.Width;
            int y = this.ClientSize.Height - hate.Height;

            //要给按钮随机的坐标
            Random r = new Random();
            hate.Location = new Point(r.Next(0, x + 1), r.Next(0, y + 1));

        }

        /// <summary>
        /// 给Love的按钮设置点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void love_Click(object sender, EventArgs e)
        {
            MessageBox.Show("enen......");
            Close();
        }


        /// <summary>
        /// 给Hate的按钮注册一个单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HHHHHHH.....");
        }
    }
}
