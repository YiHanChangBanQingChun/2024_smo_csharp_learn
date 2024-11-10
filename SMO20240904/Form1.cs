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
using System.Collections;

namespace SMO20240904
{
    public partial class Form1 : Form
    {
        public static string selectedDSName = "";
        public static string newDstName = "";
        public static int newDstTypeIndex = -1;
        string selectedDSTName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitSMOControls();
        }

        private void InitSMOControls()
        {
            SuperWkspManager1.Connect(SuperWorkspace1.CtlHandle);
            SuperMap1.Connect(SuperWorkspace1.CtlHandle);
            SuperLegend1.Connect(SuperMap1.CtlHandle);
        }

        private void openWKSFileMenu_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "SMW文件|*.smw";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                bool openResult = SuperWorkspace1.Open(openFileDialog1.FileName);
                if (openResult)
                {
                    statusLabel.Text = "工作空间打开成功！";
                    SuperWkspManager1.Refresh();
                }
                else
                {
                    statusLabel.Text = "工作空间打开失败！";
                }
            }
        }

        private void SuperWkspManager1_LDbClick(object sender, AxSuperWkspManagerLib._DSuperWkspManagerEvents_LDbClickEvent e)
        {
            switch (e.nFlag)
            {
                case SuperMapLib.seSelectedItemFlag.scsMap:
                    string mapName = e.strSelected;
                    if (SuperMap1.OpenMap(mapName))
                    {
                        SuperMap1.Refresh();
                        SuperLegend1.Refresh();
                        int layersCount = SuperMap1.Layers.Count;
                        cboLayersInMap.BeginUpdate();
                        for (int i = 1; i <= layersCount; i++)
                        {
                            string layerName = SuperMap1.Layers[i].Name;
                            cboLayersInMap.Items.Add(layerName);
                        }
                        cboLayersInMap.EndUpdate();
                        //soDatasetVector dstv = (soDatasetVector)SuperMap1.Layers[4].Dataset;
                        //soStrings qfields = new soStrings();
                        //qfields.Add("Name");
                        //soRecordset rec_names = dstv.Query("", false, qfields, "");
                        //int cou = rec_names.RecordCount;
                        //cboDistricts.BeginUpdate();
                        //rec_names.MoveFirst();
                        //cboDistricts.Items.Add(rec_names.GetFieldValue(1).ToString());
                        //for (int j = 2; j <= rec_names.RecordCount; j++)
                        //{
                            //rec_names.MoveFirst();
                            //cboDistricts.Items.Add
                        //}
                    }
                    else
                    {
                        statusLabel.Text = "打开地图失败！";
                    }
                    break;
                case seSelectedItemFlag.scsDataset:
                    bool bAddToHead = true;
                    SuperMap1.Layers.AddDataset(SuperWorkspace1.Datasources[e.strParent].Datasets[e.strSelected], bAddToHead);
                    SuperMap1.Refresh();
                    SuperLegend1.Refresh();
                    break;

                //case seSelectedItemFlag.scsDatasource:
                //    SuperWorkspace1
                default:
                    break;

            }
        }

        private void btnZoomin_Click(object sender, EventArgs e)
        {
            SuperMap1.Action = SuperMapLib.seAction.scaZoomIn;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            SuperMap1.Action = SuperMapLib.seAction.scaZoomOut;
        }

        private void btnPan_Click(object sender, EventArgs e)
        {
            SuperMap1.Action = SuperMapLib.seAction.scaPan;
        }

        private void btnViewEntire_Click(object sender, EventArgs e)
        {
            SuperMap1.ViewEntire();
        }

        private void SuperLegend1_Modified(object sender, EventArgs e)
        {
            SuperMap1.Refresh();
        }

        private void menuCreateSQLDS_Click(object sender, EventArgs e)
        {
            //(1)显示新建SQL数据源的参数设置窗体
            string strDatasourceName = "";
            string strPassword = "";
            string strAlias = "";
            soDataSource newDS = null;
            //调用创建数据源窗体
            FormSQLDS sqlForm = new FormSQLDS();
            sqlForm.btnOpenDS.Enabled = false;
            DialogResult dr = sqlForm.ShowDialog();
            //(2)调用CreateDatasource()方法，创建数据源保存在SQL Server数据库中
            if (dr == DialogResult.OK)
            {
                //设置SQL数据源参数
                strDatasourceName = "Provider = SQLOLEDB;Driver = SQL Server;SERVER = " + sqlForm.txtServer.Text + ";Database = " + sqlForm.txtDatabase.Text;
                //获取访问存放数据源的SQL数据库服务器的账户与密码
                strPassword = "UID =" + sqlForm.txtUser.Text + ";PWD = " + sqlForm.txtPassword.Text + "";
                strAlias = sqlForm.txtDSName.Text;
                //创建数据源
                newDS = SuperWorkspace1.CreateDataSource(strDatasourceName, strAlias, seEngineType.sceSQLPlus, false, false, false, strPassword);
                if (newDS != null)//新建数据源成功则在状态栏进行提示
                {
                    statusLabel.Text = strAlias + "数据源创建成功";
                    SuperWkspManager1.Refresh();//刷新工作空间管理器
                }
                else
                { //数据源创建失败则在状态栏进行提示
                    statusLabel.Text = strAlias + "数据源创建失败";
                }
            }
        }

        private void menuOpenSQLDS_Click(object sender, EventArgs e)
        {
            //(1)显示打开SQL数据源的参数设置窗体
            string strDatasourceName = "";
            string strPassword = "";
            string strAlias = "";
            soDataSource openedDS = null;
            FormSQLDS sqlForm = new FormSQLDS();
            sqlForm.btnSaveDS.Enabled = false;
            DialogResult dr = sqlForm.ShowDialog();
            //(2)调用OpenDatasourceEx()方法，访问保存在SQL Server数据库中的数据源
            if (dr == DialogResult.OK)
            {
                //设置SQL数据源参数
                strDatasourceName = "Provider = SQLOLEDB;Driver = SQL Server;SERVER = " + sqlForm.txtServer.Text + ";Database = " + sqlForm.txtDatabase.Text;
                //获取访问存放数据源的SQL数据库服务器的账户与密码
                strPassword = "UID =" + sqlForm.txtUser.Text + ";PWD = " + sqlForm.txtPassword.Text + "";
                strAlias = sqlForm.txtDSName.Text;
                //打开数据源对象
                openedDS = SuperWorkspace1.OpenDataSourceEx(strDatasourceName, strAlias, seEngineType.sceSQLPlus, false, false, false, false, strPassword);
                if (openedDS != null)//打开数据源成功则在状态栏进行提示
                {
                    statusLabel.Text = strAlias + "数据源打开成功";
                    SuperWkspManager1.Refresh();//刷新工作空间管理器
                }
                else
                { //数据源打开失败则在状态栏进行提示
                    statusLabel.Text = strAlias + "数据源打开失败";
                }
            }
        }

        private void menuCreateDst_Click(object sender, EventArgs e)
        {
            //string dstName = "point";
            //soDataset newdst = SuperWorkspace1.Datasources[1].CreateDataset(dstName, seDatasetType.scdPoint, seDatasetOption.scoDefault);
            string dstName = "geoLine";
            soDataset newdst = SuperWorkspace1.Datasources[1].CreateDataset(dstName, seDatasetType.scdLine, seDatasetOption.scoDefault);
            if (newdst != null)
            {
                SuperWkspManager1.Refresh();
            }
        }

        private void menuDeleteDst_Click(object sender, EventArgs e)
        {
            if(SuperMap1.Layers.Count>0)
            {
                for (int i = 1; i<=SuperMap1.Layers.Count;i++)
                {
                    if(SuperMap1.Layers[i].Dataset.Name == selectedDSTName)
                    {
                        SuperMap1.Layers.RemoveAt(i);
                        SuperMap1.Refresh();
                        break;
                    }
                }
            }
            bool bResult = SuperWorkspace1.Datasources[selectedDSName].DeleteDataset(selectedDSTName);
            if(bResult)
            {
                SuperWkspManager1.Refresh();
                statusLabel.Text=selectedDSName+"success";
            }
        }

        private void SuperWorkspace1_Enter(object sender, EventArgs e)
        {

        }

        private void SuperWkspManager1_LClick(object sender, AxSuperWkspManagerLib._DSuperWkspManagerEvents_LClickEvent e)
        {
            switch (e.nFlag)
            {
                case seSelectedItemFlag.scsDataset:
                    selectedDSTName = e.strSelected;
                    selectedDSName = e.strParent;
                    menuDataset.Enabled = true;

                    // 获取所选数据集的类型
                    var selectedDataset = SuperWorkspace1.Datasources[selectedDSName].Datasets[selectedDSTName];
                    selectedDSTType = selectedDataset.Type; // 假设 Type 属性返回 seDatasetType 类型
                    break;

                case seSelectedItemFlag.scsDatasource: // 添加对数据源选择的处理
                    selectedDSName = e.strSelected;
                    break;
                default:
                    break;
            }
        }

        private void menuPasteDst_Click(object sender, EventArgs e)
        {
            if (SuperMap1.Layers.Count > 0)
            {
                for (int i = 1; i <= SuperMap1.Layers.Count; i++)
                {
                    if (SuperMap1.Layers[i].Dataset.Name == selectedDSTName)
                    {
                        // 获取原始数据集
                        var originalDataset = SuperMap1.Layers[i].Dataset;

                        // 生成新的数据集名称
                        string newDatasetName = selectedDSTName + "_copy";

                        // 复制数据集
                        var copyResult = SuperWorkspace1.Datasources[selectedDSName].CopyDataset(originalDataset, newDatasetName);

                        if (copyResult != null)
                        {
                            // 刷新地图和工作区
                            SuperMap1.Refresh();
                            SuperWkspManager1.Refresh();
                            statusLabel.Text = newDatasetName + " copied successfully";
                        }
                        else
                        {
                            statusLabel.Text = "Failed to copy " + selectedDSTName;
                        }
                        break;
                    }
                }
            }
        }

        private void menuOpenSQLWKS_Click(object sender, EventArgs e)
        {
            string strWorkspaceName = "";
            string strPassword = "";
            FormSQLWKS sqlForm = new FormSQLWKS();
            sqlForm.btnSaveWks.Enabled = false;
            DialogResult dr = sqlForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                strWorkspaceName = "Provider = SQLOLEDB;Driver = SQL Server;SERVER = " + sqlForm.txtServer.Text + ";Database = " + sqlForm.txtDatabase.Text + ";Caption = " + sqlForm.txtWksName.Text + ";";
                strPassword = "UID =" + sqlForm.txtUser.Text + ";PWD = " + sqlForm.txtPassword.Text;
                bool result = SuperWorkspace1.Open(strWorkspaceName, strPassword);
                if (result)
                {
                    SuperWkspManager1.Refresh();
                    statusLabel.Text = strWorkspaceName + "open success";
                }
                else
                {
                    statusLabel.Text = strWorkspaceName + "open false";
                }
            }
        }

        private void btnQueryByMap_Click(object sender, EventArgs e)
        {
            SuperMap1.Action = seAction.scaCircleSelect;
            // SuperMap1.Action = seAction.scaSelectEx;
        }

        private void SuperMap1_GeometrySelected(object sender, AxSuperMapLib._DSuperMapEvents_GeometrySelectedEvent e)
        {
            // MessageBox.Show("You have selected the geometry object!");
            soSelection mySel = SuperMap1.selection;
            soRecordset myRec = mySel.ToRecordset(false);
            SuperGridView1.Connect(myRec);
            SuperGridView1.Update();
        }

        private void SuperGridView1_ItemSelected(object sender, AxSuperGridViewLib._DSuperGridViewEvents_ItemSelectedEvent e)
        {
            SuperMap1.selection.RemoveAll();
            SuperMap1.selection.Add(e.nObjID);
            soRecordset curRec = SuperMap1.selection.ToRecordset(true);
            SuperMap1.EnsureVisibleRecordset(curRec, 2);
            SuperMap1.Refresh();
        }

        ArrayList geoList = new ArrayList();
        bool blink = false;

        private void btnSQLQuery_Click(object sender, EventArgs e)
        {
            // 获取用户选择的图层
            soLayer selectedLayer = GetSelectedLayer();

            // 检查是否选择了图层
            if (selectedLayer == null)
            {
                MessageBox.Show("请选择一个图层进行查询", "错误提示");
                return;
            }

            try
            {
                // 仅在选择的图层中进行搜索
                soDatasetVector dstv = (soDatasetVector)selectedLayer.Dataset;
                soRecordset resResult = dstv.Query(txtSQLFilter.Text, true);
                SuperGridView1.Connect(resResult);
                SuperGridView1.Update();

                //SuperMap1.selection.FromRecordset(resResult);

                resResult.MoveFirst();
                soGeometry geo1 = resResult.GetGeometry();
                geoList.Add(geo1);
                while (resResult.MoveNext())
                {
                    soGeometry geo = resResult.GetGeometry();
                    geoList.Add(geo);
                }

                blink = true;
                timer1.Start();
                soTrackingLayer objTracklayer = SuperMap1.TrackingLayer;

                for (int i = 0; i < geoList.Count; i++)
                {
                    soStyle objStyle = new soStyle();
                    objStyle.PenColor = (uint)ColorTranslator.ToOle(Color.Red);
                    objStyle.SymbolStyle = 1;
                    objStyle.SymbolSize = 100;
                    objTracklayer.AddEvent((soGeometry)geoList[i], objStyle, "");
                }
                objTracklayer.Refresh();
                SuperMap1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询过程中发生错误: " + ex.Message, "错误提示");
            }
        }



        // 获取用户选择的图层
        private soLayer GetSelectedLayer()
        {
            if (cboLayersInMap.SelectedItem != null)
            {
                string selectedLayerName = cboLayersInMap.SelectedItem.ToString();
                return SuperMap1.Layers[selectedLayerName];
            }
            return null;
        }

        private void btnQueryByDistrcit_Click(object sender, EventArgs e)
        {
            try
            {
                // 检查 SuperMap1 是否包含图层
                if (SuperMap1.Layers != null && SuperMap1.Layers.Count > 0)
                {
                    // 获取用户选择的图层
                    soLayer selectedLayer = GetSelectedLayer();
                    if (selectedLayer == null)
                    {
                        MessageBox.Show("请选择一个图层进行查询", "错误提示");
                        return;
                    }

                    // 存储 SQL 查询结果的 smid
                    List<int> sqlQuerySmids = new List<int>();

                    // 检查是否输入了 SQL 过滤条件
                    if (!string.IsNullOrEmpty(txtSQLFilter.Text))
                    {
                        // 进行 SQL 查询
                        soDatasetVector dstv = (soDatasetVector)selectedLayer.Dataset;
                        soRecordset resResult = dstv.Query(txtSQLFilter.Text, false);

                        if (resResult != null && !resResult.IsEOF())
                        {
                            int smid = (int)resResult.GetFieldValue("smid");
                            resResult.MoveFirst();
                            while (!resResult.IsEOF())
                            {
                                sqlQuerySmids.Add((int)resResult.GetFieldValue("smid"));
                                resResult.MoveNext();
                            }
                            // MessageBox.Show("SQL 查询结果的 smid: " + string.Join(", ", sqlQuerySmids), "调试信息");
                        }
                        else
                        {
                            MessageBox.Show("SQL 查询结果为空", "错误提示");
                            return;
                        }
                    }

                    // 获取 District_R@shanghai 图层
                    soLayer dis_lyr = SuperMap1.Layers["District_R@shanghai"];
                    if (dis_lyr == null)
                    {
                        MessageBox.Show("未找到 'District_R@shanghai' 图层", "错误提示");
                        return;
                    }

                    soDatasetVector dstvDistrict = (soDatasetVector)dis_lyr.Dataset;
                    if (dstvDistrict == null)
                    {
                        MessageBox.Show("'District_R@shanghai' 图层的数据集为空", "错误提示");
                        return;
                    }

                    // 查询用户输入的城市名称
                    soRecordset rec = dstvDistrict.Query("Name = '" + txtCityChoose.Text + "'", true);

                    if (rec != null && !rec.IsEOF())
                    {
                        rec.MoveFirst();
                        soGeometry searchGeo = rec.GetGeometry();
                        if (searchGeo == null)
                        {
                            MessageBox.Show("几何对象为空", "错误提示");
                            return;
                        }

                        soDatasetVector dstv2 = (soDatasetVector)selectedLayer.Dataset;
                        if (dstv2 != null)
                        {
                            // queryex可以传入最后一个参数，这个参数是用来过滤条件！所以可以实现完成第三题的任务
                            soRecordset result = dstv2.QueryEx((soGeometry)searchGeo, seSpatialQueryMode.scsContaining, "");

                            if (result != null && result.RecordCount > 0)
                            {
                                // 显示 result 中的所有 smid
                                List<int> resultSmids = new List<int>();
                                result.MoveFirst();
                                while (!result.IsEOF())
                                {
                                    int smid = (int)result.GetFieldValue("smid");
                                    resultSmids.Add(smid);
                                    result.MoveNext();
                                }
                                // MessageBox.Show("空间查询结果的 smid: " + string.Join(", ", resultSmids), "调试信息");

                                // 如果有 SQL 过滤条件，则进行交集筛选
                                if (sqlQuerySmids.Count > 0)
                                {
                                    List<int> intersectedSmids = new List<int>();
                                    result.MoveFirst();
                                    while (!result.IsEOF())
                                    {
                                        int smid = (int)result.GetFieldValue("smid");
                                        if (sqlQuerySmids.Contains(smid))
                                        {
                                            intersectedSmids.Add(smid);
                                        }
                                        result.MoveNext();
                                    }

                                    // MessageBox.Show("交集查询结果的 smid: " + string.Join(", ", intersectedSmids), "调试信息");

                                    if (intersectedSmids.Count > 0)
                                    {
                                        // 构建 SQL 'IN' 条件
                                        string smidCondition = "smid IN (" + string.Join(",", intersectedSmids) + ")";

                                        // 进行查询以获取过滤后的记录集
                                        soRecordset filteredResult = dstv2.Query(smidCondition, false);

                                        if (filteredResult != null && !filteredResult.IsEOF())
                                        {
                                            // MessageBox.Show("最终交集结果的 smid: " + string.Join(", ", intersectedSmids), "调试信息");

                                            // 连接并更新 SuperGridView
                                            SuperGridView1.Connect(filteredResult);
                                            SuperGridView1.Update();

                                            // 从过滤后的记录集中进行选择
                                            SuperMap1.selection.FromRecordset(filteredResult);
                                            SuperMap1.Refresh();
                                        }
                                        else
                                        {
                                            MessageBox.Show("交集查询结果为空", "提示");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("交集查询结果为空", "提示");
                                    }
                                }
                                else
                                {
                                    // 如果没有 SQL 过滤条件，直接显示空间查询结果
                                    SuperGridView1.Connect(result);
                                    SuperGridView1.Update();
                                    SuperMap1.selection.FromRecordset(result);
                                    SuperMap1.Refresh();
                                }
                            }
                            else
                            {
                                MessageBox.Show("空间查询失败，结果为空", "错误提示");
                            }
                        }
                        else
                        {
                            MessageBox.Show("选择的图层的数据集为空", "错误提示");
                        }
                    }
                    else
                    {
                        MessageBox.Show("未找到名称为'" + txtCityChoose.Text + "'的记录", "错误提示");
                    }
                }
                else
                {
                    MessageBox.Show("SuperMap1 不包含任何图层", "错误提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生异常: " + ex.Message, "错误提示");
            }
        }

        private void menuSaveWKSFile_Click(object sender, EventArgs e)
        {
            bool bSave = SuperWorkspace1.Save();
            if (bSave)
            {
                SuperWkspManager1.Refresh();
            }
            else
            {
                MessageBox.Show("保存失败");
            }
        }

        private void menuopenFileDS_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "sdb文件|*.sdb|所有文件类型|*.*";
            DialogResult dr = openFileDialog1.ShowDialog();
            string strdsName = openFileDialog1.FileName;
            string dsAlias = "test";
            soDataSource newDS = SuperWorkspace1.OpenDataSource(strdsName, dsAlias, seEngineType.sceSDBPlus, false);
            if (newDS != null)
            {
                SuperWkspManager1.Refresh();
            }
            else
            {
                MessageBox.Show("保存数据源失败!");
            }
        }

        private void CreatePointMenu_Click(object sender, EventArgs e)
        {
            if (selectedDSTType == seDatasetType.scdPoint)
            {
                SuperMap1.Action = seAction.scaEditCreatePoint;
            }
            else
            {
                MessageBox.Show("当前选择的类型不是点类型，无法创建点。");
            }
        }

        private void CreateLineMenu_Click(object sender, EventArgs e)
        {
            if (selectedDSTType == seDatasetType.scdLine)
            {
                SuperMap1.Action = seAction.scaEditCreatePolyline;
            }
            else
            {
                MessageBox.Show("当前选择的类型不是线类型，无法创建线。");
            }
        }

        private void CreatePolygonMenu_Click(object sender, EventArgs e)
        {
            if (selectedDSTType == seDatasetType.scdRegion)
            {
                SuperMap1.Action = seAction.scaEditCreatePolygon;
            }
            else
            {
                MessageBox.Show("当前选择的类型不是面类型，无法创建面。");
            }
        }

        private void CreateFileFSmenu_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "sdb文件|*.sdb|所有文件类型|*.*";
            DialogResult dr = saveFileDialog1.ShowDialog();
            string strdsName = saveFileDialog1.FileName;
            string dsAlias = "test";
            // 调用接口，新建数据源
            soDataSource newDS = SuperWorkspace1.CreateDataSource(strdsName, dsAlias, seEngineType.sceSDBPlus, false, false, false, "");
            if (newDS != null)
            {
                SuperWkspManager1.Refresh();
            }
            else
            {
                MessageBox.Show("新建数据源失败!");
            }
        }

        private void menuopenFileDS1_Click(object sender, EventArgs e)
        {

        }

        private void menuopenFileDS_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "sdb文件|*.sdb|所有文件类型|*.*";
            DialogResult dr = openFileDialog1.ShowDialog();
            string strdsName = openFileDialog1.FileName;
            string dsAlias = "test";
            // 调用接口，新建数据源
            soDataSource newDS = SuperWorkspace1.OpenDataSource(strdsName, dsAlias, seEngineType.sceSDBPlus, false);
            if (newDS != null)
            {
                SuperWkspManager1.Refresh();
            }
            else
            {
                MessageBox.Show("保存数据源失败!");
            }
        }

        private int queryLayerIndex = 0;
        private seDatasetType selectedDSTType;

        private void cboLayersInMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            queryLayerIndex = cboLayersInMap.SelectedIndex + 1;
        }

        // 已经弃用
        private void menuCreateGeometry_Click(object sender, EventArgs e)
        {
            string dstName = "point";
            soDataset newdst = SuperWorkspace1.Datasources[1].CreateDataset(dstName, seDatasetType.scdPoint, seDatasetOption.scoDefault);
            if (newdst != null)
            {
                SuperWkspManager1.Refresh();
            }
        }

        private void btnCreatePointDataset_Click(object sender, EventArgs e)
        {
            CreateDataset(seDatasetType.scdPoint, "PointDataset");
        }

        private void btnCreateLineDataset_Click(object sender, EventArgs e)
        {
            CreateDataset(seDatasetType.scdLine, "LineDataset");
        }

        private void btnCreatePolygonDataset_Click(object sender, EventArgs e)
        {
            CreateDataset(seDatasetType.scdRegion, "PolygonDataset");
        }

        private void CreateDataset(seDatasetType datasetType, string baseName)
        {
            // 检查是否选择了数据源
            if (string.IsNullOrEmpty(selectedDSName))
            {
                MessageBox.Show("请选择一个数据源。");
                return;
            }

            // 获取当前数据源
            var datasource = SuperWorkspace1.Datasources[selectedDSName];
            if (datasource == null)
            {
                MessageBox.Show("无法获取所选数据源。");
                return;
            }

            // 自动生成数据集名称
            int index = 1;
            string datasetName;
            while (true)
            {
                datasetName = string.Format("{0}{1}", baseName, index);
                if (datasource.Datasets[datasetName] == null)
                {
                    break;
                }
                index++;
            }

            // 创建数据集
            soDataset newDataset = datasource.CreateDataset(datasetName, datasetType, seDatasetOption.scoDefault);
            if (newDataset != null)
            {
                SuperWkspManager1.Refresh();
                MessageBox.Show(string.Format("{0} 数据集创建成功。", datasetName));
            }
            else
            {
                MessageBox.Show("数据集创建失败。");
            }
        }

        bool measurelineTool = false;
        bool measurepolygonTool = false;

        private void measureLengthMenu_Click(object sender, EventArgs e)
        {
            measurelineTool = true;
            SuperMap1.Action = seAction.scaTrackPolyline;
        }

        private void SuperMap1_Tracking(object sender, AxSuperMapLib._DSuperMapEvents_TrackingEvent e)
        {
            if (measurelineTool == true)
            {
                statusLabel.Text = "当前长度为：" + e.dCurrentLength + "总长度为：" + e.dTotalLength + "角度为：" + e.dCurrentAngle;
            }
            if (measurepolygonTool == true)
            {
                statusLabel.Text = "当前面积为：" + e.dTotalArea;
            }
        }

        private void measureAreaMenu_Click(object sender, EventArgs e)
        {
            measurepolygonTool = true;
            SuperMap1.Action = seAction.scaTrackPolygon;
        }

        bool addGeoevent = false;

        private void menuAddGeoevent_Click(object sender, EventArgs e)
        {
            addGeoevent = true;
            SuperMap1.Action = seAction.scaTrackPoint;
        }

        private void SuperMap1_Tracked(object sender, EventArgs e)
        {
            if (addGeoevent)
            {
                soGeoPoint objGeoPoint = null;
                soGeometry curGeometry;
                soStyle objStyle = new soStyle();
                soTrackingLayer objTracklayer = SuperMap1.TrackingLayer;
                curGeometry = SuperMap1.TrackingGeometry;
                objGeoPoint = (soGeoPoint)curGeometry;
                objStyle.PenColor = (uint)ColorTranslator.ToOle(Color.AliceBlue);
                objStyle.SymbolSize = 100;
                objStyle.SymbolStyle = 1;
                objTracklayer.AddEvent(curGeometry, objStyle, "Point1");
                objTracklayer.Refresh();
            }
        }

        bool moveGeoEvent = false;

        private void menuMoveGeoevent_Click(object sender, EventArgs e)
        {
            moveGeoEvent = true;
            addGeoevent = false;
            SuperMap1.Action = seAction.scaNull;
            timer1.Interval = 300;
            timer1.Start();
        }

        bool addGeo = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (moveGeoEvent)
            {
                soGeoEvent objGeoEvent = SuperMap1.TrackingLayer.get_Event("Point1");
                objGeoEvent.Move(50, 50);
                SuperMap1.TrackingLayer.RefreshEx();
            }
            if (blink)
            {
                if (addGeo)
                {
                    soTrackingLayer objTracklayer = SuperMap1.TrackingLayer;

                    for (int i = 0; i <= geoList.Count; i++)
                    {
                        soStyle objStyle = new soStyle();
                        objStyle.PenColor = (uint)ColorTranslator.ToOle(Color.Red);
                        objStyle.SymbolStyle = 1;
                        objStyle.SymbolSize = 100;
                        objTracklayer.AddEvent((soGeometry)geoList[i], objStyle, "");
                    }
                    objTracklayer.Refresh();
                    addGeo = false;
                }
                else
                {
                    SuperMap1.TrackingLayer.ClearEvents();
                    SuperMap1.TrackingLayer.Refresh();
                }
            }
        }
    }
}

