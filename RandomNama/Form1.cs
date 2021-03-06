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
        string connectString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DW_TITO_OLTP3;";
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
            sqlQuery = "select * from customer where substring(`Customer_ID`,1,2) = 'C" + hurufawal+"' ";
            sqlCommand = new MySqlCommand(sqlQuery,sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNama);

            int urutan;
            urutan = dtNama.Rows.Count + 1;
            //MessageBox.Show(urutan.ToString());

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


            //random no telp
            int index4 = rand.Next(100000000, 999999999);
            int index5 = rand.Next(1, 9);

            string nohp = "08" + index5.ToString() + index4.ToString();
            labelphone.Text = nohp;

            
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            sqlQuery = "insert into customer values ('"+labelCustID.Text+"','"+labelNama.Text+"','"+labelAdress.Text+"','"+labelphone.Text+"')";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data berhasil masuk!");
        }

        private void buttonLoop_Click(object sender, EventArgs e)
        {
            

            for(int i = 0; i <= Convert.ToInt32(textBoxUlangBrp.Text); i++)
            {
                Random.PerformClick();
                buttonInsert.PerformClick();
            }
        }
    }
}
