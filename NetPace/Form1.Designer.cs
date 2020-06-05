namespace NetPace
{
    partial class NetPaceMain
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlDisplayInformation = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAdapterDesc = new System.Windows.Forms.Label();
            this.AdapterStatus = new System.Windows.Forms.Label();
            this.lblAdapterSpeed = new System.Windows.Forms.Label();
            this.AdapterName = new System.Windows.Forms.Label();
            this.AdapterSpeed = new System.Windows.Forms.Label();
            this.pnlAdapters = new System.Windows.Forms.Panel();
            this.lstAdapters = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlDisplayInformation.SuspendLayout();
            this.pnlAdapters.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(115)))));
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1037, 113);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(375, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(318, 47);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "NetPace";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnlContent.Controls.Add(this.pnlExit);
            this.pnlContent.Controls.Add(this.pnlDisplayInformation);
            this.pnlContent.Controls.Add(this.pnlAdapters);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 113);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1037, 488);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlDisplayInformation
            // 
            this.pnlDisplayInformation.Controls.Add(this.label2);
            this.pnlDisplayInformation.Controls.Add(this.lblAdapterDesc);
            this.pnlDisplayInformation.Controls.Add(this.AdapterStatus);
            this.pnlDisplayInformation.Controls.Add(this.lblAdapterSpeed);
            this.pnlDisplayInformation.Controls.Add(this.AdapterName);
            this.pnlDisplayInformation.Controls.Add(this.AdapterSpeed);
            this.pnlDisplayInformation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDisplayInformation.Location = new System.Drawing.Point(359, 0);
            this.pnlDisplayInformation.Name = "pnlDisplayInformation";
            this.pnlDisplayInformation.Size = new System.Drawing.Size(316, 488);
            this.pnlDisplayInformation.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAdapterDesc
            // 
            this.lblAdapterDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdapterDesc.Location = new System.Drawing.Point(9, 42);
            this.lblAdapterDesc.Name = "lblAdapterDesc";
            this.lblAdapterDesc.Size = new System.Drawing.Size(141, 39);
            this.lblAdapterDesc.TabIndex = 3;
            this.lblAdapterDesc.Text = "Name :";
            this.lblAdapterDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AdapterStatus
            // 
            this.AdapterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdapterStatus.Location = new System.Drawing.Point(181, 3);
            this.AdapterStatus.Name = "AdapterStatus";
            this.AdapterStatus.Size = new System.Drawing.Size(79, 39);
            this.AdapterStatus.TabIndex = 3;
            this.AdapterStatus.Text = "0";
            this.AdapterStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAdapterSpeed
            // 
            this.lblAdapterSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdapterSpeed.Location = new System.Drawing.Point(42, 81);
            this.lblAdapterSpeed.Name = "lblAdapterSpeed";
            this.lblAdapterSpeed.Size = new System.Drawing.Size(108, 33);
            this.lblAdapterSpeed.TabIndex = 3;
            this.lblAdapterSpeed.Text = "Speed :";
            this.lblAdapterSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AdapterName
            // 
            this.AdapterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdapterName.Location = new System.Drawing.Point(181, 42);
            this.AdapterName.Name = "AdapterName";
            this.AdapterName.Size = new System.Drawing.Size(178, 39);
            this.AdapterName.TabIndex = 3;
            this.AdapterName.Text = "0";
            this.AdapterName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdapterSpeed
            // 
            this.AdapterSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdapterSpeed.Location = new System.Drawing.Point(181, 81);
            this.AdapterSpeed.Name = "AdapterSpeed";
            this.AdapterSpeed.Size = new System.Drawing.Size(201, 33);
            this.AdapterSpeed.TabIndex = 3;
            this.AdapterSpeed.Text = "0 ";
            this.AdapterSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAdapters
            // 
            this.pnlAdapters.Controls.Add(this.lstAdapters);
            this.pnlAdapters.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAdapters.Location = new System.Drawing.Point(0, 0);
            this.pnlAdapters.Name = "pnlAdapters";
            this.pnlAdapters.Size = new System.Drawing.Size(359, 488);
            this.pnlAdapters.TabIndex = 5;
            // 
            // lstAdapters
            // 
            this.lstAdapters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.lstAdapters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAdapters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAdapters.ForeColor = System.Drawing.Color.White;
            this.lstAdapters.FormattingEnabled = true;
            this.lstAdapters.ItemHeight = 18;
            this.lstAdapters.Location = new System.Drawing.Point(0, 0);
            this.lstAdapters.Name = "lstAdapters";
            this.lstAdapters.Size = new System.Drawing.Size(359, 488);
            this.lstAdapters.TabIndex = 4;
            this.lstAdapters.SelectedIndexChanged += new System.EventHandler(this.lstAdapters_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(0, 412);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(362, 76);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlExit
            // 
            this.pnlExit.Controls.Add(this.btnClose);
            this.pnlExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExit.Location = new System.Drawing.Point(675, 0);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(362, 488);
            this.pnlExit.TabIndex = 7;
            // 
            // NetPaceMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1037, 601);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "NetPaceMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetPace";
            this.pnlHeader.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlDisplayInformation.ResumeLayout(false);
            this.pnlAdapters.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAdapterDesc;
        private System.Windows.Forms.Label lblAdapterSpeed;
        private System.Windows.Forms.Label AdapterName;
        private System.Windows.Forms.Label AdapterSpeed;
        private System.Windows.Forms.Panel pnlAdapters;
        private System.Windows.Forms.ListBox lstAdapters;
        private System.Windows.Forms.Panel pnlDisplayInformation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AdapterStatus;
        private System.Windows.Forms.Panel pnlExit;
    }
}

