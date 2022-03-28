using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RandomNama
{
    public partial class RandomNama : Form
    {
       

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DW_TITO_OLTP1;";
        string sqlQuery;

        string[] NamaDepan = { "Yohan", "Cliffton", "Billy","Agustian", "Anthony", "Soenarto", "Jono", "Kasino", "Briaan", "Laura","Edbert", "Chyntia", "Fujian", "Ria", "Agus", "Bambang" };
        string[] LastName = { "Ana", "Keke", "Wijaya", "Bingtoyo", "Lukas", "Tahir", "Jonathan", "Salim", "Christian", "Liadi", "Johito", "Gracia", "Akmal", "Inez", "Nicholas", "Olivia" };

        string[] Address = { "Surabaya", "Gresik", "Kediri", "Jember", "Banyuwangi", "Babatan", "Kaliwates", "Dolly", "Sukoharjo", "Sukomanuggal", "Sukabumi", "Dlanggu", "Sleman", "Jogja", "Lamongan", "Bali", "Kalikuro","BSD", "Bintaro", "Tangerang", "Gencong", "Tretes", "Pacet", "Trawas", "Malang", "Batu", "Lawang", "Situbondo", "Puger", "Pati", "Kudus", "Singosari", "Gununganyar", "Blitar"};

        public RandomNama()
        {
            InitializeComponent();
        }

        private void Random_Click(object sender, EventArgs e)
        {
            var rand = new Random();

            int index = rand.Next(NamaDepan.Length);
            

            int index2 = rand.Next(LastName.Length);
            labelNama.Text = (NamaDepan[index] + " " + LastName[index2]);


            DataTable dtNama = new DataTable();

            string hurufawal;
            hurufawal = labelNama.Text.Substring(0,1);

            labelCustID.Text = hurufawal;

            int index3 = rand.Next(Address.Length);
            labelAdress.Text = Address[index3];

        }
    }
}
