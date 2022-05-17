
namespace MIDIConverter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.labelLoadFile = new System.Windows.Forms.Label();
			this.labelSavePath = new System.Windows.Forms.Label();
			this.buttonOpenFile = new System.Windows.Forms.Button();
			this.labelTitle = new System.Windows.Forms.Label();
			this.panelView = new System.Windows.Forms.Panel();
			this.labelPathOpen = new System.Windows.Forms.Label();
			this.buttonExit = new System.Windows.Forms.Button();
			this.labelConvertStatus = new System.Windows.Forms.Label();
			this.labelLineDown = new System.Windows.Forms.Label();
			this.labelLineUp = new System.Windows.Forms.Label();
			this.buttonConvert = new System.Windows.Forms.Button();
			this.labelPathSave = new System.Windows.Forms.Label();
			this.buttonSaveFile = new System.Windows.Forms.Button();
			this.openFileDialogLoadFile = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialogSaveFile = new System.Windows.Forms.SaveFileDialog();
			this.panelView.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelLoadFile
			// 
			this.labelLoadFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelLoadFile.BackColor = System.Drawing.Color.Transparent;
			this.labelLoadFile.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelLoadFile.ForeColor = System.Drawing.Color.Black;
			this.labelLoadFile.Location = new System.Drawing.Point(15, 249);
			this.labelLoadFile.Name = "labelLoadFile";
			this.labelLoadFile.Size = new System.Drawing.Size(1073, 23);
			this.labelLoadFile.TabIndex = 0;
			this.labelLoadFile.Text = "Select the file you want to convert.";
			this.labelLoadFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelSavePath
			// 
			this.labelSavePath.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelSavePath.BackColor = System.Drawing.Color.Transparent;
			this.labelSavePath.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelSavePath.ForeColor = System.Drawing.Color.Black;
			this.labelSavePath.Location = new System.Drawing.Point(15, 356);
			this.labelSavePath.Name = "labelSavePath";
			this.labelSavePath.Size = new System.Drawing.Size(1073, 23);
			this.labelSavePath.TabIndex = 1;
			this.labelSavePath.Text = "Select the path where you want to save the converted file.";
			this.labelSavePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonOpenFile
			// 
			this.buttonOpenFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.buttonOpenFile.BackColor = System.Drawing.Color.WhiteSmoke;
			this.buttonOpenFile.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonOpenFile.ForeColor = System.Drawing.Color.Black;
			this.buttonOpenFile.Location = new System.Drawing.Point(472, 275);
			this.buttonOpenFile.Name = "buttonOpenFile";
			this.buttonOpenFile.Size = new System.Drawing.Size(154, 28);
			this.buttonOpenFile.TabIndex = 2;
			this.buttonOpenFile.Text = "Open File";
			this.buttonOpenFile.UseVisualStyleBackColor = false;
			this.buttonOpenFile.Click += new System.EventHandler(this.ButtonOpenFileClick);
			// 
			// labelTitle
			// 
			this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTitle.BackColor = System.Drawing.Color.Transparent;
			this.labelTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelTitle.ForeColor = System.Drawing.Color.Black;
			this.labelTitle.Location = new System.Drawing.Point(3, 33);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(1097, 42);
			this.labelTitle.TabIndex = 4;
			this.labelTitle.Text = "MIDI Converter";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelView
			// 
			this.panelView.BackColor = System.Drawing.Color.White;
			this.panelView.Controls.Add(this.labelPathOpen);
			this.panelView.Controls.Add(this.buttonExit);
			this.panelView.Controls.Add(this.labelConvertStatus);
			this.panelView.Controls.Add(this.labelLineDown);
			this.panelView.Controls.Add(this.labelLineUp);
			this.panelView.Controls.Add(this.buttonConvert);
			this.panelView.Controls.Add(this.labelPathSave);
			this.panelView.Controls.Add(this.buttonSaveFile);
			this.panelView.Controls.Add(this.buttonOpenFile);
			this.panelView.Controls.Add(this.labelLoadFile);
			this.panelView.Controls.Add(this.labelSavePath);
			this.panelView.Controls.Add(this.labelTitle);
			this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelView.ForeColor = System.Drawing.Color.Transparent;
			this.panelView.Location = new System.Drawing.Point(0, 0);
			this.panelView.Name = "panelView";
			this.panelView.Size = new System.Drawing.Size(1103, 617);
			this.panelView.TabIndex = 5;
			this.panelView.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelViewPaint);
			// 
			// labelPathOpen
			// 
			this.labelPathOpen.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelPathOpen.BackColor = System.Drawing.Color.Transparent;
			this.labelPathOpen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.labelPathOpen.ForeColor = System.Drawing.Color.Black;
			this.labelPathOpen.Location = new System.Drawing.Point(18, 306);
			this.labelPathOpen.Name = "labelPathOpen";
			this.labelPathOpen.Size = new System.Drawing.Size(1073, 23);
			this.labelPathOpen.TabIndex = 12;
			this.labelPathOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonExit
			// 
			this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonExit.BackColor = System.Drawing.Color.WhiteSmoke;
			this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonExit.ForeColor = System.Drawing.Color.Black;
			this.buttonExit.Location = new System.Drawing.Point(1002, 576);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(86, 29);
			this.buttonExit.TabIndex = 11;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
			// 
			// labelConvertStatus
			// 
			this.labelConvertStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelConvertStatus.BackColor = System.Drawing.Color.Transparent;
			this.labelConvertStatus.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.labelConvertStatus.ForeColor = System.Drawing.Color.Black;
			this.labelConvertStatus.Location = new System.Drawing.Point(15, 549);
			this.labelConvertStatus.Name = "labelConvertStatus";
			this.labelConvertStatus.Size = new System.Drawing.Size(1073, 20);
			this.labelConvertStatus.TabIndex = 10;
			this.labelConvertStatus.Text = "display status";
			this.labelConvertStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelLineDown
			// 
			this.labelLineDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelLineDown.BackColor = System.Drawing.Color.Transparent;
			this.labelLineDown.ForeColor = System.Drawing.Color.Black;
			this.labelLineDown.Location = new System.Drawing.Point(169, 523);
			this.labelLineDown.Name = "labelLineDown";
			this.labelLineDown.Size = new System.Drawing.Size(757, 15);
			this.labelLineDown.TabIndex = 9;
			this.labelLineDown.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------------------------------------";
			// 
			// labelLineUp
			// 
			this.labelLineUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelLineUp.BackColor = System.Drawing.Color.Transparent;
			this.labelLineUp.ForeColor = System.Drawing.Color.Black;
			this.labelLineUp.Location = new System.Drawing.Point(169, 208);
			this.labelLineUp.Name = "labelLineUp";
			this.labelLineUp.Size = new System.Drawing.Size(757, 15);
			this.labelLineUp.TabIndex = 8;
			this.labelLineUp.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------------------------------------";
			// 
			// buttonConvert
			// 
			this.buttonConvert.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.buttonConvert.BackColor = System.Drawing.Color.WhiteSmoke;
			this.buttonConvert.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonConvert.ForeColor = System.Drawing.Color.Black;
			this.buttonConvert.Location = new System.Drawing.Point(459, 462);
			this.buttonConvert.Name = "buttonConvert";
			this.buttonConvert.Size = new System.Drawing.Size(185, 30);
			this.buttonConvert.TabIndex = 7;
			this.buttonConvert.Text = "Convert";
			this.buttonConvert.UseVisualStyleBackColor = false;
			this.buttonConvert.Click += new System.EventHandler(this.ButtonConvertClick);
			// 
			// labelPathSave
			// 
			this.labelPathSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelPathSave.BackColor = System.Drawing.Color.Transparent;
			this.labelPathSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.labelPathSave.ForeColor = System.Drawing.Color.Black;
			this.labelPathSave.Location = new System.Drawing.Point(15, 413);
			this.labelPathSave.Name = "labelPathSave";
			this.labelPathSave.Size = new System.Drawing.Size(1073, 23);
			this.labelPathSave.TabIndex = 6;
			this.labelPathSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonSaveFile
			// 
			this.buttonSaveFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.buttonSaveFile.BackColor = System.Drawing.Color.WhiteSmoke;
			this.buttonSaveFile.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonSaveFile.ForeColor = System.Drawing.Color.Black;
			this.buttonSaveFile.Location = new System.Drawing.Point(472, 382);
			this.buttonSaveFile.Name = "buttonSaveFile";
			this.buttonSaveFile.Size = new System.Drawing.Size(154, 28);
			this.buttonSaveFile.TabIndex = 5;
			this.buttonSaveFile.Text = "Save File";
			this.buttonSaveFile.UseVisualStyleBackColor = false;
			this.buttonSaveFile.Click += new System.EventHandler(this.ButtonSaveFileClick);
			// 
			// openFileDialogLoadFile
			// 
			this.openFileDialogLoadFile.Filter = "MIDI |*.mid;*.midi;*.MID;*.MIDI";
			// 
			// saveFileDialogSaveFile
			// 
			this.saveFileDialogSaveFile.Filter = "Json |*.json";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 617);
			this.Controls.Add(this.panelView);
			this.Name = "MainForm";
			this.Text = "MIDI Converter";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panelView.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Label labelLoadFile;
		private System.Windows.Forms.Label labelSavePath;
		private System.Windows.Forms.Button buttonOpenFile;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Panel panelView;
		private System.Windows.Forms.Label labelPathSave;
		private System.Windows.Forms.Button buttonSaveFile;
		private System.Windows.Forms.Button buttonConvert;
		private System.Windows.Forms.Label labelLineDown;
		private System.Windows.Forms.Label labelLineUp;
		private System.Windows.Forms.Label labelConvertStatus;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.OpenFileDialog openFileDialogLoadFile;
		private System.Windows.Forms.SaveFileDialog saveFileDialogSaveFile;
		private System.Windows.Forms.Label labelPathOpen;
	}
}