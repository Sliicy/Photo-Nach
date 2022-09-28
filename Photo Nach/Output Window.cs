using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_Nach {
    public partial class Output_Window : Form {
        public Output_Window() {
            InitializeComponent();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (picOutput.Image != null) {
                SaveFileDialog fileSave = new SaveFileDialog {
                    Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*",
                    RestoreDirectory = true
                };
                if (fileSave.ShowDialog() == DialogResult.OK) {
                    picOutput.Image.Save(fileSave.FileName, ImageFormat.Png);
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void Output_Window_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveAsToolStripMenuItem_Click(sender, e);
        }

        private void Output_Window_KeyDown(object sender, KeyEventArgs e) {

        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e) {
            if (picOutput.Image != null) {
                Clipboard.SetImage(picOutput.Image);
            }
        }

        private void CopyToolStripMenuItem1_Click(object sender, EventArgs e) {
            CopyToolStripMenuItem_Click(sender, e);
        }

        private void Output_Window_Load(object sender, EventArgs e)
        {
            if (FrmMain.stretchImage)
            {
                picOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            } else
            {
                picOutput.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}