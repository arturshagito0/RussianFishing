using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace pp3
{
    public static class ShopObjectViewWindowHandler
    {
        public static void DisplayItem(DataGridView datagrid, Object selectedItem, List<Label> controls, PictureBox picturebox)
        {


            Type member = datagrid.DataSource.GetType().GetGenericArguments()[0];

            if (member == typeof(Rod))
            {
                DisplayRod((Rod)selectedItem);
            }

            else if (member == typeof(Reel))
            {
                DisplayReel((Reel)selectedItem);
            }


            void DisplayReel(Reel reel)
            {
                picturebox.Image = null;
                controls[1].Text = "Чем мощнее катушка тем легче вытащить рыбу";

                picturebox.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(reel.name);
                

                controls[0].Text = reel.name;

                controls[2].Text = $"Мощность: {reel.power}%";

                
                controls[3].Text = $"Цена: {StringFormatter.decimalFormat(reel.price.ToString(), StringFormatter.FORMAT_KIND.CURR)}";



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

                



                picturebox.Image = im;

                controls[3].Text = $"Цена: {StringFormatter.decimalFormat(selectedRod.price.ToString(), c)}";
                controls[0].Text = selectedRod.rodName;
                controls[2].Text = $"Выдерживает: {StringFormatter.decimalFormat(selectedRod.maxWeight.ToString(), m)}";
            }



        }


    }
}
