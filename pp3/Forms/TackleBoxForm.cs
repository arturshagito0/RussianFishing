using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pp3.Forms
{
    public partial class TackleBoxForm : Form
    {
        private readonly Player currentPlayer;
        List<Rod> playerRods;
        Point lastPoint;

        public TackleBoxForm(Player player, ObjectInitializer initializer)
        {
            
            InitializeComponent();

            this.currentPlayer = player;
            ShowPlayerRods(null, null) ;
            EventHandlers.ItemToBeAdded += ShowPlayerRods;


            //pictureBox2.Image = player.playerInventory.getAllRods()[0].icon;

        }

        
        private void ShowPlayerRods(object sender, GameObject deducted)
        {
            MessageBox.Show("UPDATED");
            playerRods = currentPlayer.playerInventory.getAllRods();
            ShopGridViewHandler.selectRods(true, Rod.ROD_TYPE.POPLAVOK,
                            true, rodsGrid, playerRods);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
