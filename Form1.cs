using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindFormPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("폼 클릭~");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("반갑습니다~");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("사진 클릭~");
        }
    }
}
