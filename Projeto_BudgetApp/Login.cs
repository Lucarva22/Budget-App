using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_BudgetApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(622, 398);
            panel1.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financialAppDataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter1.Fill(this.financialAppDataSet.Login);
            panel1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string encrypt = CipherUtility.Encrypt<AesManaged>(txtPass.Text, "gestaofinancas", "salt");

            loginBindingSource1.Filter = "Login = '" + txtLogin.Text.ToLower() + "' and Pass ='" + encrypt + "'";

            if (loginBindingSource1.Count == 0)
            {
                MessageBox.Show("O utilizador e\\ou a password não existem ou correspondem", "Informação de Erro");
            }
            else
            {
                FormMenu x = new FormMenu(txtLogin.Text);
                x.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string login = txtNewLogin.Text.ToLower();
            string email = txtNewEmail.Text.ToLower();
            string pass = txtNewPass.Text;

            string encrypt = CipherUtility.Encrypt<AesManaged>(pass, "gestaofinancas", "salt");

            try
            {
                loginTableAdapter1.Insert(login, email, encrypt);
                MessageBox.Show("Resgisto efetuado com sucesso");
            }
            catch
            {
                MessageBox.Show("O utilizador já existe e\\ou os campos inseridos incorretamente", "Informação de Erro");
            }
        }


        public class CipherUtility
        {
            public static string Encrypt<T>(string value, string password, string salt)
                where T : SymmetricAlgorithm, new()
            {
                PasswordDeriveBytes rgb = new PasswordDeriveBytes(password, Encoding.Unicode.GetBytes(salt));

                SymmetricAlgorithm algorithm = new T();

                byte[] rgbKey = rgb.GetBytes(algorithm.KeySize >> 3);
                byte[] rgbIV = rgb.GetBytes(algorithm.BlockSize >> 3);

                ICryptoTransform transform = algorithm.CreateEncryptor(rgbKey, rgbIV);

                using (MemoryStream buffer = new MemoryStream())
                {
                    using (CryptoStream stream = new CryptoStream(buffer, transform, CryptoStreamMode.Write))
                    {
                        using (StreamWriter writer = new StreamWriter(stream, Encoding.Unicode))
                        {
                            writer.Write(value);
                        }
                    }

                    return Convert.ToBase64String(buffer.ToArray());
                }
            }
        }
    }
}

