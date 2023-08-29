using System.Security.Cryptography;
using System.Text;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
    }
}