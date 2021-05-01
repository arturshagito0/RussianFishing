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

namespace pp3
{
    public partial class TravelForm : Form
    {
        private PictureBox previous = new PictureBox();
        private Image previousPicture = Properties.Resources.blackkrug;
        private Player currentPlayer;
        private ObjectInitializer initializer;
        private Base selectedBase;

        Point lastPoint;



        public TravelForm(Player currentPlayer, ObjectInitializer initializer)
        {
            InitializeComponent();

            this.currentPlayer = currentPlayer;
            this.initializer = initializer;

            reDrawButtons();


            

            initializer.Maps.ForEach(e => {
                ListViewItem item = new ListViewItem(e.displayName);
                item.Name = e.displayName;
                listView1.Items.Add(item);
                    }
                );
            listView1.View = View.Details;
            listView1.AutoResizeColumns(0);


            ManuallyEnableButton += ManualButtonChange;
            

            listView1.Items[0].Selected = true;
            listView1_Click(null, null);

            listView1.Sorting = SortOrder.Ascending;



            foreach (PictureBox button in panel2.Controls.OfType<PictureBox>().ToList())
            {
                button.Click += MapButtonClicked;
                button.Click += playSound;
                
            }


        }

        private EventHandler<String> ManuallyEnableButton;


        private void ManualButtonChange(object sender, String e)
        {
            MapButtonClicked(panel2.Controls.OfType<PictureBox>().ToList().Find(b => b.Name == e), null);
        }

        private void ShowMapDetails(object sender, EventArgs e)
        {
            
            
            this.selectedBase = initializer.Maps.Find(b => b.mapName == ((PictureBox)sender).Name);
            listView1.Items.Find(selectedBase.displayName, true)[0].Selected = true;
            listView1.Items.Find(selectedBase.displayName, true)[0].Focused = true;

            nameLabel.Text = selectedBase.displayName;
            priceLabel.Text = $"Цена за день: {StringFormatter.decimalFormat(selectedBase.price.ToString(), StringFormatter.FORMAT_KIND.CURR)}";
            rankLabel.Text = $"Требуется разряд: {selectedBase.rank}";
            karmaLabel.Text = $"Требуется кармы: {selectedBase.karma}";
            locationImage.Image = selectedBase.indexImage;
        }
        

        private void playSound(object sender, EventArgs e)
        {
            EventHandlers.OnButtonClickSound?.Invoke(null, null);
        }

        private void MapButtonClicked(object sender, EventArgs e)
        {


            playSound(null, null);

            ShowMapDetails(sender, null);
            this.previous.Image = this.previousPicture;

            PictureBox button = (PictureBox)sender;
            



            this.previous = button;
            this.previousPicture = button.Image;

           
            button.Image = button.Image = Properties.Resources.greenkrug;

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reDrawButtons(PictureBox toIgnore = null)
        {
            foreach (PictureBox button in panel2.Controls.OfType<PictureBox>().ToList())
            {
                if (toIgnore != button)
                {
                    
                    button.BackColor = Color.Transparent;
                    Base baseToQuery = initializer.Maps.Find(e => e.mapName == button.Name);
                    if (currentPlayer.money >= baseToQuery.price && currentPlayer.karma >= baseToQuery.karma)
                    {
                        button.Image = Properties.Resources.redkrug;
                    }

                    else
                    {
                        button.Image = Properties.Resources.blackkrug;
                    }

                }
            }
        }

        private void goButton_MouseHover(object sender, EventArgs e)
        {

        }

        private void goButton_MouseLeave(object sender, EventArgs e)
        {
            goButton.Image = Properties.Resources.go_d;
        }

        private void goButton_MouseEnter(object sender, EventArgs e)
        {
            goButton.Image = Properties.Resources.go_a;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {

            this.selectedBase = initializer.Maps.Find(b => b.displayName == listView1.SelectedItems[0].Text);
            ManuallyEnableButton?.Invoke(null, this.selectedBase.mapName);
             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            playSound(null, null);
            this.Hide();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.exit_a;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.exit_a;
        }

        private void TravelForm_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void TravelForm_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_PaddingChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void goButton_Click(object sender, EventArgs e)
        {

            if (selectedBase != null)
            {
                if (currentPlayer.money <= selectedBase.price)
                {
                    MessageBox.Show("Not enough money to travel to base!");
                }

                else if (currentPlayer.karma < selectedBase.karma)
                {
                    MessageBox.Show("Not enough karma!" + "   " +  selectedBase.displayName);
                }

                else
                {
                    EventHandlers.OnItemBought(null, selectedBase.price);
                    EventHandlers.OnButtonClickSound(null, null);
                    EventHandlers.OnCanBeBought(null, false);
                }
            }
            
        }

       
    }
}
