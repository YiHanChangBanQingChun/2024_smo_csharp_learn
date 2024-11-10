using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SMO20240904
{
  public partial class FormSQLWKS : Form
  {
    public FormSQLWKS()
    {
      InitializeComponent();
    }

    private void btnListWks_Click(object sender, EventArgs e)
    {
        SqlConnection conn = GetConnection();
        string query = "SELECT SmWorkspaceName FROM dbo.Smworkspace";
        SqlCommand command = new SqlCommand(query, conn);
        SqlDataReader dr = command.ExecuteReader();
        listbox1.Items.Clear();
        while (dr.Read())
        {
            string result = dr.GetString(0);
            listbox1.Items.Add(result);
        }
        //string connectionString = "Server="+ this.txtServer.Text +";Database=" + txtDatabase.Text + ";User Id="+ txtUser.Text +";Password=" + txtPassword.Text;
        //SqlConnection connection = new SqlConnection(connectionString);
        //connection.Open();
    }

    private SqlConnection GetConnection()
    {
        string connectionString = "Server=" + txtServer.Text + ";Database=" + txtDatabase.Text + ";User Id=" + txtUser.Text + ";Password=" + txtPassword.Text;
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        return connection;
    }

    private void btnOpenWks_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.OK;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
    }
  }
}
