using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotizProgramm
{
    public partial class Form1 : Form
    {
        DataTable table;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Titel", typeof(String));
            table.Columns.Add("Nachricht", typeof(String));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Nachricht"].Visible = false;
            dataGridView1.Columns["Titel"].Width = 240;
        }

        private void bttn_neu_Click(object sender, EventArgs e)
        {
            tbMessage.Clear();
            tbTitle.Clear();
        }

        private void bttn_save_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == "" || tbMessage.Text == "")
            {

            }
            else
            {
                table.Rows.Add(tbTitle.Text, tbMessage.Text);

                tbMessage.Clear();
                tbTitle.Clear();
            }
        }

        private void bttn_open_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                tbTitle.Text = table.Rows[index].ItemArray[0].ToString();
                tbMessage.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void bttn_delete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
    }
}
