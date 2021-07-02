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

            
         
        }

        
        private void ShowPlayerRods(object sender, GameObject deducted)
        {

            playerRods = currentPlayer.playerInventory.GetItemsOfSpecificType<Rod>();
            ShopGridViewHandler.selectRods(true, Rod.ROD_TYPE.POPLAVOK,
                            true, rodsGrid, playerRods);

            if (rodsGrid.Rows.Count > 0)
            {
                rodsGrid.CurrentCell = rodsGrid.Rows[0].Cells[1];
                rodsGrid_Click(null, null);
               

            }

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

        private void rodsGrid_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void rodsGrid_Click(object sender, EventArgs e)
        {
            Rod r = (Rod)rodsGrid.CurrentRow.DataBoundItem;

            rodImage.Image = r.rodImage;
            iconBox.Image = r.icon;
            conditionLabel.Text = "Состояние: ";
            nameLabel.Text = r.rodName;
            weightLabel.Text = $"Макс. вес: {r.maxWeight} кг.";

        }












        #region HoverEvents
        private void getButton_MouseEnter(object sender, EventArgs e)
        {
            getButton.Image = Properties.Resources.get_a;
        }

        private void getButton_MouseLeave(object sender, EventArgs e)
        {
            getButton.Image = Properties.Resources.get_d;
        }

        private void throwAwayButton_MouseEnter(object sender, EventArgs e)
        {
            throwAwayButton.Image = Properties.Resources.remove_a;             ;
        }

        private void throwAwayButton_MouseLeave(object sender, EventArgs e)
        {
            throwAwayButton.Image = Properties.Resources.remove_d;
        }

        private void repairButton_MouseEnter(object sender, EventArgs e)
        {
            repairButton.Image = Properties.Resources.repair_a;
        }

        private void repairButton_MouseLeave(object sender, EventArgs e)
        {
            repairButton.Image = Properties.Resources.repair_d;
        }

        private void signButton_MouseEnter(object sender, EventArgs e)
        {
            signButton.Image = Properties.Resources.label_a;
        }

        private void signButton_MouseLeave(object sender, EventArgs e)
        {
            signButton.Image = Properties.Resources.label_d;
        }

        private void storageButton_MouseEnter(object sender, EventArgs e)
        {
            storageButton.Image = Properties.Resources.store_a;
        }

        private void storageButton_MouseLeave(object sender, EventArgs e)
        {
            storageButton.Image = Properties.Resources.store_d;
        }

        private void sellButton_MouseEnter(object sender, EventArgs e)
        {
            sellButton.Image = Properties.Resources.sell_a;
        }

        private void sellButton_MouseLeave(object sender, EventArgs e)
        {
            sellButton.Image = Properties.Resources.sell_d;
        }

        private void installRuneButton_MouseEnter(object sender, EventArgs e)
        {
            installRuneButton.Image = Properties.Resources.setrune_a;
        }

        private void installRuneButton_MouseLeave(object sender, EventArgs e)
        {
            installRuneButton.Image = Properties.Resources.setrune_d;
        }

        #endregion

        private void reelsButton_Click(object sender, EventArgs e)
        {
            InventoryGridHandler.ShowItems<Reel>(itemsGrid, currentPlayer.playerInventory);
            //itemsGrid.DataSource = currentPlayer.playerInventory.GetItemsOfSpecificType<Reel>();
        }
    }
}
