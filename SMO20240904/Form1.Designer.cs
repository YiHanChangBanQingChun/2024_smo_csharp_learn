
namespace SMO20240904
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件型工作空间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWKSFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsWKSFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveWKSFile = new System.Windows.Forms.ToolStripMenuItem();
            this.sQL工作空间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenSQLWKS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAsSQLWKS = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseWKSmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.QuitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.数据源ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQL数据源ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreateSQLDS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenSQLDS = new System.Windows.Forms.ToolStripMenuItem();
            this.文件型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateFileFSmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuopenFileDS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataset = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreateGeometry = new System.Windows.Forms.ToolStripMenuItem();
            this.CreatePointMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateLineMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CreatePolygonMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteDst = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPasteDst = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreateDst = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreatePointDataset = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateLineDataset = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreatePolygonDataset = new System.Windows.Forms.ToolStripMenuItem();
            this.跟踪图层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddGeoevent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMoveGeoevent = new System.Windows.Forms.ToolStripMenuItem();
            this.对象跟踪ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrackByPolyLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrackByPolygon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrackBySelectGeo = new System.Windows.Forms.ToolStripMenuItem();
            this.对象闪烁ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止动画ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSLineTrack = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnZoomin = new System.Windows.Forms.ToolStripButton();
            this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.btnPan = new System.Windows.Forms.ToolStripButton();
            this.btnViewEntire = new System.Windows.Forms.ToolStripButton();
            this.measureLengthMenu = new System.Windows.Forms.ToolStripButton();
            this.measureAreaMenu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnQueryByMap = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cboLayersInMap = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtSQLFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.txtCityChoose = new System.Windows.Forms.ToolStripTextBox();
            this.btnSQLQuery = new System.Windows.Forms.ToolStripButton();
            this.btnQueryByDistrcit = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SuperWkspManager1 = new AxSuperWkspManagerLib.AxSuperWkspManager();
            this.SuperLegend1 = new AxSuperLegendLib.AxSuperLegend();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.SuperWorkspace1 = new AxSuperMapLib.AxSuperWorkspace();
            this.SuperMap1 = new AxSuperMapLib.AxSuperMap();
            this.SuperGridView1 = new AxSuperGridViewLib.AxSuperGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.工具栏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBufferAnalyse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOverlayAnalyse = new System.Windows.Forms.ToolStripMenuItem();
            this.裁剪ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuperWkspManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperLegend1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuperWorkspace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperMap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.数据源ToolStripMenuItem,
            this.menuDataset,
            this.跟踪图层ToolStripMenuItem,
            this.工具栏ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1203, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件型工作空间ToolStripMenuItem,
            this.sQL工作空间ToolStripMenuItem,
            this.CloseWKSmenu,
            this.toolStripSeparator1,
            this.QuitMenu});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 文件型工作空间ToolStripMenuItem
            // 
            this.文件型工作空间ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWKSFileMenu,
            this.SaveAsWKSFileMenu,
            this.menuSaveWKSFile});
            this.文件型工作空间ToolStripMenuItem.Name = "文件型工作空间ToolStripMenuItem";
            this.文件型工作空间ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.文件型工作空间ToolStripMenuItem.Text = "文件型工作空间";
            // 
            // openWKSFileMenu
            // 
            this.openWKSFileMenu.Name = "openWKSFileMenu";
            this.openWKSFileMenu.Size = new System.Drawing.Size(100, 22);
            this.openWKSFileMenu.Text = "打开";
            this.openWKSFileMenu.Click += new System.EventHandler(this.openWKSFileMenu_Click);
            // 
            // SaveAsWKSFileMenu
            // 
            this.SaveAsWKSFileMenu.Name = "SaveAsWKSFileMenu";
            this.SaveAsWKSFileMenu.Size = new System.Drawing.Size(100, 22);
            this.SaveAsWKSFileMenu.Text = "另存";
            // 
            // menuSaveWKSFile
            // 
            this.menuSaveWKSFile.Name = "menuSaveWKSFile";
            this.menuSaveWKSFile.Size = new System.Drawing.Size(100, 22);
            this.menuSaveWKSFile.Text = "保存";
            this.menuSaveWKSFile.Click += new System.EventHandler(this.menuSaveWKSFile_Click);
            // 
            // sQL工作空间ToolStripMenuItem
            // 
            this.sQL工作空间ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenSQLWKS,
            this.menuSaveAsSQLWKS});
            this.sQL工作空间ToolStripMenuItem.Name = "sQL工作空间ToolStripMenuItem";
            this.sQL工作空间ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sQL工作空间ToolStripMenuItem.Text = "SQL工作空间";
            // 
            // menuOpenSQLWKS
            // 
            this.menuOpenSQLWKS.Name = "menuOpenSQLWKS";
            this.menuOpenSQLWKS.Size = new System.Drawing.Size(100, 22);
            this.menuOpenSQLWKS.Text = "打开";
            this.menuOpenSQLWKS.Click += new System.EventHandler(this.menuOpenSQLWKS_Click);
            // 
            // menuSaveAsSQLWKS
            // 
            this.menuSaveAsSQLWKS.Name = "menuSaveAsSQLWKS";
            this.menuSaveAsSQLWKS.Size = new System.Drawing.Size(100, 22);
            this.menuSaveAsSQLWKS.Text = "另存";
            // 
            // CloseWKSmenu
            // 
            this.CloseWKSmenu.Name = "CloseWKSmenu";
            this.CloseWKSmenu.Size = new System.Drawing.Size(160, 22);
            this.CloseWKSmenu.Text = "关闭工作空间";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // QuitMenu
            // 
            this.QuitMenu.Name = "QuitMenu";
            this.QuitMenu.Size = new System.Drawing.Size(160, 22);
            this.QuitMenu.Text = "退出";
            // 
            // 数据源ToolStripMenuItem
            // 
            this.数据源ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQL数据源ToolStripMenuItem,
            this.文件型ToolStripMenuItem});
            this.数据源ToolStripMenuItem.Name = "数据源ToolStripMenuItem";
            this.数据源ToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.数据源ToolStripMenuItem.Text = "数据源";
            // 
            // sQL数据源ToolStripMenuItem
            // 
            this.sQL数据源ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCreateSQLDS,
            this.menuOpenSQLDS});
            this.sQL数据源ToolStripMenuItem.Name = "sQL数据源ToolStripMenuItem";
            this.sQL数据源ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.sQL数据源ToolStripMenuItem.Text = "SQL数据源";
            // 
            // menuCreateSQLDS
            // 
            this.menuCreateSQLDS.Name = "menuCreateSQLDS";
            this.menuCreateSQLDS.Size = new System.Drawing.Size(100, 22);
            this.menuCreateSQLDS.Text = "新建";
            this.menuCreateSQLDS.Click += new System.EventHandler(this.menuCreateSQLDS_Click);
            // 
            // menuOpenSQLDS
            // 
            this.menuOpenSQLDS.Name = "menuOpenSQLDS";
            this.menuOpenSQLDS.Size = new System.Drawing.Size(100, 22);
            this.menuOpenSQLDS.Text = "打开";
            this.menuOpenSQLDS.Click += new System.EventHandler(this.menuOpenSQLDS_Click);
            // 
            // 文件型ToolStripMenuItem
            // 
            this.文件型ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateFileFSmenu,
            this.menuopenFileDS});
            this.文件型ToolStripMenuItem.Name = "文件型ToolStripMenuItem";
            this.文件型ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.文件型ToolStripMenuItem.Text = "文件型";
            // 
            // CreateFileFSmenu
            // 
            this.CreateFileFSmenu.Name = "CreateFileFSmenu";
            this.CreateFileFSmenu.Size = new System.Drawing.Size(100, 22);
            this.CreateFileFSmenu.Text = "新建";
            this.CreateFileFSmenu.Click += new System.EventHandler(this.CreateFileFSmenu_Click);
            // 
            // menuopenFileDS
            // 
            this.menuopenFileDS.Name = "menuopenFileDS";
            this.menuopenFileDS.Size = new System.Drawing.Size(100, 22);
            this.menuopenFileDS.Text = "打开";
            this.menuopenFileDS.Click += new System.EventHandler(this.menuopenFileDS_Click_1);
            // 
            // menuDataset
            // 
            this.menuDataset.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCreateGeometry,
            this.menuDeleteDst,
            this.menuPasteDst,
            this.menuCreateDst});
            this.menuDataset.Name = "menuDataset";
            this.menuDataset.Size = new System.Drawing.Size(56, 22);
            this.menuDataset.Text = "数据集";
            // 
            // menuCreateGeometry
            // 
            this.menuCreateGeometry.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreatePointMenu,
            this.CreateLineMenu,
            this.CreatePolygonMenu});
            this.menuCreateGeometry.Name = "menuCreateGeometry";
            this.menuCreateGeometry.Size = new System.Drawing.Size(136, 22);
            this.menuCreateGeometry.Text = "绘制...";
            this.menuCreateGeometry.Click += new System.EventHandler(this.menuCreateGeometry_Click);
            // 
            // CreatePointMenu
            // 
            this.CreatePointMenu.Name = "CreatePointMenu";
            this.CreatePointMenu.Size = new System.Drawing.Size(88, 22);
            this.CreatePointMenu.Text = "点";
            this.CreatePointMenu.Click += new System.EventHandler(this.CreatePointMenu_Click);
            // 
            // CreateLineMenu
            // 
            this.CreateLineMenu.Name = "CreateLineMenu";
            this.CreateLineMenu.Size = new System.Drawing.Size(88, 22);
            this.CreateLineMenu.Text = "线";
            this.CreateLineMenu.Click += new System.EventHandler(this.CreateLineMenu_Click);
            // 
            // CreatePolygonMenu
            // 
            this.CreatePolygonMenu.Name = "CreatePolygonMenu";
            this.CreatePolygonMenu.Size = new System.Drawing.Size(88, 22);
            this.CreatePolygonMenu.Text = "面";
            this.CreatePolygonMenu.Click += new System.EventHandler(this.CreatePolygonMenu_Click);
            // 
            // menuDeleteDst
            // 
            this.menuDeleteDst.Name = "menuDeleteDst";
            this.menuDeleteDst.Size = new System.Drawing.Size(136, 22);
            this.menuDeleteDst.Text = "删除";
            this.menuDeleteDst.Click += new System.EventHandler(this.menuDeleteDst_Click);
            // 
            // menuPasteDst
            // 
            this.menuPasteDst.Name = "menuPasteDst";
            this.menuPasteDst.Size = new System.Drawing.Size(136, 22);
            this.menuPasteDst.Text = "复制";
            this.menuPasteDst.Click += new System.EventHandler(this.menuPasteDst_Click);
            // 
            // menuCreateDst
            // 
            this.menuCreateDst.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreatePointDataset,
            this.btnCreateLineDataset,
            this.btnCreatePolygonDataset});
            this.menuCreateDst.Name = "menuCreateDst";
            this.menuCreateDst.Size = new System.Drawing.Size(136, 22);
            this.menuCreateDst.Text = "新建数据集";
            // 
            // btnCreatePointDataset
            // 
            this.btnCreatePointDataset.Name = "btnCreatePointDataset";
            this.btnCreatePointDataset.Size = new System.Drawing.Size(124, 22);
            this.btnCreatePointDataset.Text = "点数据集";
            this.btnCreatePointDataset.Click += new System.EventHandler(this.btnCreatePointDataset_Click);
            // 
            // btnCreateLineDataset
            // 
            this.btnCreateLineDataset.Name = "btnCreateLineDataset";
            this.btnCreateLineDataset.Size = new System.Drawing.Size(124, 22);
            this.btnCreateLineDataset.Text = "线数据集";
            this.btnCreateLineDataset.Click += new System.EventHandler(this.btnCreateLineDataset_Click);
            // 
            // btnCreatePolygonDataset
            // 
            this.btnCreatePolygonDataset.Name = "btnCreatePolygonDataset";
            this.btnCreatePolygonDataset.Size = new System.Drawing.Size(124, 22);
            this.btnCreatePolygonDataset.Text = "面数据集";
            this.btnCreatePolygonDataset.Click += new System.EventHandler(this.btnCreatePolygonDataset_Click);
            // 
            // 跟踪图层ToolStripMenuItem
            // 
            this.跟踪图层ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddGeoevent,
            this.menuMoveGeoevent,
            this.对象跟踪ToolStripMenuItem,
            this.对象闪烁ToolStripMenuItem,
            this.停止动画ToolStripMenuItem,
            this.menuSLineTrack});
            this.跟踪图层ToolStripMenuItem.Name = "跟踪图层ToolStripMenuItem";
            this.跟踪图层ToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.跟踪图层ToolStripMenuItem.Text = "跟踪图层";
            // 
            // menuAddGeoevent
            // 
            this.menuAddGeoevent.Name = "menuAddGeoevent";
            this.menuAddGeoevent.Size = new System.Drawing.Size(124, 22);
            this.menuAddGeoevent.Text = "添加实例";
            this.menuAddGeoevent.Click += new System.EventHandler(this.menuAddGeoevent_Click);
            // 
            // menuMoveGeoevent
            // 
            this.menuMoveGeoevent.Name = "menuMoveGeoevent";
            this.menuMoveGeoevent.Size = new System.Drawing.Size(124, 22);
            this.menuMoveGeoevent.Text = "移动实例";
            this.menuMoveGeoevent.Click += new System.EventHandler(this.menuMoveGeoevent_Click);
            // 
            // 对象跟踪ToolStripMenuItem
            // 
            this.对象跟踪ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrackByPolyLine,
            this.menuTrackByPolygon,
            this.menuTrackBySelectGeo});
            this.对象跟踪ToolStripMenuItem.Name = "对象跟踪ToolStripMenuItem";
            this.对象跟踪ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.对象跟踪ToolStripMenuItem.Text = "对象跟踪";
            // 
            // menuTrackByPolyLine
            // 
            this.menuTrackByPolyLine.Name = "menuTrackByPolyLine";
            this.menuTrackByPolyLine.Size = new System.Drawing.Size(148, 22);
            this.menuTrackByPolyLine.Text = "画线跟踪";
            this.menuTrackByPolyLine.Click += new System.EventHandler(this.menuTrackByPolyLine_Click);
            // 
            // menuTrackByPolygon
            // 
            this.menuTrackByPolygon.Name = "menuTrackByPolygon";
            this.menuTrackByPolygon.Size = new System.Drawing.Size(148, 22);
            this.menuTrackByPolygon.Text = "画面跟踪";
            this.menuTrackByPolygon.Click += new System.EventHandler(this.menuTrackByPolygon_Click);
            // 
            // menuTrackBySelectGeo
            // 
            this.menuTrackBySelectGeo.Name = "menuTrackBySelectGeo";
            this.menuTrackBySelectGeo.Size = new System.Drawing.Size(148, 22);
            this.menuTrackBySelectGeo.Text = "指定对象跟踪";
            this.menuTrackBySelectGeo.Click += new System.EventHandler(this.menuTrackBySelectGeo_Click);
            // 
            // 对象闪烁ToolStripMenuItem
            // 
            this.对象闪烁ToolStripMenuItem.Name = "对象闪烁ToolStripMenuItem";
            this.对象闪烁ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.对象闪烁ToolStripMenuItem.Text = "对象闪烁";
            // 
            // 停止动画ToolStripMenuItem
            // 
            this.停止动画ToolStripMenuItem.Name = "停止动画ToolStripMenuItem";
            this.停止动画ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.停止动画ToolStripMenuItem.Text = "停止动画";
            // 
            // menuSLineTrack
            // 
            this.menuSLineTrack.Name = "menuSLineTrack";
            this.menuSLineTrack.Size = new System.Drawing.Size(124, 22);
            this.menuSLineTrack.Text = "直线跟踪";
            this.menuSLineTrack.Click += new System.EventHandler(this.menuSLineTrack_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnZoomin,
            this.btnZoomOut,
            this.btnPan,
            this.btnViewEntire,
            this.measureLengthMenu,
            this.measureAreaMenu,
            this.toolStripSeparator2,
            this.btnQueryByMap,
            this.toolStripSeparator5,
            this.toolStripLabel2,
            this.cboLayersInMap,
            this.toolStripSeparator4,
            this.toolStripLabel1,
            this.txtSQLFilter,
            this.toolStripSeparator3,
            this.toolStripLabel3,
            this.txtCityChoose,
            this.btnSQLQuery,
            this.btnQueryByDistrcit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1203, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnZoomin
            // 
            this.btnZoomin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomin.Image = global::SMO20240904.Properties.Resources.Zoomin;
            this.btnZoomin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomin.Name = "btnZoomin";
            this.btnZoomin.Size = new System.Drawing.Size(36, 36);
            this.btnZoomin.Text = "toolStripButton1";
            this.btnZoomin.ToolTipText = "放大";
            this.btnZoomin.Click += new System.EventHandler(this.btnZoomin_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomOut.Image = global::SMO20240904.Properties.Resources.Zoomout;
            this.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(36, 36);
            this.btnZoomOut.Text = "toolStripButton2";
            this.btnZoomOut.ToolTipText = "缩小";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnPan
            // 
            this.btnPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPan.Image = global::SMO20240904.Properties.Resources.Pan;
            this.btnPan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(36, 36);
            this.btnPan.Text = "漫游";
            this.btnPan.Click += new System.EventHandler(this.btnPan_Click);
            // 
            // btnViewEntire
            // 
            this.btnViewEntire.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnViewEntire.Image = global::SMO20240904.Properties.Resources.Entire;
            this.btnViewEntire.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewEntire.Name = "btnViewEntire";
            this.btnViewEntire.Size = new System.Drawing.Size(36, 36);
            this.btnViewEntire.Text = "全幅显示";
            this.btnViewEntire.Click += new System.EventHandler(this.btnViewEntire_Click);
            // 
            // measureLengthMenu
            // 
            this.measureLengthMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.measureLengthMenu.Image = ((System.Drawing.Image)(resources.GetObject("measureLengthMenu.Image")));
            this.measureLengthMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.measureLengthMenu.Name = "measureLengthMenu";
            this.measureLengthMenu.Size = new System.Drawing.Size(34, 36);
            this.measureLengthMenu.Text = "Dist";
            this.measureLengthMenu.Click += new System.EventHandler(this.measureLengthMenu_Click);
            // 
            // measureAreaMenu
            // 
            this.measureAreaMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.measureAreaMenu.Image = ((System.Drawing.Image)(resources.GetObject("measureAreaMenu.Image")));
            this.measureAreaMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.measureAreaMenu.Name = "measureAreaMenu";
            this.measureAreaMenu.Size = new System.Drawing.Size(39, 36);
            this.measureAreaMenu.Text = "Area";
            this.measureAreaMenu.Click += new System.EventHandler(this.measureAreaMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnQueryByMap
            // 
            this.btnQueryByMap.Name = "btnQueryByMap";
            this.btnQueryByMap.Size = new System.Drawing.Size(56, 36);
            this.btnQueryByMap.Text = "图查属性";
            this.btnQueryByMap.Click += new System.EventHandler(this.btnQueryByMap_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(44, 36);
            this.toolStripLabel2.Text = "图层：";
            // 
            // cboLayersInMap
            // 
            this.cboLayersInMap.Name = "cboLayersInMap";
            this.cboLayersInMap.Size = new System.Drawing.Size(121, 39);
            this.cboLayersInMap.SelectedIndexChanged += new System.EventHandler(this.cboLayersInMap_SelectedIndexChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(95, 36);
            this.toolStripLabel1.Text = "SQL 查询条件：";
            // 
            // txtSQLFilter
            // 
            this.txtSQLFilter.Name = "txtSQLFilter";
            this.txtSQLFilter.Size = new System.Drawing.Size(150, 39);
            this.txtSQLFilter.Text = "name like \"*上海*\"";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(44, 36);
            this.toolStripLabel3.Text = "区域：";
            // 
            // txtCityChoose
            // 
            this.txtCityChoose.Name = "txtCityChoose";
            this.txtCityChoose.Size = new System.Drawing.Size(100, 39);
            // 
            // btnSQLQuery
            // 
            this.btnSQLQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSQLQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnSQLQuery.Image")));
            this.btnSQLQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSQLQuery.Name = "btnSQLQuery";
            this.btnSQLQuery.Size = new System.Drawing.Size(84, 36);
            this.btnSQLQuery.Text = "进行属性查图";
            this.btnSQLQuery.Click += new System.EventHandler(this.btnSQLQuery_Click);
            // 
            // btnQueryByDistrcit
            // 
            this.btnQueryByDistrcit.Name = "btnQueryByDistrcit";
            this.btnQueryByDistrcit.Size = new System.Drawing.Size(92, 36);
            this.btnQueryByDistrcit.Text = "查询区域的设施";
            this.btnQueryByDistrcit.Click += new System.EventHandler(this.btnQueryByDistrcit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 567);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1203, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(131, 17);
            this.statusLabel.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(951, 17);
            this.toolStripStatusLabel1.Text = "备注：（1）进行区域设施查询时，如果输入SQL查询条件也会进行参与。（2）区域设施查询默认区域为普陀区，可以自行修改。（3）属性查询只需要输入图层与SQL查询条件" +
                "！";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1203, 504);
            this.splitContainer1.SplitterDistance = 298;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.SuperWkspManager1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.SuperLegend1);
            this.splitContainer2.Size = new System.Drawing.Size(298, 504);
            this.splitContainer2.SplitterDistance = 245;
            this.splitContainer2.TabIndex = 0;
            // 
            // SuperWkspManager1
            // 
            this.SuperWkspManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuperWkspManager1.Enabled = true;
            this.SuperWkspManager1.Location = new System.Drawing.Point(0, 0);
            this.SuperWkspManager1.Name = "SuperWkspManager1";
            this.SuperWkspManager1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("SuperWkspManager1.OcxState")));
            this.SuperWkspManager1.Size = new System.Drawing.Size(298, 245);
            this.SuperWkspManager1.TabIndex = 0;
            this.SuperWkspManager1.LClick += new AxSuperWkspManagerLib._DSuperWkspManagerEvents_LClickEventHandler(this.SuperWkspManager1_LClick);
            this.SuperWkspManager1.LDbClick += new AxSuperWkspManagerLib._DSuperWkspManagerEvents_LDbClickEventHandler(this.SuperWkspManager1_LDbClick);
            // 
            // SuperLegend1
            // 
            this.SuperLegend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuperLegend1.Enabled = true;
            this.SuperLegend1.Location = new System.Drawing.Point(0, 0);
            this.SuperLegend1.Name = "SuperLegend1";
            this.SuperLegend1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("SuperLegend1.OcxState")));
            this.SuperLegend1.Size = new System.Drawing.Size(298, 255);
            this.SuperLegend1.TabIndex = 0;
            this.SuperLegend1.Modified += new System.EventHandler(this.SuperLegend1_Modified);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.SuperWorkspace1);
            this.splitContainer3.Panel1.Controls.Add(this.SuperMap1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.SuperGridView1);
            this.splitContainer3.Size = new System.Drawing.Size(901, 504);
            this.splitContainer3.SplitterDistance = 352;
            this.splitContainer3.TabIndex = 0;
            // 
            // SuperWorkspace1
            // 
            this.SuperWorkspace1.Enabled = true;
            this.SuperWorkspace1.Location = new System.Drawing.Point(330, 211);
            this.SuperWorkspace1.Name = "SuperWorkspace1";
            this.SuperWorkspace1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("SuperWorkspace1.OcxState")));
            this.SuperWorkspace1.Size = new System.Drawing.Size(32, 32);
            this.SuperWorkspace1.TabIndex = 1;
            // 
            // SuperMap1
            // 
            this.SuperMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuperMap1.Enabled = true;
            this.SuperMap1.Location = new System.Drawing.Point(0, 0);
            this.SuperMap1.Name = "SuperMap1";
            this.SuperMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("SuperMap1.OcxState")));
            this.SuperMap1.Size = new System.Drawing.Size(901, 352);
            this.SuperMap1.TabIndex = 0;
            this.SuperMap1.GeometrySelected += new AxSuperMapLib._DSuperMapEvents_GeometrySelectedEventHandler(this.SuperMap1_GeometrySelected);
            this.SuperMap1.Tracking += new AxSuperMapLib._DSuperMapEvents_TrackingEventHandler(this.SuperMap1_Tracking);
            this.SuperMap1.Tracked += new System.EventHandler(this.SuperMap1_Tracked);
            // 
            // SuperGridView1
            // 
            this.SuperGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuperGridView1.Enabled = true;
            this.SuperGridView1.Location = new System.Drawing.Point(0, 0);
            this.SuperGridView1.Name = "SuperGridView1";
            this.SuperGridView1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("SuperGridView1.OcxState")));
            this.SuperGridView1.Size = new System.Drawing.Size(901, 148);
            this.SuperGridView1.TabIndex = 0;
            this.SuperGridView1.ItemSelected += new AxSuperGridViewLib._DSuperGridViewEvents_ItemSelectedEventHandler(this.SuperGridView1_ItemSelected);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 工具栏ToolStripMenuItem
            // 
            this.工具栏ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBufferAnalyse,
            this.menuOverlayAnalyse});
            this.工具栏ToolStripMenuItem.Name = "工具栏ToolStripMenuItem";
            this.工具栏ToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.工具栏ToolStripMenuItem.Text = "工具栏";
            // 
            // menuBufferAnalyse
            // 
            this.menuBufferAnalyse.Name = "menuBufferAnalyse";
            this.menuBufferAnalyse.Size = new System.Drawing.Size(152, 22);
            this.menuBufferAnalyse.Text = "缓冲区分析";
            this.menuBufferAnalyse.Click += new System.EventHandler(this.menuBufferAnalyse_Click);
            // 
            // menuOverlayAnalyse
            // 
            this.menuOverlayAnalyse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.裁剪ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.menuOverlayAnalyse.Name = "menuOverlayAnalyse";
            this.menuOverlayAnalyse.Size = new System.Drawing.Size(152, 22);
            this.menuOverlayAnalyse.Text = "叠加分析";
            // 
            // 裁剪ToolStripMenuItem
            // 
            this.裁剪ToolStripMenuItem.Name = "裁剪ToolStripMenuItem";
            this.裁剪ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.裁剪ToolStripMenuItem.Text = "裁剪";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 589);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "超图组件式开发学习";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SuperWkspManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperLegend1)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SuperWorkspace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperMap1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件型工作空间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWKSFileMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveAsWKSFileMenu;
        private System.Windows.Forms.ToolStripMenuItem CloseWKSmenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem QuitMenu;
        private System.Windows.Forms.ToolStripButton btnZoomin;
        private System.Windows.Forms.ToolStripButton btnZoomOut;
        private System.Windows.Forms.ToolStripButton btnPan;
        private System.Windows.Forms.ToolStripButton btnViewEntire;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private AxSuperMapLib.AxSuperMap SuperMap1;
        private AxSuperGridViewLib.AxSuperGridView SuperGridView1;
        private AxSuperWkspManagerLib.AxSuperWkspManager SuperWkspManager1;
        private AxSuperLegendLib.AxSuperLegend SuperLegend1;
        private AxSuperMapLib.AxSuperWorkspace SuperWorkspace1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.ToolStripMenuItem sQL工作空间ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem menuOpenSQLWKS;
        private System.Windows.Forms.ToolStripMenuItem 数据源ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQL数据源ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCreateSQLDS;
        private System.Windows.Forms.ToolStripMenuItem menuOpenSQLDS;
        private System.Windows.Forms.ToolStripMenuItem menuDataset;
        private System.Windows.Forms.ToolStripMenuItem menuCreateGeometry;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteDst;
        private System.Windows.Forms.ToolStripMenuItem menuPasteDst;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAsSQLWKS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel btnQueryByMap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtSQLFilter;
        private System.Windows.Forms.ToolStripButton btnSQLQuery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cboLayersInMap;
        private System.Windows.Forms.ToolStripLabel btnQueryByDistrcit;
        private System.Windows.Forms.ToolStripTextBox txtCityChoose;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem menuSaveWKSFile;
        private System.Windows.Forms.ToolStripMenuItem CreatePointMenu;
        private System.Windows.Forms.ToolStripMenuItem CreateLineMenu;
        private System.Windows.Forms.ToolStripMenuItem CreatePolygonMenu;
        private System.Windows.Forms.ToolStripMenuItem 文件型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateFileFSmenu;
        private System.Windows.Forms.ToolStripMenuItem menuopenFileDS;
        private System.Windows.Forms.ToolStripMenuItem menuCreateDst;
        private System.Windows.Forms.ToolStripMenuItem btnCreatePointDataset;
        private System.Windows.Forms.ToolStripMenuItem btnCreateLineDataset;
        private System.Windows.Forms.ToolStripMenuItem btnCreatePolygonDataset;
        private System.Windows.Forms.ToolStripButton measureLengthMenu;
        private System.Windows.Forms.ToolStripButton measureAreaMenu;
        private System.Windows.Forms.ToolStripMenuItem 跟踪图层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddGeoevent;
        private System.Windows.Forms.ToolStripMenuItem menuMoveGeoevent;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 对象跟踪ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuTrackByPolyLine;
        private System.Windows.Forms.ToolStripMenuItem menuTrackByPolygon;
        private System.Windows.Forms.ToolStripMenuItem menuTrackBySelectGeo;
        private System.Windows.Forms.ToolStripMenuItem 对象闪烁ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止动画ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSLineTrack;
        private System.Windows.Forms.ToolStripMenuItem 工具栏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBufferAnalyse;
        private System.Windows.Forms.ToolStripMenuItem menuOverlayAnalyse;
        private System.Windows.Forms.ToolStripMenuItem 裁剪ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
    }
}

