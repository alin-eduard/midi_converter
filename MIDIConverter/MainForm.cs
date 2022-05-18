using Newtonsoft.Json;

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

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
					var savePath = openFileDialogLoadFile.FileName.Replace(".mid", ".json");

					labelPathOpen.Text = openPath;
					labelPathSave.Text = savePath;
					saveFileDialogSaveFile.FileName = savePath;

					midiFile = IOSystem.ReadMidiFile(openPath);
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
				if (saveFileDialogSaveFile.ShowDialog() == DialogResult.OK)
				{
					labelPathSave.Text = saveFileDialogSaveFile.FileName;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void ButtonConvertClick(object sender, EventArgs e)
		{
			try
			{
				string[] path = openFileDialogLoadFile.FileName.Split(new char[] { '\\' });
				string songName = path[path.Length - 1].Replace(".mid", "");
				string levelName = songName;
				Random random = new Random();
				int rowPosition;

				LevelData.LevelData date = new LevelData.LevelData(levelName, LevelData.LevelDifficulty.Medium, songName);

				foreach (var track in midiFile.Tracks)
				{
					foreach (var midiEvent in track.MidiEvents)
					{
						if (!(midiEvent.MidiEventType == MidiEventType.MetaEvent))
						{
							if (MidiEventType.NoteOn == midiEvent.MidiEventType)
							{
								rowPosition = random.Next(0, 4);

								LevelData.TileData tile = new LevelData.TileData
								{
									Position = new LevelData.Position { X = rowPosition, Y = midiEvent.Time },
									Length = 0,
									Type = LevelData.TileType.normal,
									Life = 1,
									Note = midiEvent.Arg2
								};
								date.TilesData[rowPosition].Add(tile);
							}

							if(MidiEventType.NoteOff == midiEvent.MidiEventType)
							{
								foreach (var row in date.TilesData)
								{
									foreach (var tile in row)
										if (tile.Note == midiEvent.Arg2 && tile.Length == 0)
										{
											tile.Length = midiEvent.Time - tile.Position.Y;
											break;
										}
								}
							}
						}
					}
				}

				string jsonTest = JsonConvert.SerializeObject(date);
				IOSystem.SaveJson(labelPathSave.Text, jsonTest);
				labelConvertStatus.Text = "File was successfully converted!";
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				labelConvertStatus.Text = "File was not converted successfully!";
			}
		}
	}
}
