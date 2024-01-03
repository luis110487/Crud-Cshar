using CRUD_Sol.Logic;
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
        int nStatusSave = 0;
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


        private void ClearText() 
        {
            txtArticles.Clear();
            txtBrand.Clear();
            txtExtent.Clear();
            txtCategory.Clear();
         }


        private void StatusButtonsProcess(bool lStatus)
        {
            btnCancel.Visible= lStatus;
            btnSave.Visible= lStatus;
            btbExtent.Visible = lStatus;
            btnCategory.Visible = lStatus;  

            btnSearch.Enabled= lStatus;
            txtSearch.Enabled= lStatus;
            dtv_List.Enabled= lStatus;
        }

        private void ButtonsMain(bool lStatus) 
        {
            btnNew.Enabled= lStatus;
            btnUpdate.Enabled= lStatus;
            btnReport.Enabled = lStatus;
            btnDelete.Enabled= lStatus;
            btnClose.Enabled= lStatus;
        }


        private void Format_ar()
        {
            dtv_List.Columns[0].Width = 90;
            dtv_List.Columns[0].HeaderText = "CODE_AR";
            dtv_List.Columns[1].Width = 220;
            dtv_List.Columns[1].HeaderText = "ARTICLE";
            dtv_List.Columns[2].Width = 120;
            dtv_List.Columns[2].HeaderText = "BRAND";
            dtv_List.Columns[3].Width = 100;
            dtv_List.Columns[3].HeaderText = "EXTENT";
            dtv_List.Columns[4].Width = 150;
            dtv_List.Columns[4].HeaderText = "CATEGORY";
            dtv_List.Columns[5].Visible=false;
            dtv_List.Columns[6].Visible=false;



        }
        private void listArticles(string cText)
        {
           L_Articles Data= new L_Articles();
            dtv_List.DataSource = Data.ListArticles(cText);
            this.Format_ar();
        }

        #endregion

        private void btnNew_Click(object sender, EventArgs e)
        {
            nStatusSave = 1;// new Register
            this.State_text(true);
            this.ClearText();
            this.StatusButtonsProcess(true);
            this.ButtonsMain(false);
            txtArticles.Focus();
             
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.State_text(false);
            this.ClearText();
            this.StatusButtonsProcess(false);
            this.ButtonsMain(true);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            nStatusSave = 2; // Update Register
        }

        private void Articles_Load(object sender, EventArgs e)
        {
            this.listArticles("%");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
