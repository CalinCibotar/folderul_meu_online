using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaActivitati
{
    public partial class FormLogin: Form
    {
        //utilizatorul implicit
        private Utilizator utilizator = new Utilizator("admin", "192004");

        //constructor
        public FormLogin()
        {
            InitializeComponent();
            LoadSavedCredentials();
        }

        //metoda pentru a incarca credentialele salvate
        private void LoadSavedCredentials()
        {
            if (Properties.Settings.Default.RememberMe)
            {
                txtUsername.Text = Properties.Settings.Default.Username;
                chkRememberMe.Checked = true;
            }
        }

        //metoda pentru a verifica autentificarea
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (utilizator.VerificaAutentificarea(username, password))
            {
                if (chkRememberMe.Checked)
                {
                    Properties.Settings.Default.Username = username;
                    Properties.Settings.Default.RememberMe = true;
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
                Properties.Settings.Default.Save();

                FormAgenda agenda = new FormAgenda();
                agenda.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Autentificare eșuată!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
