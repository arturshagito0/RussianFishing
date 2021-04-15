using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pp3
{
    public static class ShopObjectViewWindowHandler
    {
        public static void DisplayItem(DataGridView datagrid, Object selectedRodd, List<Label> controls, PictureBox picturebox)
        {

            
            Type member = datagrid.DataSource.GetType().GetGenericArguments()[0];
            
            if (member == typeof(Rod))
            {
                DisplayRod((Rod)selectedRodd);
            }

            else if (member == typeof(Reel))
            {
                DisplayReel((Reel)selectedRodd);
            }


            void DisplayReel(Reel reel)
            {
                controls[1].Text = "Чем мощнее катушка тем легче вытащить рыбу";
                
                controls[0].Text = reel.name;
                MessageBox.Show(reel.name);
                controls[2].Text = $"Мощность: {reel.power}%";

                StringFormatter sf = new StringFormatter();
                controls[3].Text = $"Цена: {sf.decimalFormat(reel.price.ToString(), StringFormatter.FORMAT_KIND.CURR)}";

                picturebox.Image = (Bitmap) Properties.Resources.ResourceManager.GetObject(reel.name);
            }




             void DisplayRod(Rod selectedRod)
            {
                if (selectedRod.getRodType() == Rod.ROD_TYPE.POPLAVOK)
                {
                    controls[1].Text = "Поплавочное удилище";

                }

                else
                {
                    controls[1].Text = "Спиннинг";
                }



                var c = StringFormatter.FORMAT_KIND.CURR;
                var m = StringFormatter.FORMAT_KIND.WEIGHT;

                Bitmap im = (Bitmap)Properties.Resources.ResourceManager.GetObject(selectedRod.rodName);

                StringFormatter formatter = new StringFormatter();



                picturebox.Image = im;

                controls[3].Text = $"Цена: {formatter.decimalFormat(selectedRod.price.ToString(), c)}";
                controls[0].Text = selectedRod.rodName;
                controls[2].Text = $"Выдерживает: {formatter.decimalFormat(selectedRod.maxWeight.ToString(), m)}";
            }



        }

        
    }
}
