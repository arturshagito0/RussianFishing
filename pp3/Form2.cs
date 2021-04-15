using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Globalization;

namespace pp3
{
    public partial class FishshopForm : Form
    {

        public List<Label> displayedLabels;
        public List<PictureBox> leftButtons;
        public List<Label> leftLabels;
        public List<PictureBox> topButtons = new List<PictureBox>();

        public FishshopForm()
        {

            Load += RodButton_Click;
           
            
            InitializeComponent();
            DrawingControl.SetDoubleBuffered(dataGridView1);
            

            topButtons = panel1.Controls.OfType<PictureBox>().ToList();

            
            displayedLabels = new List<Label> { NameOfItem, Description, MaxWeight, Price, };

            leftButtons = new List<PictureBox> { RodButton,
                ReelButton,
                LineButton,
                HookButton,
                BaitButton,
                CormButton,
                AccessoriesButton,
                PrivateButton};

            leftLabels = new List<Label> { rodLabel, reelLabel, lineLabel, hookLabel, cormLabel, baitLabel };



            }

        private void labelDisabler(PictureBox picture, Label label, List<PictureBox> buttons)
        {
            picture.BackColor = Color.LightSkyBlue;
            label.BackColor = Color.LightSkyBlue;
            foreach (PictureBox pb in buttons)
            {
                pb.Enabled = true;
                pb.Visible = true;
            }



            foreach (var l in leftLabels)
            {
                if (l != label)
                {
                    l.BackColor = Color.Transparent;
                }
            }

            foreach (var p in leftButtons)
            {
                if (p != picture)
                {
                    p.BackColor = Color.Transparent;
                }
            }

            
                foreach (var b in topButtons.Except(buttons))
                {
                b.Visible = false;
                b.Enabled = false;
                }
            

            
           


        }

        

        private void FishshopForm_Load(object sender, EventArgs e)
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MaxWeight_Click(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            var selectedRod = (Object) dataGridView1.CurrentRow.DataBoundItem;
            
            ShopObjectViewWindowHandler.DisplayItem(dataGridView1, selectedRod, displayedLabels, pictureBox1);

           
        }

        private void poplavokButton_MouseEnter(object sender, EventArgs e)
        {
            poplavokButton.Image = pp3.Properties.Resources.cat_popl_a;
            
        }

        private void poplavokButton_Click(object sender, EventArgs e)
        {
            poplavokButton.Image = pp3.Properties.Resources.cat_popl_s;
            Load += spinningButton_MouseLeave;
            ShopGridViewHandler.selectRods(Rod.ROD_TYPE.POPLAVOK, false, dataGridView1);
            

            
        }

       

       



        private void spinningButton_Click(object sender, EventArgs e)
        {
            spinningButton.Image = Properties.Resources.cat_spin_s;
            
           

            ShopGridViewHandler.selectRods(Rod.ROD_TYPE.SPINNING, false, dataGridView1);

            
        }

        private string changeLetter(string s, char c)
        {
            char[] chars = s.ToCharArray();
            chars[s.Length - 1] = c;
            return new string(chars);
        }

     

        private void poplavokButton_MouseLeave(object sender, EventArgs e)
        {
            poplavokButton.Image = Properties.Resources.cat_popl_d;
        }

        private void spinningButton_MouseEnter(object sender, EventArgs e)
        {
            spinningButton.Image = Properties.Resources.cat_spin_a;
            
        }

        private void spinningButton_MouseLeave(object sender, EventArgs e)
        {
            spinningButton.Image = Properties.Resources.cat_spin_d;
        }

        private void uniqueButton_Click(object sender, EventArgs e)
        {
            uniqueRodButton.Image = Properties.Resources.cat_uniq_s;
            ShopGridViewHandler.selectRods(Rod.ROD_TYPE.POPLAVOK, true, dataGridView1);
        }

        private void uniqueButton_MouseEnter(object sender, EventArgs e)
        {
            uniqueRodButton.Image = Properties.Resources.cat_uniq_a;

        }

        private void uniqueButton_MouseLeave(object sender, EventArgs e)
        {
            uniqueRodButton.Image = Properties.Resources.cat_uniq_d;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            labelDisabler(ReelButton, reelLabel, new List<PictureBox> {normalReelButton, uniqueReelButton});
            reelLabel.BackColor = Color.LightSkyBlue;
        }


        private void LineButton_Click(object sender, EventArgs e)
        {
           // labelDisabler(LineButton, lineLabel, );
            

        }

        private void RodButton_Click(object sender, EventArgs e)
        {
            poplavokButton_Click(sender, e);
            labelDisabler(RodButton, rodLabel, new List<PictureBox> { poplavokButton, spinningButton, uniqueRodButton });

          

        }

        private void normalReelButton_Click(object sender, EventArgs e)
        {
            normalReelButton.Image = Properties.Resources.cat_ordin_s;
            ShopGridViewHandler.selectReels(false, dataGridView1);
            MessageBox.Show(dataGridView1.Columns.Count.ToString());
        }

        private void normalReelButton_MouseEnter(object sender, EventArgs e)
        {
            normalReelButton.Image = Properties.Resources.cat_ordin_s;
        }
    

        private void normalReelButton_MouseLeave(object sender, EventArgs e)
        {
            normalReelButton.Image = Properties.Resources.cat_ordin_d;
        }

        private void uniqueReelButton_Click(object sender, EventArgs e)
        {
            uniqueReelButton.Image = Properties.Resources.cat_uniq_s;
        }

        private void uniqueReelButton_MouseEnter(object sender, EventArgs e)
        {
            uniqueReelButton.Image = Properties.Resources.cat_uniq_a;
        }

        private void uniqueReelButton_MouseLeave(object sender, EventArgs e)
        {
            uniqueReelButton.Image = Properties.Resources.cat_uniq_d;
        }
    }
    
}
