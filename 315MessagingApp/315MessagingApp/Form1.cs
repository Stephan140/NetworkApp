using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _315MessagingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dgvMessages.Visible = false;
        }

        private void dgvContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            NewContactForm newForm = new NewContactForm();
            newForm.ShowDialog();
        }

        private void btnNewGroup_Click(object sender, EventArgs e)
        {
            NewGroupForm newForm = new NewGroupForm();
            newForm.ShowDialog();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }
    }
}
