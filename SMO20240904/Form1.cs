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
using System.Runtime.InteropServices;
using SuperWkspManagerLib;
using SuperLayoutLib;
using AxSuperLayoutLib;
using AxSuperWkspManagerLib;
using System.IO;

namespace SMO20240904
{
    public partial class Form1 : Form
    {
        public static string selectedDSName = "";
        public static string newDstName = "";
        string selectedDSTName = "";

        string BeOverlayName = "";
        string OverlayRegionName = "";
        string CityName = "";
        string ModeType = "";

        bool GeoTracking = false;
        bool blink = false;
        bool measurelineTool = false;
        bool measurepolygonTool = false;
        bool addGeoevent = false;
        bool moveGeoEvent = false;
        bool addGeo = true;
        bool is_buffer = false;
        bool Overlay = false;

        public static int newDstTypeIndex = -1;
        private int queryLayerIndex = 0;
        int CurrentPoint = 0;

        seDatasetType selectedDSTType;
        ArrayList geoList = new ArrayList();
        soGeoLine objGeoLine = null;
        soGeoRegion objGeoRegion = null;
        soGeoLine objNewLine = null;
        soPoints objTrackPoints = null;

        //bool GeoBlink = true;
        //bool QueryByMap = true;
        //bool spatialQuery = false;
        //int OverlayAction = 0;

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
            if (SuperMap1.Layers.Count > 0)
            {
                for (int i = 1; i <= SuperMap1.Layers.Count; i++)
                {
                    if (SuperMap1.Layers[i].Dataset.Name == selectedDSTName)
                    {
                        SuperMap1.Layers.RemoveAt(i);
                        SuperMap1.Refresh();
                        break;
                    }
                }
            }
            bool bResult = SuperWorkspace1.Datasources[selectedDSName].DeleteDataset(selectedDSTName);
            if (bResult)
            {
                SuperWkspManager1.Refresh();
                statusLabel.Text = selectedDSName + "success";
            }
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
            // 检查是否处于对象跟踪模式
            if (GeoTracking)
            {
                // 获取选中的几何对象
                soSelection mySel = SuperMap1.selection;
                soRecordset myRec = mySel.ToRecordset(false);
                if (myRec != null && myRec.RecordCount > 0)
                {
                    myRec.MoveFirst();
                    soGeometry selectedGeometry = myRec.GetGeometry();
                    if (selectedGeometry != null)
                    {
                        // 根据几何类型进行处理
                        if (selectedGeometry.Type == seGeometryType.scgLine || selectedGeometry.Type == seGeometryType.scgRegion)
                        {
                            // 调用跟踪方法
                            TrackGeometry(selectedGeometry);
                        }
                        else
                        {
                            MessageBox.Show("选中的对象不是线或面类型，无法进行跟踪。");
                        }
                    }
                    else
                    {
                        MessageBox.Show("无法获取选中的几何对象。");
                    }
                }
                else
                {
                    MessageBox.Show("未选中任何对象。");
                }
                // 重置状态
                GeoTracking = false;
                SuperMap1.selection.RemoveAll();
                SuperMap1.Action = seAction.scaPan; // 重置为平移操作或其他默认操作
            }
            else
            {
                // 原有的处理逻辑
                soSelection mySel = SuperMap1.selection;
                soRecordset myRec = mySel.ToRecordset(false);

                // 主要用于防误触
                is_buffer = true;
                if (is_buffer & mySel.Count != 0)
                {
                    menuBufferAnalyse.Enabled = true;
                }
                else
                {
                    menuBufferAnalyse.Enabled = false;
                }

                SuperGridView1.Connect(myRec);
                SuperGridView1.Update();
            }
        }

        private void TrackGeometry(soGeometry objGeo)
        {
            double dLength = 0;

            if (objGeo.Type == seGeometryType.scgLine)
            {
                objGeoLine = (soGeoLine)objGeo;
            }
            else if (objGeo.Type == seGeometryType.scgRegion)
            {
                objGeoRegion = (soGeoRegion)objGeo;
                objGeoLine = objGeoRegion.ConvertToLine();
            }
            else
            {
                MessageBox.Show("无法处理的几何类型。");
                return;
            }
            if (objGeoLine != null)
            {
                dLength = objGeoLine.Length;
                objNewLine = objGeoLine.ResampleEquidistantly(dLength / 60);

                if (objNewLine != null)
                {
                    objTrackPoints = objNewLine.GetPartAt(1);
                    CurrentPoint = 1;
                    timer1.Interval = 500;
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("重采样失败，无法生成新线对象。");
                }
            }
            else
            {
                MessageBox.Show("无法获取线对象进行跟踪。");
            }
        }

        private void SuperGridView1_ItemSelected(object sender, AxSuperGridViewLib._DSuperGridViewEvents_ItemSelectedEvent e)
        {
            SuperMap1.selection.RemoveAll();
            SuperMap1.selection.Add(e.nObjID);
            soRecordset curRec = SuperMap1.selection.ToRecordset(true);
            SuperMap1.EnsureVisibleRecordset(curRec, 2);
            SuperMap1.Refresh();
        }

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
                //soDatasetVector dstv = (soDatasetVector)selectedLayer.Dataset;
                soDatasetVector dstv = (soDatasetVector)SuperMap1.Layers[cboLayersInMap.SelectedIndex + 1].Dataset;

                soRecordset resResult = dstv.Query(txtSQLFilter.Text, true);
                SuperGridView1.Connect(resResult);
                SuperGridView1.Update();

                //SuperMap1.selection.FromRecordset(resResult);

                // 模拟闪烁效果
                geoList.Clear();

                // 获取全部记录对应的几何对象
                resResult.MoveFirst();
                soGeometry geo1 = resResult.GetGeometry();
                if (geo1 != null)
                {
                    geoList.Add(geo1);
                }
                else
                {

                }
                while (resResult.MoveNext())
                {
                    soGeometry geo = resResult.GetGeometry();
                    if (geo != null)
                    {
                        geoList.Add(geo);
                    }
                    else
                    {

                    }
                }

                blink = true;
                timer1.Start();
                //SuperMap1.Refresh();
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

        private void menuAddGeoevent_Click(object sender, EventArgs e)
        {
            addGeoevent = true;
            SuperMap1.Action = seAction.scaTrackPoint;
        }

        private void SuperMap1_Tracked(object sender, EventArgs e)
        {
            if (addGeoevent)
            {
                // 获取当前跟踪的几何对象
                soGeometry curGeometry = SuperMap1.TrackedGeometry;
                if (curGeometry == null)
                {
                    MessageBox.Show("无法获取跟踪的几何对象。");
                    return;
                }
                // 克隆几何对象
                soGeometry clonedGeometry = curGeometry.Clone();
                // 初始化样式
                soStyle objStyle = new soStyle();
                objStyle.PenColor = (uint)ColorTranslator.ToOle(Color.AliceBlue);
                objStyle.SymbolSize = 500;
                objStyle.SymbolStyle = 1;
                // 获取跟踪图层
                soTrackingLayer objTracklayer = SuperMap1.TrackingLayer;
                if (objTracklayer == null)
                {
                    MessageBox.Show("无法获取跟踪图层。");
                    return;
                }
                // 添加事件到跟踪图层
                objTracklayer.AddEvent(clonedGeometry, objStyle, "Point1");
                objTracklayer.Refresh();
            }

            else if (GeoTracking == true)
            {
                double dLength = 0;
                soGeometry objGeo = SuperMap1.TrackedGeometry;
                if (objGeo.Type == seGeometryType.scgLine)
                {
                    objGeoLine = (soGeoLine)objGeo;
                }
                else if (objGeo.Type == seGeometryType.scgRegion)
                {
                    objGeoRegion = (soGeoRegion)objGeo;
                    objGeoLine = objGeoRegion.ConvertToLine();
                }
                dLength = objGeoLine.Length;
                objNewLine = objGeoLine.ResampleEquidistantly(dLength / 60);
                if (objNewLine != null)
                {
                    objTrackPoints = objNewLine.GetPartAt(1);
                    CurrentPoint = 1;
                    timer1.Interval = 500;
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("线对象为空，重采样失败", "error");
                    return;
                }
            }
        }

        private void menuMoveGeoevent_Click(object sender, EventArgs e)
        {
            moveGeoEvent = true;
            addGeoevent = false;
            SuperMap1.Action = seAction.scaNull;
            timer1.Interval = 300;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (moveGeoEvent)
            {
                soGeoEvent objGeoEvent = SuperMap1.TrackingLayer.get_Event("Point1");
                objGeoEvent.Move(500, 500);
                SuperMap1.TrackingLayer.RefreshEx();
            }
            else if (blink)
            {
                if (addGeo)
                {
                    soTrackingLayer objTracklayer = SuperMap1.TrackingLayer;

                    for (int i = 0; i < geoList.Count; i++)
                    {
                        soStyle objStyle = new soStyle();
                        objStyle.PenColor = (uint)ColorTranslator.ToOle(Color.Red);
                        objStyle.SymbolStyle = 1;
                        objStyle.SymbolSize = 500;
                        objTracklayer.AddEvent((soGeometry)geoList[i], objStyle, "");
                    }
                    objTracklayer.Refresh();
                    addGeo = false;
                }
                else
                {
                    SuperMap1.TrackingLayer.ClearEvents();
                    SuperMap1.TrackingLayer.Refresh();
                    addGeo = true;
                }
            }
            else if (GeoTracking == true)
            {
                if (objTrackPoints != null)
                {
                    if (objTrackPoints.Count > CurrentPoint)
                    {
                        soGeoPoint NewPoint = new soGeoPoint();
                        soStyle TempLine = new soStyle();
                        soStyle PointStyle = new soStyle();

                        PointStyle.PenColor = (uint)ColorTranslator.ToOle(Color.Blue);
                        PointStyle.SymbolSize = 50;
                        PointStyle.SymbolStyle = 14;
                        NewPoint.x = objTrackPoints[CurrentPoint].x;
                        NewPoint.y = objTrackPoints[CurrentPoint].y;

                        SuperMap1.TrackingLayer.ClearEvents();
                        TempLine.PenColor = (uint)ColorTranslator.ToOle(Color.Yellow);
                        SuperMap1.TrackingLayer.AddEvent((soGeometry)objGeoLine, TempLine, "");

                        SuperMap1.TrackingLayer.AddEvent((soGeometry)NewPoint, PointStyle, "");
                        SuperMap1.TrackingLayer.Refresh();
                        CurrentPoint++;

                        //marshal.ReleaseComObject(NewPoint);
                        NewPoint = null;
                        //marshal.ReleaseComObject(PointStyle);
                        PointStyle = null;
                    }
                    else
                    {
                        SuperMap1.TrackingLayer.ClearEvents();
                        SuperMap1.TrackingLayer.Refresh();
                        timer1.Stop();
                    }
                }
            }
        }

        private void menuTrackByPolyLine_Click(object sender, EventArgs e)
        {
            SuperMap1.TrackingLayer.ClearEvents();
            SuperMap1.TrackingLayer.Refresh();
            GeoTracking = true;
            SuperMap1.Action = seAction.scaTrackPolyline;
        }

        private void menuTrackByPolygon_Click(object sender, EventArgs e)
        {
            SuperMap1.TrackingLayer.ClearEvents();
            SuperMap1.TrackingLayer.Refresh();
            GeoTracking = true;
            SuperMap1.Action = seAction.scaTrackPolygon;
        }

        private void menuTrackBySelectGeo_Click(object sender, EventArgs e)
        {
            GeoTracking = true;
            //GeoBlink = false;
            //QueryByMap = false;
            SuperMap1.TrackingLayer.ClearEvents();
            SuperMap1.TrackingLayer.Refresh();
            SuperMap1.Action = seAction.scaSelect;
        }

        public void menuSLineTrack_Click(object sender, EventArgs e)
        {
            // 获取图层名称列表
            List<string> layerNames = new List<string>();
            int layersCount = SuperMap1.Layers.Count;
            for (int i = 1; i <= layersCount; i++)
            {
                string layerName = SuperMap1.Layers[i].Name;
                layerNames.Add(layerName);
            }

            // 创建并显示 FormChooseTrack 窗体，传递图层列表和图层对象
            FormChooseTrack form = new FormChooseTrack(layerNames, SuperMap1.Layers);
            form.TrackChosen += Form_TrackChosen; // 订阅事件
            form.Show(); // 如果希望以模态方式显示，则使用 ShowDialog()
        }

        public void Form_TrackChosen(object sender, TrackEventArgs e)
        {
            // 获取选中的起点和终点的坐标
            double startX = e.StartX;
            double startY = e.StartY;
            double endX = e.EndX;
            double endY = e.EndY;

            // 根据起点和终点生成线对象
            soGeoLine line = new soGeoLine();
            soPoints points = new soPoints();
            points.Add(new soPoint { x = startX, y = startY });
            points.Add(new soPoint { x = endX, y = endY });
            line.AddPart(points); // 使用 AddPart 方法

            // 将线对象添加到跟踪图层并设置样式
            soStyle lineStyle = new soStyle();
            lineStyle.PenColor = (uint)ColorTranslator.ToOle(Color.Yellow); // 设置线的颜色为黄色
            SuperMap1.TrackingLayer.AddEvent((soGeometry)line, lineStyle, "TrackLine");
            SuperMap1.TrackingLayer.Refresh();

            // 分段线对象
            double dLength = line.Length;
            soGeoLine resampledLine = line.ResampleEquidistantly(dLength / 300);

            if (resampledLine != null)
            {
                soPoints trackPoints = resampledLine.GetPartAt(1);
                int currentPoint = 1;

                // 设置定时器以实现点缓慢移动
                Timer timer = new Timer();
                timer.Interval = 100; // 设置移动间隔时间
                timer.Tick += (s, args) =>
                {
                    if (trackPoints != null && trackPoints.Count > currentPoint)
                    {
                        soGeoPoint newPoint = new soGeoPoint();
                        soStyle pointStyle = new soStyle();

                        pointStyle.PenColor = (uint)ColorTranslator.ToOle(Color.Red);
                        pointStyle.SymbolSize = 50;
                        pointStyle.SymbolStyle = 14;
                        newPoint.x = trackPoints[currentPoint].x;
                        newPoint.y = trackPoints[currentPoint].y;

                        SuperMap1.TrackingLayer.ClearEvents();
                        SuperMap1.TrackingLayer.AddEvent((soGeometry)line, lineStyle, "TrackLine");
                        SuperMap1.TrackingLayer.AddEvent((soGeometry)newPoint, pointStyle, "MovingPoint");
                        SuperMap1.TrackingLayer.Refresh();
                        currentPoint++;
                    }
                    else
                    {
                        timer.Stop();
                        SuperMap1.TrackingLayer.ClearEvents();
                        SuperMap1.TrackingLayer.Refresh();
                    }
                };
                timer.Start();
            }
            else
            {
                MessageBox.Show("重采样失败，无法生成新线对象。");
            }
        }

        // 基础的缓冲区实验生成，优化封装之后
        private void menuBufferAnalyse_Click(object sender, EventArgs e)
        {
            //FormBufferAnalyse formbuffer = new FormBufferAnalyse();
            //formbuffer.Show();

            soStyle objBufferStyle = CreateBufferStyle();
            soTrackingLayer objTrackingLayer = SuperMap1.TrackingLayer;
            soSelection objSelect = SuperMap1.selection;
            soRecordset objSelectRd = objSelect.ToRecordset(true);

            //MessageBox.Show("选中要素数量: " + objSelect.Count);
            if (objSelectRd == null)
            {
                MessageBox.Show("选中要素记录集为空！");
                return;
            }

            //MessageBox.Show("选中要素记录集数量: " + objSelectRd.RecordCount);

            objSelectRd.MoveFirst();
            objTrackingLayer.ClearEvents();

            ProcessSelectedGeometries(objSelectRd, objTrackingLayer, objBufferStyle);

            objTrackingLayer.Refresh();
            ReleaseComObjects(objSelectRd, objSelect, objTrackingLayer);
        }

        // 创建缓冲区样式
        private soStyle CreateBufferStyle()
        {
            soStyle objBufferStyle = new soStyleClass();
            objBufferStyle.BrushStyle = 2;
            objBufferStyle.BrushBackTransparent = true;
            objBufferStyle.PenColor = (uint)ColorTranslator.ToOle(Color.Green);
            objBufferStyle.PenWidth = 20;
            objBufferStyle.BrushColor = (uint)ColorTranslator.ToOle(Color.DarkGreen);
            return objBufferStyle;
        }

        // 处理选中的几何对象
        private void ProcessSelectedGeometries(soRecordset objSelectRd, soTrackingLayer objTrackingLayer, soStyle objBufferStyle)
        {
            for (int _ = 1; _ <= objSelectRd.RecordCount; _++)
            {
                soGeometry objSelectGeo = objSelectRd.GetGeometry();
                soGeoRegion objBufferRegion = CreateBufferRegion(objSelectGeo);

                if (objBufferRegion != null)
                {
                    objTrackingLayer.AddEvent((soGeometry)objBufferRegion, objBufferStyle, "");
                    Marshal.ReleaseComObject(objBufferRegion);
                    objBufferRegion = null;
                }

                Marshal.FinalReleaseComObject(objSelectGeo);
                objSelectGeo = null;
                objSelectRd.MoveNext();
            }
        }

        // 创建缓冲区几何对象
        private soGeoRegion CreateBufferRegion(soGeometry objSelectGeo)
        {
            soGeoRegion objBufferRegion = null;

            if (objSelectGeo.Type == seGeometryType.scgPoint)
            {
                soGeoPoint objGeoPoint = (soGeoPoint)objSelectGeo;
                objBufferRegion = objGeoPoint.Buffer(500, 50);
                Marshal.ReleaseComObject(objGeoPoint);
            }
            else if (objSelectGeo.Type == seGeometryType.scgLine)
            {
                soGeoLine objGeoLine = (soGeoLine)objSelectGeo;
                objBufferRegion = objGeoLine.SpatialOperator.Buffer2(500, 1000, 50);
                Marshal.ReleaseComObject(objGeoLine);
            }
            else if (objSelectGeo.Type == seGeometryType.scgRegion)
            {
                soGeoRegion objGeoRegion = (soGeoRegion)objSelectGeo;
                objBufferRegion = objGeoRegion.Buffer(500, 50);
                Marshal.ReleaseComObject(objGeoRegion);
            }

            return objBufferRegion;
        }

        // 释放 COM 对象
        private void ReleaseComObjects(params object[] comObjects)
        {
            foreach (var obj in comObjects)
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                }
            }
        }

        private void menuOverlayAnalyse_Click(object sender, EventArgs e)
        {
            // 获取图层名称列表
            List<string> layerNames = new List<string>();
            int layersCount = SuperMap1.Layers.Count;
            for (int i = 1; i <= layersCount; i++)
            {
                string layerName = SuperMap1.Layers[i].Name;
                layerNames.Add(layerName);
            }

            // 创建并显示 FormOverlayAnalyse 窗体，传递图层列表和图层对象
            FormOverlayAnalyse FormOverlayAnalyse = new FormOverlayAnalyse(layerNames, SuperMap1.Layers);
            FormOverlayAnalyse.OverlayAnalyse += Form_OverlayAnalyse; // 订阅事件
            FormOverlayAnalyse.Show();
        }

        private void Form_OverlayAnalyse(object sender, OverlayEventArgs e)
        {
            BeOverlayName = e.BeOverlayName;
            OverlayRegionName = e.OverlayRegionName;
            CityName = e.CityName;
            ModeType = e.ModeType;
            //MessageBox.Show("1:OverlayRegionName " + OverlayRegionName + " 2:BeOverlayName " + BeOverlayName + " 3:CityName " + CityName, "提示");

            Overlay = true;
            PerformOverlayAnalysis();
        }

        private void PerformOverlayAnalysis()
        {
            // 获取叠加区域的几何对象
            soLayer overlayRegionLayer = SuperMap1.Layers[OverlayRegionName];
            if (overlayRegionLayer == null)
            {
                MessageBox.Show("未找到叠加区域图层: " + OverlayRegionName, "错误提示");
                return;
            }

            soDatasetVector overlayRegionDataset = (soDatasetVector)overlayRegionLayer.Dataset;
            soRecordset overlayRegionRecordset = overlayRegionDataset.Query("Name = '" + CityName + "'", true);
            if (overlayRegionRecordset == null || overlayRegionRecordset.IsEOF())
            {
                MessageBox.Show("未找到名称为 '" + CityName + "' 的记录", "错误提示");
                return;
            }

            overlayRegionRecordset.MoveFirst();
            soGeometry gobjGeoRegion = overlayRegionRecordset.GetGeometry();
            if (gobjGeoRegion == null || gobjGeoRegion.Type != seGeometryType.scgRegion)
            {
                MessageBox.Show("几何对象为空或类型不正确", "错误提示");
                return;
            }
            // 获取被处理的图层
            soLayer beOverlayLayer = SuperMap1.Layers[BeOverlayName];
            if (beOverlayLayer == null)
            {
                MessageBox.Show("未找到被处理的图层: " + BeOverlayName, "错误提示");
                return;
            }

            // 获取被叠加分析的数据集
            soDataset objDt = beOverlayLayer.Dataset;
            if (objDt == null)
            {
                MessageBox.Show("未找到被处理的图层的数据集: " + BeOverlayName, "错误提示");
                return;
            }

            // 在数据源中创建数据集 objNewDt 用来保存叠加分析后的结果
            soDataSource dataSource = this.SuperWorkspace1.Datasources[1];
            if (dataSource == null)
            {
                MessageBox.Show("未找到数据源", "错误提示");
                return;
            }

            string newDatasetName = "OverlayResult";
            int _ = 1;
            while (dataSource.Datasets[newDatasetName] != null)
            {
                newDatasetName = "OverlayResult" + _;
                //MessageBox.Show("OverlayResult" + _, "提示");
                _++;
            }
            soDataset objNewDt = dataSource.CreateDataset(newDatasetName, objDt.Type, seDatasetOption.scoDefault);
            if (objNewDt == null)
            {
                MessageBox.Show("存放结果数据集创建失败", "提示");
                return;
            }

            soDatasetVector objDtv = (soDatasetVector)objDt; // 获取被叠加分析的矢量数据集
            soDatasetVector objNewDtv = (soDatasetVector)objNewDt; // 将数据集 objNewDt 强制类型转换为矢量数据集类型

            // 新建叠加分析对象
            soOverlayAnalyst objOverlayAnalyst = new soOverlayAnalyst();
            bool bAnalyst = false;
            switch (ModeType)
            {
                case "cut":
                    // 利用 gobjGeoRegion 去裁剪 objDtv，结果保存在 objNewDtv 中
                    bAnalyst = objOverlayAnalyst.Clip(objDtv, (soGeoRegion)gobjGeoRegion, objNewDtv);
                    break;
                case "delete":
                    // 利用 gobjGeoRegion 去擦除 objDtv，结果保存在 objNewDtv 中
                    bAnalyst = objOverlayAnalyst.Erase(objDtv, (soGeoRegion)gobjGeoRegion, objNewDtv);
                    break;
            }
            if (bAnalyst)
            {
                // 叠加分析成功则刷新工作空间管理器
                SuperWkspManager1.Refresh();

                // 将新创建的数据集添加到 SuperMap1 的图层中
                bool bAddToHead = true;

                SuperMap1.Layers.AddDataset(objNewDt, bAddToHead);
                SuperMap1.Refresh();
                SuperWkspManager1.Refresh();
            }
            else
            {
                // 叠加分析失败则提示信息
                MessageBox.Show("叠加分析失败", "提示");
                //return;
            }
            // 释放 COM 对象所占用的资源
            Marshal.ReleaseComObject(objNewDtv);
            objNewDtv = null;
            Marshal.ReleaseComObject(objNewDt);
            objNewDt = null;
            Marshal.ReleaseComObject(objOverlayAnalyst);
            objOverlayAnalyst = null;
            Marshal.ReleaseComObject(objDtv);
            objDtv = null;
            Marshal.ReleaseComObject(objDt);
            objDt = null;
            Marshal.ReleaseComObject(beOverlayLayer);
            beOverlayLayer = null;
            SuperMap1.Action = seAction.scaNull;
            Marshal.ReleaseComObject(gobjGeoRegion);
            gobjGeoRegion = null;
        }

        private void menuUniqueTheme_Click(object sender, EventArgs e)
        {
            soLayer objThemeLayer = SuperMap1.Layers[cboLayersInMap.Text];
            soThemeUnique objUnique = objThemeLayer.ThemeUnique;
            objUnique.Caption = "Ex Unique Theme (yhcbqc)";
            // name是温度带的最后一列的名字
            objUnique.Field = "Name";
            objUnique.MakeDefault();

            SuperMap1.Refresh();
            SuperLegend1.Refresh();
            soColors objColorTheme = new soColors();
            int themeCount = objUnique.ValueCount;
            objColorTheme.MakeRandomColorset(themeCount);
            for (int _ = 1; _ <= themeCount; _++)
            {
                objUnique.get_Style(_).BrushColor = (uint)objColorTheme[_];
            }
            SuperMap1.Refresh();
            SuperLegend1.Refresh();
        }

        private void menuLabelTheme_Click(object sender, EventArgs e)
        {
            // 获取图层
            soLayer objThemeLayer = SuperMap1.Layers[cboLayersInMap.Text];
            // 检查是否支持标签专题图
            soThemeLabel objLabel = objThemeLayer.ThemeLabel;
            // 配置标签专题图
            objLabel.Enable = true;
            objLabel.Field = "Name";  // 确保字段 "Name" 存在
            objLabel.OnTop = true;
            objLabel.VisibleScaleMax = 0.0;
            objLabel.VisibleScaleMin = 0.0;
            objLabel.AutoAvoidOverlapped = true;
            objLabel.IgnoreSmallObject = true;

            // 设置文本样式
            soTextStyle objTextStyle = new soTextStyle();
            objTextStyle.Color = (uint)ColorTranslator.ToOle(Color.Black); // 设置为黑色
            objTextStyle.FontName = "宋体"; // 字体名称
            objTextStyle.FontHeight = 100000; // 字体大小
            objTextStyle.Bold = true; // 加粗
            objTextStyle.Transparent = false; // 非透明
            objTextStyle.BgColor = (uint)ColorTranslator.ToOle(Color.White); // 设置为黑色
            objLabel.TextStyle = objTextStyle;

            // 刷新地图和图例
            SuperMap1.Refresh();
            SuperLegend1.Refresh();

            // 检查标签是否成功创建
            if (objLabel.Valid)
            {
                MessageBox.Show("标签专题图已成功创建！");
            }
            else
            {
                MessageBox.Show("标签专题图创建失败，请检查配置。");
            }
        }

        private void menuOutputBMP_Click(object sender, EventArgs e)
        {
            // 打开文件资源管理器选择输出位置和文件名
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "BMP 文件|*.bmp";
            saveFileDialog.Title = "选择输出文件的位置";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                int dpi = 345; // 输出 DPI 设置为 345
                bool showProgress = true; // 显示进程条

                // 获取整个地图的范围
                soRect mapBounds = SuperMap1.ViewBounds;

                // 调用 OutputMapToBMP 方法输出 BMP 文件
                bool result = SuperMap1.OutputMapToBMP(filePath, mapBounds, dpi, showProgress);

                if (result)
                {
                    MessageBox.Show("文件导出成功！", "提示");
                }
                else
                {
                    MessageBox.Show("文件导出失败，请检查配置。", "错误");
                }
            }
        }

        private void menuOutputFile_Click(object sender, EventArgs e)
        {
            // 打开文件资源管理器选择输出位置和文件名
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "BMP 文件|*.bmp|JPG 文件|*.jpg|GIF 文件|*.gif|WMF 文件|*.wmf|EMF 文件|*.emf|TIFF 文件|*.tiff|PNG 文件|*.png";
            saveFileDialog.Title = "选择输出文件的位置";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                seFileType fileType;

                // 根据文件扩展名设置文件类型
                switch (Path.GetExtension(filePath).ToLower())
                {
                    case ".bmp":
                        fileType = seFileType.scfBMP;
                        break;
                    case ".jpg":
                        fileType = seFileType.scfJPG;
                        break;
                    case ".gif":
                        fileType = seFileType.scfGIF;
                        break;
                    case ".wmf":
                        fileType = seFileType.scfWMF;
                        break;
                    case ".emf":
                        fileType = seFileType.scfEMF;
                        break;
                    case ".png":
                        fileType = seFileType.scfPNG;
                        break;
                    default:
                        MessageBox.Show("不支持的文件格式", "错误");
                        return;
                }

                // 调用 OutputMapToFile 方法输出文件
                bool result = SuperMap1.OutputMapToFile(filePath, fileType, 100, true);

                if (result)
                {
                    MessageBox.Show("文件导出成功！", "提示");
                }
                else
                {
                    MessageBox.Show("文件导出失败，请检查配置。", "错误");
                }
            }
        }

        private void menuSaveLayout_Click(object sender, EventArgs e)
        {
            bool bSaved = this.SuperLayout1.SaveLayout();
            if (bSaved)
            {
                MessageBox.Show("保存布局成功", "提示");
                return;
            }
            else
            {
                MessageBox.Show("保存布局失败", "提示");
                return;
            }
        }

        private void menuSaveLayoutAs_Click(object sender, EventArgs e)
        {
            frmSaveLayoutAs frmSaveLayoutAs = new frmSaveLayoutAs(this);
            frmSaveLayoutAs.ShowDialog();
        }

        public AxSuperLayout SuperLayoutControl
        {
            get { return this.SuperLayout1; }
        }

        public AxSuperWkspManager SuperWkspManagerControl
        {
            get { return this.SuperWkspManager1; }
        }

        private void SuperLayout1_SelectionChanged(object sender, EventArgs e)
        {
            soLytSelection objLytSelect = SuperLayout1.Selection;
            if(true)
            {}
        }

        private void menuDeleteLayout_Click(object sender, EventArgs e)
        {
            FormDeleteLayout frmDeleteLayout = new FormDeleteLayout(this);
            frmDeleteLayout.ShowDialog();
        }

        private void menuSetFlyPath_Click(object sender, EventArgs e)
        {
            Form3DPath frmPath = new Form3DPath(this);
            frmPath.Show();
        }
    }
}

