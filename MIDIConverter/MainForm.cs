using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MIDIConverter
{
    public partial class MainForm : Form
    {
        private MidiFile midiFile = new MidiFile();
        public MainForm()
        {
            InitializeComponent();
        }

		private void MainFormLoad(object sender, EventArgs e)
		{
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
		}

		private void PanelViewPaint(object sender, PaintEventArgs e)
		{
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(95, 155, 173), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgd = new LinearGradientBrush(area, Color.FromArgb(95, 155, 173), 
                Color.FromArgb(245, 250, 250), 
                LinearGradientMode.Vertical);
            graphics.FillRectangle(lgd, area);
            graphics.DrawRectangle(pen, area);
		}

		private void ButtonExitClick(object sender, EventArgs e)
		{
            Application.Exit();
		}

		private void ButtonOpenFileClick(object sender, EventArgs e)
		{
			try
			{
                if(openFileDialogLoadFile.ShowDialog() == DialogResult.OK)
				{
					var openPath = openFileDialogLoadFile.FileName;
					labelPathOpen.Text = openPath;
					midiFile = MyIO.ReadMidiFile(openPath);
				}
			}
            catch(Exception ex)
			{
                MessageBox.Show(ex.Message);
			}
		}
		private void ButtonSaveFileClick(object sender, EventArgs e)
		{
			try
			{
				if(saveFileDialogSaveFile.ShowDialog() == DialogResult.OK)
				{
					var savePath = saveFileDialogSaveFile.FileName;
					labelPathSave.Text = savePath;
					string jsonTest = JsonConvert.SerializeObject("test");
					MyIO.SaveJsone(savePath, jsonTest);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
