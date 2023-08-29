using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Data;

namespace PasswordGenerator
{
    public partial class GeneratePasswordForm : Form
    {
        public GeneratePasswordForm()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\fullt\\Source\\Repos\\PasswordGenerator\\PasswordGenerator\\PasswordDatabase.mdf;Integrated Security=True");
        private void generateBtn_Click(object sender, EventArgs e)
        {
            int length = 0;
            //make a random number between 8 and 20 based on suggested password length requirements
            //use the random number to decide the password length
            //and generate a series of random upper/lower/special character password
            //and show the password
            passwordLbl.Text = Generator(Randomizer(length));
        }

        private static string Generator(int length)
        {
            Random rnd = new Random();
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string number = "1234567890";
            const string special = "!@#$%^&*()-_=+";
            var bytes = new byte[length];

            StringBuilder result = new StringBuilder();
            new RNGCryptoServiceProvider().GetBytes(bytes);

            foreach(byte b in bytes)
            {
                switch(rnd.Next(4))
                {
                    case 0:
                        result.Append(lower[b % lower.Count()]);
                        break;
                    case 1:
                        result.Append(upper[b % upper.Count()]);
                        break;
                    case 2:
                        result.Append(number[b % number.Count()]);
                        break;
                    case 3:
                        result.Append(special[b % special.Count()]);
                        break;
                }
            }

            return result.ToString();
        }

        private int Randomizer(int num)
        {
            Random rnd = new Random();

            num = rnd.Next(8, 20);

            return num;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //save the generated password into the database
            //if the password is not generated, throw an error

            if(passwordLbl.Text == "")
            {
                MessageBox.Show("You must first generate a password before saving.", "No Password to Save", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(passwordNameBox.Text == "")
            {
                MessageBox.Show("You must provide a name for the password before saving.", "No Password Name",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("AddPassword", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = passwordNameBox.Text.ToString();
                cmd.Parameters.AddWithValue("@password", SqlDbType.NVarChar).Value = passwordLbl.Text;
                try
                {
                    con.Open();
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your new password has been saved.", "Success", MessageBoxButtons.OK);
                }
                catch(SqlException ex)
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
}