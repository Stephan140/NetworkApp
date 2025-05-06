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
    public partial class NewGroupForm : Form
    {
        public NewGroupForm()
        {
            InitializeComponent();
        }

        private void lsbGroupPreview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelNewGroup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
