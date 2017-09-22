using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

        }

        private Size minSize = new Size(400, 400);
        private bool isIncrease = false;
        private void Form1_Click(object sender, EventArgs e)
        {
            int currentH = this.Size.Height;
            int currentW = this.Size.Width;
            if (isIncrease == false)
            {
                


                Size = new Size((int)(currentW - currentW * 0.1), (int)(currentH - currentH * 0.1));
            }
            else
            {
                Size = new Size((int)(currentW + currentW * 0.1), (int)(currentH + currentH * 0.1));
            }
            if ((this.Size.Height < minSize.Height) && (this.Size.Width < minSize.Width))
            {
                isIncrease = true;
            }
            
        }
    }
}
/*Создать приложеие на C# WinForms, состоящееиз окна занимаюзего весь экран. По правому щелчку мыши окно уменьшается на 10%
 до некоторого фиксирвоанного значения, а затем увеличивается до прежних размеров.*/