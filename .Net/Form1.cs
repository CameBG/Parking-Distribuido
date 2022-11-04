using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        ArrayList sondas;
        List<string> ips;
        public string User;
        static string KEY = "abewqlo1469kstq1";
        public Form1()
        {
            InitializeComponent();
            sondas = new ArrayList();
            ips = new List<string>();
            comboBox2.Items.Add("Volumen");
            comboBox2.Items.Add("Led");
            comboBox2.Items.Add("UltimaFecha");
            comboBox2.Items.Add("Fecha");
            label1.Visible = false;
            label2.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataProbe_TextChanged(object sender, EventArgs e)
        {

        }

        private void addProbe_Click(object sender, EventArgs e)
        {
            localhost.Sonda sonda = new localhost.Sonda();
            string direccion = dataProbe.Text;
            string nombre = probeName.Text;
            string[] partes = direccion.Split(':');
            sonda.Url = "http://" + direccion + "/EjemploServiciosWeb/services/Sonda.SondaHttpSoap11Endpoint/";
            if (sonda.nuevaSonda(doEncryptAES(nombre, KEY), doEncryptAES(User, KEY), doEncryptAES(partes[0], KEY))) 
            {
                listBox1.Items.Add(direccion);
                ips.Add(partes[0]);
                sondas.Add(sonda);
                comboBox1.Items.Add(nombre);
                comboBox3.Items.Add(nombre);
                Log.EscribirSonda("Operacion: Añadir la siguiente sonda: " + nombre, User, partes[0]);
            }
        }

        private void consultProbe_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                label1.Visible = true;
                label1.Text = "No has seleccionado la sonda o la propiedad de la sonda que buscas.";
                return;
            }
            else
            {
                String mensaje = "El valor consultado es ";
                int numSonda = comboBox1.SelectedIndex;
                String ip = ips[numSonda];
                localhost.Sonda sonda = (localhost.Sonda)sondas[numSonda];
                if (comboBox2.SelectedItem.Equals("Volumen"))
                {
                    Log.EscribirSonda("Operacion: GetVolumen sobre la sonda:" + comboBox1.Text, User, ip);
                    mensaje += doDecryptAES(sonda.getVolumen(doEncryptAES((comboBox1.Text), KEY), doEncryptAES(User, KEY), doEncryptAES(ip, KEY)), KEY);
                }
                else if (comboBox2.SelectedItem.Equals("Led"))
                {
                    Log.EscribirSonda("Operacion: GetLed sobre la sonda:" + comboBox1.Text, User, ip);
                    mensaje += doDecryptAES(sonda.getLed(doEncryptAES((comboBox1.Text), KEY), doEncryptAES(User, KEY), doEncryptAES(ip, KEY)), KEY);
                }
                else if (comboBox2.SelectedItem.Equals("UltimaFecha"))
                {
                    Log.EscribirSonda("Operacion: GetUltimaFecha sobre la sonda:" + comboBox1.Text, User, ip);
                    mensaje += doDecryptAES(sonda.getUltimaFecha(doEncryptAES((comboBox1.Text), KEY), doEncryptAES(User, KEY), doEncryptAES(ip, KEY)), KEY);
                }
                else if (comboBox2.SelectedItem.Equals("Fecha"))
                {
                    Log.EscribirSonda("Operacion: GetFecha: ", User, ip);
                    mensaje += sonda.getFecha();
                }
                
                label1.Visible = true;
                label1.Text = mensaje;
            }

        }
       

        private void updateProbe_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == -1 )
            {
                label2.Visible = true;
                label2.Text = "No has seleccionado la sonda";
                return;
            }
            else
            {
                String mensaje = "El valor ha sido actualizado correctamente a: " + newValue.Text;
                int numSonda = comboBox3.SelectedIndex;
                String ip = ips[numSonda];
                localhost.Sonda sonda = (localhost.Sonda)sondas[numSonda];
                sonda.setLed(doEncryptAES(newValue.Text, KEY), doEncryptAES((comboBox3.Text), KEY), doEncryptAES(User, KEY), doEncryptAES(ip, KEY));
                label2.Visible = true;
                label2.Text = mensaje;
                Log.EscribirSonda("Operacion: SetLed sobre la sonda:" + comboBox3.Text, User, ip);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static String doEncryptAES(String plainText, String key)
        {
            var plainBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(Encrypt(plainBytes, getRijndaelManaged(key)));
        }

        public static String doDecryptAES(String encryptedText, String key)
        {
            var encryptedBytes = Convert.FromBase64String(encryptedText);
            return Encoding.UTF8.GetString(Decrypt(encryptedBytes, getRijndaelManaged(key)));
        }

        private static RijndaelManaged getRijndaelManaged(String secretKey)
        {
            var keyBytes = new byte[16];
            var secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);
            Array.Copy(secretKeyBytes, keyBytes, Math.Min(keyBytes.Length, secretKeyBytes.Length));
            return new RijndaelManaged
            {
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7,
                KeySize = 128,
                BlockSize = 128,
                Key = keyBytes,
                IV = keyBytes
            };
        }

        private static byte[] Encrypt(byte[] plainBytes, RijndaelManaged rijndaelManaged)
        {
            return rijndaelManaged.CreateEncryptor()
                .TransformFinalBlock(plainBytes, 0, plainBytes.Length);
        }

        private static byte[] Decrypt(byte[] encryptedData, RijndaelManaged rijndaelManaged)
        {
            return rijndaelManaged.CreateDecryptor()
                .TransformFinalBlock(encryptedData, 0, encryptedData.Length);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
