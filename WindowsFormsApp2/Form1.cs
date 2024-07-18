using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title",typeof(string));
            table.Columns.Add("Text",typeof(string));
            dataGridView1.DataSource = table;
            dataGridView1.Columns["Text"].Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            richTextBox1.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1.Text, richTextBox1.Text);
            button1.PerformClick();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int x = dataGridView1.CurrentCell.RowIndex;
            if (x > -1)
            {
                textBox1.Text = table.Rows[x].ItemArray[0].ToString();
                richTextBox1.Text= table.Rows[x].ItemArray[1].ToString();

            }


        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int x = dataGridView1.CurrentCell.RowIndex;
            table.Rows[x].Delete();

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
