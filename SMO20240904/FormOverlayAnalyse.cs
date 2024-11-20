using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMO20240904
{
    public partial class FormOverlayAnalyse : Form
    { 
        private SuperMapLib.soLayers layers;
        public event EventHandler<OverlayEventArgs> OverlayAnalyse;

        string beOverlayName = null;
        string overlayRegionName = null;
        string modeType = null;
        string CityName = null;

        public FormOverlayAnalyse(List<string> layerNames, SuperMapLib.soLayers mapLayers)
        {
            InitializeComponent();

            // 保存传入的图层对象
            layers = mapLayers;

            // 将图层名称添加到 ComboBox
            cboBeOverlay.Items.AddRange(layerNames.ToArray());
            cboOverlayRegion.Items.AddRange(layerNames.ToArray());
        }

        private void cboBeOverlay_SelectedIndexChanged(object sender, EventArgs e)
        {
            string beOverlayName = cboBeOverlay.SelectedItem.ToString();
        }

        private void cboOverlayRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string overlayRegionName = cboOverlayRegion.SelectedItem.ToString();

            SuperMapLib.soLayer selectedLayer = layers[overlayRegionName];
            if (selectedLayer != null)
            {
                cboOverlayCity.Items.Clear();
                SuperMapLib.soDatasetVector dataset = (SuperMapLib.soDatasetVector)selectedLayer.Dataset;
                SuperMapLib.soRecordset recordset = dataset.Query("", false, null, "");
                while (!recordset.IsEOF())
                {
                    object nameField = recordset.GetFieldValue("Name");
                    if (nameField != null)
                    {
                        cboOverlayCity.Items.Add(nameField.ToString());
                    }
                    recordset.MoveNext();
                }
                recordset.Close();
            }
        }

        private void cboOverlayCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CityName = cboOverlayCity.SelectedItem.ToString();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            modeType = "cut";
            OnOverlayAnalyse(CreateOverlayEventArgs());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            modeType = "delete";
            OnOverlayAnalyse(CreateOverlayEventArgs());
        }

        private OverlayEventArgs CreateOverlayEventArgs()
        {
            return new OverlayEventArgs(beOverlayName, overlayRegionName, CityName, modeType);
        }

        protected virtual void OnOverlayAnalyse(OverlayEventArgs e)
        {
            if (OverlayAnalyse != null)
            {
                OverlayAnalyse(this, e);
            }
        }
    }

    public class OverlayEventArgs : EventArgs
    {
        public string BeOverlayName { get; set; }
        public string OverlayRegionName { get; set; }
        public string CityName { get; set; }
        public string ModeType { get; set; }

        public OverlayEventArgs() { }

        public OverlayEventArgs(string beOverlayName, string overlayRegionName, string cityName, string modeType)
        {
            BeOverlayName = beOverlayName;
            OverlayRegionName = overlayRegionName;
            CityName = cityName;
            ModeType = modeType;
        }
    }
}