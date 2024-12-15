using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperMapLib;

namespace SMO20240904
{
    public partial class Form3DPath : Form
    {
        private Form1 form1;
        AxSuperMapLib.AxSuperWorkspace SuperWorkspace = null;
        soPoint3Ds objFlyPts = null;
        soGeoLine objFlyPath = null;

        public Form3DPath(SMO20240904.Form1 frm)
        {
            InitializeComponent();
            mainfrm = frm;
        }

        public Form3DPath(Form1 form1) 
        {
            // TODO: Complete member initialization
            this.form1 = form1;
        }
    }
}
