
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
			this.buttonLoadFile = new System.Windows.Forms.Button();
			this.labelTitle = new System.Windows.Forms.Label();
			this.panelView = new System.Windows.Forms.Panel();
			this.buttonExit = new System.Windows.Forms.Button();
			this.labelConvertStatus = new System.Windows.Forms.Label();
			this.labelLineDown = new System.Windows.Forms.Label();
			this.labelLineUp = new System.Windows.Forms.Label();
			this.buttonConvert = new System.Windows.Forms.Button();
			this.labelPath = new System.Windows.Forms.Label();
			this.buttonSavePath = new System.Windows.Forms.Button();
			this.panelView.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelLoadFile
			// 
			this.labelLoadFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelLoadFile.BackColor = System.Drawing.Color.Transparent;
			this.labelLoadFile.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelLoadFile.ForeColor = System.Drawing.Color.Black;
			this.labelLoadFile.Location = new System.Drawing.Point(3, 249);
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
			this.labelSavePath.Location = new System.Drawing.Point(3, 338);
			this.labelSavePath.Name = "labelSavePath";
			this.labelSavePath.Size = new System.Drawing.Size(1073, 23);
			this.labelSavePath.TabIndex = 1;
			this.labelSavePath.Text = "Select the path where you want to save the converted file.";
			this.labelSavePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonLoadFile
			// 
			this.buttonLoadFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.buttonLoadFile.BackColor = System.Drawing.Color.WhiteSmoke;
			this.buttonLoadFile.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonLoadFile.ForeColor = System.Drawing.Color.Black;
			this.buttonLoadFile.Location = new System.Drawing.Point(460, 287);
			this.buttonLoadFile.Name = "buttonLoadFile";
			this.buttonLoadFile.Size = new System.Drawing.Size(154, 28);
			this.buttonLoadFile.TabIndex = 2;
			this.buttonLoadFile.Text = "Load File";
			this.buttonLoadFile.UseVisualStyleBackColor = false;
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
			this.labelTitle.Size = new System.Drawing.Size(1073, 42);
			this.labelTitle.TabIndex = 4;
			this.labelTitle.Text = "MIDI Converter";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelView
			// 
			this.panelView.BackColor = System.Drawing.Color.White;
			this.panelView.Controls.Add(this.buttonExit);
			this.panelView.Controls.Add(this.labelConvertStatus);
			this.panelView.Controls.Add(this.labelLineDown);
			this.panelView.Controls.Add(this.labelLineUp);
			this.panelView.Controls.Add(this.buttonConvert);
			this.panelView.Controls.Add(this.labelPath);
			this.panelView.Controls.Add(this.buttonSavePath);
			this.panelView.Controls.Add(this.buttonLoadFile);
			this.panelView.Controls.Add(this.labelLoadFile);
			this.panelView.Controls.Add(this.labelSavePath);
			this.panelView.Controls.Add(this.labelTitle);
			this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelView.ForeColor = System.Drawing.Color.Transparent;
			this.panelView.Location = new System.Drawing.Point(0, 0);
			this.panelView.Name = "panelView";
			this.panelView.Size = new System.Drawing.Size(1079, 584);
			this.panelView.TabIndex = 5;
			this.panelView.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelViewPaint);
			// 
			// buttonExit
			// 
			this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonExit.BackColor = System.Drawing.Color.WhiteSmoke;
			this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonExit.ForeColor = System.Drawing.Color.Black;
			this.buttonExit.Location = new System.Drawing.Point(960, 531);
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
			this.labelConvertStatus.Location = new System.Drawing.Point(3, 531);
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
			this.labelLineDown.Location = new System.Drawing.Point(157, 505);
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
			this.labelLineUp.Location = new System.Drawing.Point(157, 208);
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
			this.buttonConvert.Location = new System.Drawing.Point(445, 460);
			this.buttonConvert.Name = "buttonConvert";
			this.buttonConvert.Size = new System.Drawing.Size(185, 30);
			this.buttonConvert.TabIndex = 7;
			this.buttonConvert.Text = "Convert";
			this.buttonConvert.UseVisualStyleBackColor = false;
			// 
			// labelPath
			// 
			this.labelPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelPath.BackColor = System.Drawing.Color.Transparent;
			this.labelPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.labelPath.ForeColor = System.Drawing.Color.Black;
			this.labelPath.Location = new System.Drawing.Point(3, 418);
			this.labelPath.Name = "labelPath";
			this.labelPath.Size = new System.Drawing.Size(1073, 23);
			this.labelPath.TabIndex = 6;
			this.labelPath.Text = "display path";
			this.labelPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonSavePath
			// 
			this.buttonSavePath.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.buttonSavePath.BackColor = System.Drawing.Color.WhiteSmoke;
			this.buttonSavePath.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonSavePath.ForeColor = System.Drawing.Color.Black;
			this.buttonSavePath.Location = new System.Drawing.Point(460, 380);
			this.buttonSavePath.Name = "buttonSavePath";
			this.buttonSavePath.Size = new System.Drawing.Size(154, 35);
			this.buttonSavePath.TabIndex = 5;
			this.buttonSavePath.Text = "File Path";
			this.buttonSavePath.UseVisualStyleBackColor = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1079, 584);
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
		private System.Windows.Forms.Button buttonLoadFile;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Panel panelView;
		private System.Windows.Forms.Label labelPath;
		private System.Windows.Forms.Button buttonSavePath;
		private System.Windows.Forms.Button buttonConvert;
		private System.Windows.Forms.Label labelLineDown;
		private System.Windows.Forms.Label labelLineUp;
		private System.Windows.Forms.Label labelConvertStatus;
		private System.Windows.Forms.Button buttonExit;
	}
}