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
            
            // Random Nama
            int index2 = rand.Next(LastName.Length);
            labelNama.Text = (NamaDepan[index] + " " + LastName[index2]);

            //CustID

            string hurufawal;
            hurufawal = labelNama.Text.Substring(0, 1);

            sqlConnect = new MySqlConnection(connectString);
            DataTable dtNama = new DataTable();
            sqlQuery = "select * from customer where Customer_ID = 'C"+hurufawal+"' ";
            sqlCommand = new MySqlCommand(sqlQuery,sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNama);

            int urutan;
            urutan = dtNama.Rows.Count + 1;

            string nextstepurutan = "";

            if(urutan < 10)
            {
                nextstepurutan = "0000";
                nextstepurutan += urutan.ToString();
            }
            else if (urutan >=10 && urutan < 100)
            {
                nextstepurutan = "000";
                nextstepurutan += urutan.ToString();
            }
            else if (urutan >=100 && urutan < 1000)
            {
                nextstepurutan = "00";
                nextstepurutan += urutan.ToString();
            }
            else if (urutan >= 1000 && urutan < 10000)
            {
                nextstepurutan = "0";
                nextstepurutan += urutan.ToString();
            }
            else
            {
                nextstepurutan = "";
                nextstepurutan += urutan.ToString();
            }

            labelCustID.Text = "C" + hurufawal + nextstepurutan;

            //Alamat Random
            int index3 = rand.Next(Address.Length);
            labelAdress.Text = Address[index3];

            sqlQuery = "insert into customer values";

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            
        }
    }
}
