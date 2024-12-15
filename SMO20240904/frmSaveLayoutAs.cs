using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperLayoutLib;
using AxSuperLayoutLib;
using SuperMapLib;
using SuperWkspManagerLib;
using AxSuperMapLib;
using AxSuperWkspManagerLib;

namespace SMO20240904
{
    public partial class frmSaveLayoutAs : Form
    {
        Form1 mainfrm;

        public frmSaveLayoutAs(Form1 frm)
        {
            InitializeComponent();
            mainfrm = frm;
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            if (this.txtSaveLayoutName.Text == "")
            {
                MessageBox.Show("请输入要保存的布局名称", "提示");
                return;
            }
            string strLayoutName = txtSaveLayoutName.Text;
            AxSuperLayout superLayout = mainfrm.SuperLayoutControl;
            AxSuperWkspManager superWksManager = mainfrm.SuperWkspManagerControl;

            // 继续处理保存布局的逻辑
            bool result = superLayout.SaveLayoutAs(strLayoutName, true);
            if (result)
            {
                MessageBox.Show("布局保存成功", "提示");
                superWksManager.Refresh();
            }
            else
            {
                MessageBox.Show("布局保存失败", "提示");
                return;
            }
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
