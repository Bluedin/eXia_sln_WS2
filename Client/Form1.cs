using Middleware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public DataSet dataSet;
        public CLprocessus Processus;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_load(object sender, EventArgs e)
        {
            this.dataSet = new DataSet();
            this.Processus = new CLprocessus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataSet = this.Processus.afficher("");
            this.dataGridView1.DataSource = this.dataSet;
            this.dataGridView1.DataMember = "rows";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Processus.DeleteByID(Int32.Parse(textBox4.Text));
            this.dataSet = this.Processus.afficher("");
            this.dataGridView1.DataSource = this.dataSet;
            this.dataGridView1.DataMember = "rows";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataSet = this.Processus.rechercherNom("rows", textBox4.Text);
            this.dataGridView1.DataSource = this.dataSet;
            this.dataGridView1.DataMember = "rows";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable customerTable = this.dataSet.Tables["Rows"];
            string nom = this.dataSet.Tables[0].TableName;
            DataRow[] row = customerTable.Select("id = '" + Int32.Parse(textBox1.Text) + "'");
            int test = row.Length;
            if (test != 0)
            {
                Processus.insert_update(Int32.Parse(textBox1), textBox2.Text, textBox3.Text, 'u');
            }
            else
            {
                Processus.insert_update(Int32.Parse(textBox1), textBox2.Text, textBox3.Text, 'i');
            }
            this.dataSet = this.Processus.afficher("");
            this.dataGridView1.DataSource = this.dataSet;
            this.dataGridView1.DataMember = "rows";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
