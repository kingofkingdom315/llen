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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            List<Post> ps = DBConnection.Entities.Posts.ToList();
            foreach (Post p in ps)
            {
                post_comb.Items.Add(p.PostName);
            }
            List<MaterialType> mt = DBConnection.Entities.MaterialTypes.ToList();
            foreach (MaterialType m in mt)
            {
                mat_type_comb.Items.Add(m.Materials);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Material mt = new Material();
            mt.Price = Convert.ToDecimal(price_txt.Text);
            mt.MaterialName = name_text.Text;
            List<MaterialType> mtype = DBConnection.Entities.MaterialTypes.ToList();
            foreach (MaterialType m in mtype)
            {
                if (mat_type_comb.SelectedItem.ToString() == m.Name)
                {
                    mt.Type = m.ID;
                }
            }
            Post_Material pm = new Post_Material();
            pm.MaterialId = mt.ID;
            List<Post> ps = DBConnection.Entities.Posts.ToList();
            foreach (Post p in ps)
            {
                if (post_comb.SelectedItem.ToString() == p.PostName)
                {
                    pm.PostId = p.ID;
                }
            }
            Warehouse wh = new Warehouse();
            wh.Count = Convert.ToInt32(count_txt);
            wh.Price = Convert.ToDecimal(price_txt.Text);
            wh.Info = pm.ID;
            wh.AdDate = date_pick.Value;
            AddForm f = new AddForm();
            f.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            f.Close();
        }
    }
}
