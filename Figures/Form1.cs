using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Figures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rdm;

        public void threadTriangle()
        {
            for (int i = 0; i < 1000; i++)
            {
                int width = rdm.Next(0, 550);
                int height = rdm.Next(0, 350);
                Thread.Sleep(3000);
            }
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            Thread thTriangle = new Thread(threadTriangle);
            thTriangle.Start();
        }

        public void threadRectangle()
        {
            for (int i = 0; i < 1000; i++)
            {
                int width = rdm.Next(0, 550);
                int height = rdm.Next(0, 300);
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Black, 5), width, height, 50, 50);
                Thread.Sleep(3000);
            }
        }
        private void btnRectangle_Click(object sender, EventArgs e)
        {
          Thread thRectangle = new Thread(threadRectangle);
            thRectangle.Start(); 
        }
     
        public void threadCircle()
        {
            for (int i = 0; i < 1000; i++)
            {
                int width = rdm.Next(0, 550);
                int height = rdm.Next(0, 300);
                this.CreateGraphics().DrawEllipse(new Pen(Brushes.Green, 8), width, height, 50, 50);
                Thread.Sleep(4000);
               
            }
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Thread thCircle = new Thread(threadCircle);
            thCircle.Start();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdm = new Random();
        }
    }
}
