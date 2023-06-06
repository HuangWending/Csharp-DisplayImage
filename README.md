# Csharp-DisplayImage
C#显示路径图片的程序
using System;：引入了命名空间System，它包含了一些基本的C#类和功能。
using System.Drawing;：引入了命名空间System.Drawing，它提供了与图像、绘图和绘图表面相关的类和方法。
using System.Windows.Forms;：引入了命名空间System.Windows.Forms，它包含了用于创建Windows窗体应用程序的类和方法。
namespace ImageDisplayApp：定义了一个名为ImageDisplayApp的命名空间，用于组织相关的类和代码。
public partial class Form1 : Form：定义了一个名为Form1的公共部分类，它继承自Form类，表示一个窗体。
private PictureBox pictureBox;：声明了一个私有成员变量pictureBox，用于存储PictureBox控件的实例。
public Form1()：Form1类的构造函数，用于初始化窗体。
InitializeComponent()：用于初始化窗体中的组件和控件。
private void Form1_Load(object sender, EventArgs e)：窗体加载事件的处理方法。
pictureBox = new PictureBox();：创建一个新的PictureBox控件的实例。
pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;：设置PictureBox控件的SizeMode属性为AutoSize，使其根据图片大小自动调整大小。
Controls.Add(pictureBox);：将PictureBox控件添加到窗体的控件集合中，使其显示在窗体上。
string imagePath = "您的图片文件路径";：设置要显示的图片路径，将路径替换为您实际的图片文件路径。
try：开始异常处理的代码块。
Image image = Image.FromFile(imagePath);：从指定路径的文件加载图像，并将其赋值给image变量。
pictureBox.Image = image;：将加载的图像赋值给PictureBox控件的Image属性，使其显示图片。
catch (Exception ex)：捕获任何异常，并将异常对象赋值给ex变量。
MessageBox.Show("无法加载图片: " + ex.Message);：如果加载图片出现异常，则显示一个包含错误信息的消息框。
