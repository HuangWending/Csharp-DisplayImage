using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageDisplayApp
{
    public partial class Form1 : Form
    {
        private PictureBox pictureBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 创建PictureBox控件
            pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            Controls.Add(pictureBox);

            // 设置要显示的图片路径
            string imagePath = "您的图片文件路径";

            // 加载并显示图片
            try
            {
                Image image = Image.FromFile(imagePath);
                pictureBox.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法加载图片: " + ex.Message);
            }
        }
    }
}
