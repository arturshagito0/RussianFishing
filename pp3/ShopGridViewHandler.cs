using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace pp3
{
    public static class ShopGridViewHandler

    {


        public static void selectRods(bool all, Rod.ROD_TYPE type, bool unique, DataGridView datagrid, List<Rod> allRods)
        {

            datagrid.Columns.Clear();
            datagrid.AutoGenerateColumns = false;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;




            if (all)
            {
                datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DataGridViewImageColumn iconColumn = new DataGridViewImageColumn();
                iconColumn.DataPropertyName = "icon";
                iconColumn.FillWeight = 30;
                datagrid.Columns.Add(iconColumn);


                DataGridViewColumn column1 = new DataGridViewTextBoxColumn();
                column1.DataPropertyName = "rodName";
                column1.Name = "Удилища";
                column1.FillWeight = 200;
                datagrid.Columns.Add(column1);

                DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
                column2.DataPropertyName = "maxWeight";
                column2.Name = "Вес (кг)";
                datagrid.Columns.Add(column2);


                datagrid.DataSource = allRods;
            }

            else { 


                var rods = allRods;


                List<Rod> uniqueRods = rods.FindAll(e => e.getUniqueness() == unique);
                List<Rod> selectedRods = rods.FindAll(e => e.getRodType() == type && e.getUniqueness() == unique); ;

            

            if (unique)
            {
                datagrid.DataSource = uniqueRods;
            }

            else
            {
                datagrid.DataSource = selectedRods;
            }

        }

            if (datagrid.Columns.Count == 0)
            {

                DataGridViewColumn column1 = new DataGridViewTextBoxColumn();
                column1.DataPropertyName = "rodName";
                column1.Name = "Удилища";
                datagrid.Columns.Add(column1);

                DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
                column2.DataPropertyName = "maxWeight";
                column2.Name = "Выдерживает вес";
                datagrid.Columns.Add(column2);

                if (!all) { 

                DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
                column3.DataPropertyName = "price";
                column3.Name = "Цена";
                column3.DefaultCellStyle.Format = "c0";
                column3.DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("ru");
                datagrid.Columns.Add(column3);
                }
                
                
                

            }



        }


        public static void selectReels(bool unique, DataGridView datagrid, ObjectInitializer initializer)

        {

            var reels = initializer.Reels;

            List<Reel> selectedReels = reels.FindAll(e => e.unique == unique);

            datagrid.Columns.Clear();
            datagrid.AutoGenerateColumns = false;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid.DataSource = selectedReels;



            if (datagrid.Columns.Count == 0)
            {
                DataGridViewColumn column1 = new DataGridViewTextBoxColumn();
                column1.Name = "Катушка";
                column1.DataPropertyName = "name";

                DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
                column2.Name = "Мощность";
                column2.DataPropertyName = "power";


                DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
                column3.Name = "Цена";
                column3.DataPropertyName = "price";

                datagrid.Columns.Add(column1);
                datagrid.Columns.Add(column2);
                datagrid.Columns.Add(column3);
            }


        }





    }


}
