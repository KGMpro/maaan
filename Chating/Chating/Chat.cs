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

namespace Chating
{
    public partial class Chat : Form
    {
        string serv = "server=localhost;user=root;password=;database=BD_Chat;SslMode=none";
        private BindingSource bindingSource = new BindingSource();

        public Chat()
        {
            InitializeComponent();
            listBox1.Items.Add("гдмшвагмдшвагм");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=BD_Chat;SslMode=none");
            connection.Open();
            MySqlCommand myCommand = new MySqlCommand(String.Format("INSERT INTO Chatlog (`login`, `time`, `text`) VALUES ('" + LoginLabel.Text + "', '" + label1.Text + "', '" + textBox1.Text + "')"), connection);
            myCommand.ExecuteNonQuery();
            connection.Close();

            textBox1.ResetText();

            MySqlConnection Conn = new MySqlConnection(serv);
            Conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "SELECT `login`, `text`, `time` FROM `Chatlog`";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            bindingSource.DataSource = dataset.Tables[0];
            dataGridView1.DataSource = bindingSource;
            Conn.Close();
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            string s = DateTime.Now.ToString("yyyy-MM-dd-hh-mm");
            label1.Text = s;
            LoginLabel.Text = DataBank.ConnectedUser;

            MySqlConnection Conn = new MySqlConnection(serv);
            Conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "SELECT `login`, `text`, `time` FROM `Chatlog`";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            bindingSource.DataSource = dataset.Tables[0];
            dataGridView1.DataSource = bindingSource;
            //dataGridView1.Columns[0].HeaderText = "ID Клиента";
            //dataGridView1.Columns[1].HeaderText = "ФИО";
            //dataGridView1.Columns[2].HeaderText = "Адрес";
            //dataGridView1.Columns[3].HeaderText = "Телефон";
            Conn.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBoxlistBox1.Items.Add("гдмшвагмдшвагм");
        }
    }
}
