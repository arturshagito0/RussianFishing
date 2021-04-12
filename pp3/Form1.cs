using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pp3
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_MouseCaptureChanged(object sender, EventArgs e)
		{

		}

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FoodShopButton_MouseHover(object sender, EventArgs e)
        {
			
        }

        private void FoodShopButton_MouseEnter(object sender, EventArgs e)
        {
			
		}

        private void FishShopButton_MouseEnter(object sender, EventArgs e)
        {
			FishShopButton.Image = pp3.Properties.Resources.base_shop_a;
		}

        private void FishShopButton_MouseLeave(object sender, EventArgs e)
        {
			FishShopButton.Image = pp3.Properties.Resources.base_shop_d;
		}

        private void FishShopButton_MouseClick(object sender, MouseEventArgs e)
        {
			var myForm = new Form2();
			myForm.show();
        }
    }
}
