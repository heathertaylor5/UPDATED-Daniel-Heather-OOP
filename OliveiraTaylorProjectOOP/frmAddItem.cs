using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OliveiraTaylorOOPFinalProject
{
    //HIDE GRPPRODUCTINFO until either radio button in checked
    public partial class frmAddItem : Form
    {
        public frmAddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            //Put the name of the students on the title
            this.Text = "Daniel & Heather";
        }

        private void btnSelectType_Click(object sender, EventArgs e)
        {

        }
    }
}
