using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SuperMapLib;

namespace SMO20240904
{
    public partial class FormChooseTrack : Form
    {
        private SuperMapLib.soLayers layers;
        public event EventHandler<TrackEventArgs> TrackChosen;

        private double startX, startY, endX, endY;

        public FormChooseTrack(List<string> layerNames, SuperMapLib.soLayers mapLayers)
        {
            InitializeComponent();

            // 保存传入的图层对象
            layers = mapLayers;

            // 将图层名称添加到 ComboBox
            cboStartLayer.Items.AddRange(layerNames.ToArray());
            cboEndLayer.Items.AddRange(layerNames.ToArray());
        }

        private void cboStartLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 获取选中的图层名称
            string selectedLayerName = cboStartLayer.SelectedItem.ToString();
            // 根据名称获取对应的图层对象
            SuperMapLib.soLayer selectedLayer = layers[selectedLayerName];
            if (selectedLayer != null)
            {
                // 清空之前的项
                cboStart.Items.Clear();

                // 获取图层的数据集
                SuperMapLib.soDatasetVector dataset = (SuperMapLib.soDatasetVector)selectedLayer.Dataset;
                // 获取所有要素的记录集
                SuperMapLib.soRecordset recordset = dataset.Query("", false, null, "");
                // 遍历记录集，提取 Name 字段的值
                while (!recordset.IsEOF())
                {
                    object nameField = recordset.GetFieldValue("Name");
                    if (nameField != null)
                    {
                        cboStart.Items.Add(nameField.ToString());
                    }
                    recordset.MoveNext();
                }
                // 关闭记录集
                recordset.Close();
            }
        }

        private void cboEndLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLayerName = cboEndLayer.SelectedItem.ToString();
            SuperMapLib.soLayer selectedLayer = layers[selectedLayerName];
            if (selectedLayer != null)
            {
                cboEnd.Items.Clear();
                SuperMapLib.soDatasetVector dataset = (SuperMapLib.soDatasetVector)selectedLayer.Dataset;
                SuperMapLib.soRecordset recordset = dataset.Query("", false, null, "");
                while (!recordset.IsEOF())
                {
                    object nameField = recordset.GetFieldValue("Name");
                    if (nameField != null)
                    {
                        cboEnd.Items.Add(nameField.ToString());
                    }
                    recordset.MoveNext();
                }
                recordset.Close();
            }
        }

        private void cboStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLayerName = cboStartLayer.SelectedItem.ToString();
            string selectedPointName = cboStart.SelectedItem.ToString();
            GetCoordinates(selectedLayerName, selectedPointName, out startX, out startY);
        }

        private void cboEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLayerName = cboEndLayer.SelectedItem.ToString();
            string selectedPointName = cboEnd.SelectedItem.ToString();
            GetCoordinates(selectedLayerName, selectedPointName, out endX, out endY);
        }

        private void btnChooseTrack_Click(object sender, EventArgs e)
        {
            // 触发事件并传递选中的起点和终点的坐标
            OnTrackChosen(CreateTrackEventArgs());
        }

        private TrackEventArgs CreateTrackEventArgs()
        {
            return new TrackEventArgs(startX, startY, endX, endY);
        }

        protected virtual void OnTrackChosen(TrackEventArgs e)
        {
            if (TrackChosen != null)
            {
                TrackChosen(this, e);
            }
        }

        private void GetCoordinates(string layerName, string pointName, out double x, out double y)
        {
            x = 0.0;
            y = 0.0;
            SuperMapLib.soLayer layer = layers[layerName];
            if (layer != null)
            {
                SuperMapLib.soDatasetVector dataset = (SuperMapLib.soDatasetVector)layer.Dataset;
                SuperMapLib.soRecordset recordset = dataset.Query("Name = '" + pointName + "'", true);
                if (!recordset.IsEOF())
                {
                    SuperMapLib.soGeometry geometry = recordset.GetGeometry();
                    if (geometry != null && geometry.Type == SuperMapLib.seGeometryType.scgPoint)
                    {
                        SuperMapLib.soGeoPoint geoPoint = (SuperMapLib.soGeoPoint)geometry;
                        x = geoPoint.x;
                        y = geoPoint.y;
                    }
                }
                recordset.Close();
            }
        }
    }

    public class TrackEventArgs : EventArgs
    {
        public double StartX { get; }
        public double StartY { get; }
        public double EndX { get; }
        public double EndY { get; }

        public TrackEventArgs(double startX, double startY, double endX, double endY)
        {
            StartX = startX;
            StartY = startY;
            EndX = endX;
            EndY = endY;
        }
    }
}