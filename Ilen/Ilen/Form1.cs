using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ilen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Fill();
        }

        public void Fill()
        {
            all_mat_list.Items.Clear();

            List<Warehouse> li = DBConnection.Entities.Warehouses.ToList();
            List<MaterialOff> mo = DBConnection.Entities.MaterialOffs.ToList();
            List<MaterialProd> mp = DBConnection.Entities.MaterialProds.ToList();
            
            foreach (Warehouse w in li)
            {
                foreach (MaterialOff m in mo)
                {
                    if(w.ID == m.Material)
                        goto endchsikl;
                }
                foreach (MaterialProd m in mp)
                {
                    if (w.ID == m.Material)
                        goto endchsikl;
                }
                all_mat_list.Items.Add(w);
            endchsikl:{ }
            }

        }

        private void add_off_mat_btn_Click(object sender, EventArgs e)
        {
            MaterialOff mo = new MaterialOff();
            Warehouse wh = (Warehouse)all_mat_list.SelectedItem;

            mo.Material = wh.ID;
            mo.Price = wh.Price;
            mo.Count = wh.Count;
            mo.DateOff = DateTime.Today;

            DBConnection.Entities.MaterialOffs.Add(mo);
            DBConnection.Entities.SaveChanges();

            this.Fill();
        }

        private void add_prod_mat_btn_Click(object sender, EventArgs e)
        {
            MaterialProd mo = new MaterialProd();
            Warehouse wh = (Warehouse)all_mat_list.SelectedItem;

            mo.Material = wh.ID;
            mo.Price = wh.Price;
            mo.Count = wh.Count;
            mo.TransDate = DateTime.Today;

            DBConnection.Entities.MaterialProds.Add(mo);
            DBConnection.Entities.SaveChanges();

            this.Fill();
        }

        private void mat_off_btn_Click(object sender, EventArgs e)
        {
            OffMat of = new OffMat();
            List<MaterialOff> li = DBConnection.Entities.MaterialOffs.ToList();

            of.ShowDialog(li);

            this.Fill();
        }

        private void prod_mat_btn_Click(object sender, EventArgs e)
        {

        }

        private void add_mat_btn_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            f.ShowDialog();
            Fill();
        }
    }
}
