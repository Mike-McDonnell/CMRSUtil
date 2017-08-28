using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMRSToCKL
{
    public partial class Form1 : Form
    {
        public CMRSUtil.ICMRSConverter Converter = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "*.xml";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var filestream = openFileDialog1.OpenFile())
                {
                    using (var streamReader = new System.IO.StreamReader(filestream, Encoding.UTF8))
                    {
                        Converter = new CMRSUtil.CMRSConverter(streamReader.ReadToEnd());
                        propertyGrid1.SelectedObject = new CMRSProperties(Converter.CMRSInfomation);
                        convertToolStripMenuItem.Visible = true;
                    }
                }
            }
        }

        private void loadCKLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "*.ckl";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var filestream = openFileDialog1.OpenFile())
                {
                    using (var streamReader = new System.IO.StreamReader(filestream, Encoding.UTF8))
                    {
                        Converter.LoadCKL(streamReader.ReadToEnd());
                        propertyGrid2.SelectedObject = new CKLProperties(Converter.CheckListInfo);
                        ConvertButton.Enabled = true;
                    }
                }
            }
        }

        private void loadXCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "*.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var filestream = openFileDialog1.OpenFile())
                {
                    using (var streamReader = new System.IO.StreamReader(filestream, Encoding.UTF8))
                    {
                        Converter.LoadBenchmark(streamReader.ReadToEnd());
                        propertyGrid2.SelectedObject = new CKLProperties(Converter.CheckListInfo);
                        ConvertButton.Enabled = true;
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".ckl";
            saveFileDialog1.Filter = "Checklist file (*.ckl)|*.ckl";
            saveFileDialog1.FileName = Converter.CheckListInfo.Title;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter filestream = new System.IO.StreamWriter(saveFileDialog1.OpenFile(), Encoding.UTF8))
                {
                    filestream.WriteLine(Converter.Export());
                }
            }

        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {

            Converter.Transform();
            propertyGrid2.SelectedObject = new CKLProperties(Converter.CheckListInfo);
            this.SaveButton.Enabled = Converter.CheckListInfo.Transfromed;
        }
    }
}
