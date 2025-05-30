using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class Form2 : Form
    {
        public List<Client> clients = new List<Client>();
        public Form2()
        {
            InitializeComponent();
            var lines = Read.ReadFromFile("ClientData.txt");
            clients = lines.Select(x => Read.ParseClient(x)).Where(x => x != null).ToList();
        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Visitor visitor = new Visitor(textBox1.Text, textBox2.Text);
            EligibleToLoan eligibleToLoan = new EligibleToLoan();
            bool eligible = eligibleToLoan.IsEligibleToLoan(visitor, clients);
            if (eligible)
            {
                checkBoxNeeligibil.Checked = false;
                checkBoxEligibil.Checked = true;
            }
            else
            {
                checkBoxEligibil.Checked = false;
                checkBoxNeeligibil.Checked = true;
            }
        }
    }
}
