using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet ds;
        SqlDataAdapter da;
        SqlConnection con = new SqlConnection();

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this.dataSet1.Contact);
            // TODO: This line of code loads data into the 'dataSet1.CampaignType' table. You can move, or remove it, as needed.
            this.campaignTypeTableAdapter.Fill(this.dataSet1.CampaignType);
            gcKhachHang.DataSource = getDataSet("SELECT * FROM Contact").Tables["Contact"];
        }

        void Connection()
        {
            string chuoiketnoi = "Data Source = 13.212.88.90; Initial Catalog = akabiz_contact; User ID = cuong; Password = 123456aA@";
            con.ConnectionString = chuoiketnoi;
            con.Open();
        }

        DataSet getDataSet(string query)
        {
            Connection();
            da = new SqlDataAdapter(query,con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds,"Contact");
            return ds;
        }

        private void gcKhachHang_Click(object sender, EventArgs e)
        {
            txt_ID.Text = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "Id").ToString();
            txt_Name.Text = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "Name").ToString();
            txt_Uid.Text = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "Uid").ToString();
            txt_Phone.Text = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "Phone").ToString();
            txt_Email.Text = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "Email").ToString();
            txt_AccountId.Text = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "AccountId").ToString();
            txt_PipelineId.Text = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "PipelineId").ToString();
        }

        private void gvKhachHang_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (ds.HasChanges())
            {
                da.Update(ds.Tables["Contact"]);
                ds.AcceptChanges();
            }
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            gvKhachHang.AddNewRow();
            gvKhachHang.OptionsNavigation.AutoFocusNewRow = true;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            gvKhachHang.DeleteSelectedRows();
            da.Update(ds.Tables["Contact"]);
            ds.AcceptChanges();
        }

    }
}
