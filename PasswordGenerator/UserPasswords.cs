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

namespace PasswordGenerator
{
    public partial class UserPasswords : Form
    {
        private ListViewItem passwordListItem;

        public UserPasswords()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = PasswordGeneratorDB; Integrated Security = True");

            SqlCommand cmd = new SqlCommand("ShowAllPasswords", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                cmd.Connection = con;

                passwordList.Items.Clear();

                while (reader.Read())
                {
                    passwordListItem = new ListViewItem(reader.GetString(0).ToString());
                    passwordListItem.SubItems.Add(reader.GetString(1).ToString());

                    passwordList.Items.Add(passwordListItem);
                }

                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
