using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectBD2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool doesExist = false;
            // check if user exists in data base
            using (var conn =
                new SqlConnection("Data Source=(local);Initial Catalog=BD2;Integrated Security=SSPI"))
            {

                conn.Open();
                using (SqlCommand cmd = new SqlCommand("select * from Users", conn))
                {

                    SqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        var user = rdr[0].ToString();
                        var pass = rdr[1].ToString();

                        if (user.Equals(textBox1.Text) && pass.Equals(textBox2.Text))
                        {
                            doesExist = true;
                        }
                    }
                }
            }

            if (doesExist)
            {
                new Form2().Show();
            } else
            {
                label3.Text = "Invalid credentials";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
