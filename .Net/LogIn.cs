using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clienteSD
{
    public partial class LogIn : Form
    {

        string salt = "emkF9f1uQoQ22BqtMAOtbBHqib56mqkDlIxqYcKIwZa3AAlL646MZWw7taWgEV27k3gP1NO";
        
        public LogIn()
        {
            InitializeComponent();
            crearusuario.Visible = false;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void lineShape2_Click(object sender, EventArgs e)
        {

        }

        private void iniciarsesion_Click(object sender, EventArgs e)
        {
            string usuario = textUser.Text;
            string password = textPass.Text;

            if (Login(usuario, password))
            {
                Log.Escribir("Operacion: Se ha iniciado sesión",
                             usuario);
                Form1 form1 = new Form1();
                form1.User = usuario;
                form1.Tag = this;
                form1.Show(this);
                Hide();
            }

        }

        private bool Login(string usuario, string password)
        {
            string[] lines = System.IO.File.ReadAllLines("login.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                string[] partes = lines[i].Split(' ');
                if (usuario == partes[0] && AreEqual(password, partes[1], salt))
                    return true;
            }

            return false;
        }

        private void crearusuario_Click(object sender, EventArgs e)
        {
            string usuario = textUser.Text;
            string password = textPass.Text;
            
            string passwordHash = GenerateHash(password, salt);
            if (!System.IO.File.Exists("login.txt"))
            {
                System.IO.File.WriteAllText("login.txt", usuario + " " + passwordHash + "\n");
            }
            else
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter("login.txt");
                file.WriteLine(usuario + " " + passwordHash);
            }
        }
        public string GenerateHash(string input, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed sHA256ManagedString = new SHA256Managed();
            byte[] hash = sHA256ManagedString.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public bool AreEqual(string plainTextInput, string hashedInput, string salt)
        {
            string newHashedPin = GenerateHash(plainTextInput, salt);
            return newHashedPin.Equals(hashedInput);
        }
    }
}
