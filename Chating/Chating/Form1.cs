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
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=BD_Chat;SslMode=none");

        MySqlDataAdapter adapter;

        DataTable table = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("SELECT `login`, `password` FROM `Users` WHERE `login` = '" + LoginTBox.Text + "' AND `password` = '" + PasswordTBox.Text + "'", connection);
            adapter.Fill(table);

            if (table.Rows.Count <= 0)
     
            {
                adapter = new MySqlDataAdapter("SELECT `login`, `password` FROM `Users` WHERE `login` = '" + LoginTBox.Text + "' AND `password` = '" + PasswordTBox.Text + "'", connection);
                adapter.Fill(table);

            }
            else
            {
                DataBank.ConnectedUser = LoginTBox.Text;
                Chat f2 = new Chat();
                f2.FormClosing += (o, args) => Application.Exit();
                f2.Show();
                Hide();
            }
            table.Clear();
        }
    }
}
