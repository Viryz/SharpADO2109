using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO2109
{
    public partial class Form1 : Form
    {
        DB db = new DB();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("TextBox is empty");
                return;
            }
            db.InsertGroup(textBox1.Text);
            dataGridView1.DataSource = db.GetTable("Gruppa");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.GetTable("Gruppa");
        }
    }
}
