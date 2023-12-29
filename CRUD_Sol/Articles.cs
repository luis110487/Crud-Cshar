using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Sol
{
    public partial class Articles : Form
    {
        public Articles()
        {
            InitializeComponent();
        }

        #region this Variables
        int nCode_ar = 0;
        int nCode_me = 0;
        int nCode_ca = 0;
        #endregion


        #region this Methods
        private void State_text(bool lState) 
        {
            txtArticles.ReadOnly= !lState;
            txtBrand.ReadOnly= !lState;
        }
        #endregion

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.State_text(true);
        }
    }
}
