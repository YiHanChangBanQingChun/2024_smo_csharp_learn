using SuperMapLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMO20240904
{
    public partial class FormCreateDst : Form
    {
        public FormCreateDst()
        {
            InitializeComponent();
        }
        soTreeView myDsTree;//定义变量用来保存Form1窗体中工作空间管理器的数据源树对象引用
        public FormCreateDst(soTreeView mainDsTree)
        {
            InitializeComponent();
            myDsTree = mainDsTree;//获取Form1窗体中工作空间管理器的数据源树对象引用   
        }

        private void FormCreateDst_Load(object sender, EventArgs e)
        {
            //读取数据源树对象中的所有数据源名称，并添加到组合复选框中以供选择
            for (int i = 1; i <= myDsTree.Nodes.Count; i++)
            {
                cboDatasource.Items.Add(myDsTree.Nodes.Item[i].Text);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //将本窗体中所设置的数据集名称、目标数据源和数据集类型索引等参数保存在Form1类的静态变量中
            Form1.selectedDSName = cboDatasource.SelectedItem.ToString();
            Form1.newDstName = txtDstName.Text;
            Form1.newDstTypeIndex = cboDstType.SelectedIndex;
            this.DialogResult = DialogResult.OK;//设置窗体返回值
        }
    }
}
