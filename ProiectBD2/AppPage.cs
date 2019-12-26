using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectBD2
{
    public partial class AppPage : Form
    {
        public AppPage()
        {
            InitializeComponent();
        }

        private void AppPage_Load(object sender, EventArgs e)
        {
            // columns
            listView1.View = View.Details;
            listView2.View = View.Details;

            for (int i = 0; i < 100; i++)
            {
                listView1.Items.Add(new ListViewItem(new string[] { "malone", "trhiller", "pula", "cacat", "pisat", "sloboz" }));
            }
        }
    }
}
