namespace PatternRecognition {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.deviceListComboBox = new System.Windows.Forms.ComboBox();
            this.startVideoButton = new System.Windows.Forms.Button();
            this.stopVideoButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.videoSourcePlayer = new Accord.Controls.VideoSourcePlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.myCheckBox = new PatternRecognition.MyCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceListComboBox
            // 
            this.deviceListComboBox.FormattingEnabled = true;
            this.deviceListComboBox.Location = new System.Drawing.Point(13, 11);
            this.deviceListComboBox.Name = "deviceListComboBox";
            this.deviceListComboBox.Size = new System.Drawing.Size(199, 21);
            this.deviceListComboBox.TabIndex = 0;
            // 
            // startVideoButton
            // 
            this.startVideoButton.Location = new System.Drawing.Point(219, 10);
            this.startVideoButton.Name = "startVideoButton";
            this.startVideoButton.Size = new System.Drawing.Size(104, 23);
            this.startVideoButton.TabIndex = 1;
            this.startVideoButton.Text = "Start video";
            this.startVideoButton.UseVisualStyleBackColor = true;
            this.startVideoButton.Click += new System.EventHandler(this.startVideoButton_Click);
            // 
            // stopVideoButton
            // 
            this.stopVideoButton.Location = new System.Drawing.Point(330, 10);
            this.stopVideoButton.Name = "stopVideoButton";
            this.stopVideoButton.Size = new System.Drawing.Size(104, 23);
            this.stopVideoButton.TabIndex = 2;
            this.stopVideoButton.Text = "Stop video";
            this.stopVideoButton.UseVisualStyleBackColor = true;
            this.stopVideoButton.Click += new System.EventHandler(this.stopVideoButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(595, 472);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(430, 118);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 5;
            this.logoPictureBox.TabStop = false;
            // 
            // table
            // 
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.table.ColumnCount = 5;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table.Controls.Add(this.panel25, 4, 4);
            this.table.Controls.Add(this.panel24, 3, 4);
            this.table.Controls.Add(this.panel23, 2, 4);
            this.table.Controls.Add(this.panel22, 1, 4);
            this.table.Controls.Add(this.panel21, 0, 4);
            this.table.Controls.Add(this.panel20, 4, 3);
            this.table.Controls.Add(this.panel19, 3, 3);
            this.table.Controls.Add(this.panel18, 2, 3);
            this.table.Controls.Add(this.panel17, 1, 3);
            this.table.Controls.Add(this.panel16, 0, 3);
            this.table.Controls.Add(this.panel15, 4, 2);
            this.table.Controls.Add(this.panel14, 3, 2);
            this.table.Controls.Add(this.panel13, 2, 2);
            this.table.Controls.Add(this.panel12, 1, 2);
            this.table.Controls.Add(this.panel11, 0, 2);
            this.table.Controls.Add(this.panel10, 4, 1);
            this.table.Controls.Add(this.panel9, 3, 1);
            this.table.Controls.Add(this.panel8, 2, 1);
            this.table.Controls.Add(this.panel7, 1, 1);
            this.table.Controls.Add(this.panel6, 0, 1);
            this.table.Controls.Add(this.panel5, 4, 0);
            this.table.Controls.Add(this.panel4, 3, 0);
            this.table.Controls.Add(this.panel3, 2, 0);
            this.table.Controls.Add(this.panel2, 1, 0);
            this.table.Controls.Add(this.panel1, 0, 0);
            this.table.Location = new System.Drawing.Point(595, 38);
            this.table.MinimumSize = new System.Drawing.Size(430, 430);
            this.table.Name = "table";
            this.table.RowCount = 5;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table.Size = new System.Drawing.Size(430, 430);
            this.table.TabIndex = 6;
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.SystemColors.Control;
            this.panel25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel25.Location = new System.Drawing.Point(345, 345);
            this.panel25.Margin = new System.Windows.Forms.Padding(1);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(84, 84);
            this.panel25.TabIndex = 24;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.SystemColors.Control;
            this.panel24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel24.Location = new System.Drawing.Point(259, 345);
            this.panel24.Margin = new System.Windows.Forms.Padding(1);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(84, 84);
            this.panel24.TabIndex = 23;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.SystemColors.Control;
            this.panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(173, 345);
            this.panel23.Margin = new System.Windows.Forms.Padding(1);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(84, 84);
            this.panel23.TabIndex = 22;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.SystemColors.Control;
            this.panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(87, 345);
            this.panel22.Margin = new System.Windows.Forms.Padding(1);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(84, 84);
            this.panel22.TabIndex = 21;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.SystemColors.Control;
            this.panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Location = new System.Drawing.Point(1, 345);
            this.panel21.Margin = new System.Windows.Forms.Padding(1);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(84, 84);
            this.panel21.TabIndex = 20;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.SystemColors.Control;
            this.panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Location = new System.Drawing.Point(345, 259);
            this.panel20.Margin = new System.Windows.Forms.Padding(1);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(84, 84);
            this.panel20.TabIndex = 19;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.SystemColors.Control;
            this.panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(259, 259);
            this.panel19.Margin = new System.Windows.Forms.Padding(1);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(84, 84);
            this.panel19.TabIndex = 18;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.SystemColors.Control;
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(173, 259);
            this.panel18.Margin = new System.Windows.Forms.Padding(1);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(84, 84);
            this.panel18.TabIndex = 17;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.SystemColors.Control;
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(87, 259);
            this.panel17.Margin = new System.Windows.Forms.Padding(1);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(84, 84);
            this.panel17.TabIndex = 16;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.Control;
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(1, 259);
            this.panel16.Margin = new System.Windows.Forms.Padding(1);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(84, 84);
            this.panel16.TabIndex = 15;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.Control;
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(345, 173);
            this.panel15.Margin = new System.Windows.Forms.Padding(1);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(84, 84);
            this.panel15.TabIndex = 14;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.Control;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(259, 173);
            this.panel14.Margin = new System.Windows.Forms.Padding(1);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(84, 84);
            this.panel14.TabIndex = 13;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.Control;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(173, 173);
            this.panel13.Margin = new System.Windows.Forms.Padding(1);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(84, 84);
            this.panel13.TabIndex = 12;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.Control;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(87, 173);
            this.panel12.Margin = new System.Windows.Forms.Padding(1);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(84, 84);
            this.panel12.TabIndex = 11;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.Control;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(1, 173);
            this.panel11.Margin = new System.Windows.Forms.Padding(1);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(84, 84);
            this.panel11.TabIndex = 10;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.Control;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(345, 87);
            this.panel10.Margin = new System.Windows.Forms.Padding(1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(84, 84);
            this.panel10.TabIndex = 9;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Control;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(259, 87);
            this.panel9.Margin = new System.Windows.Forms.Padding(1);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(84, 84);
            this.panel9.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(173, 87);
            this.panel8.Margin = new System.Windows.Forms.Padding(1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(84, 84);
            this.panel8.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(87, 87);
            this.panel7.Margin = new System.Windows.Forms.Padding(1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(84, 84);
            this.panel7.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(1, 87);
            this.panel6.Margin = new System.Windows.Forms.Padding(1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(84, 84);
            this.panel6.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(345, 1);
            this.panel5.Margin = new System.Windows.Forms.Padding(1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(84, 84);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(259, 1);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(84, 84);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(173, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(84, 84);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(87, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(84, 84);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 84);
            this.panel1.TabIndex = 0;
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.videoSourcePlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.videoSourcePlayer.KeepAspectRatio = true;
            this.videoSourcePlayer.Location = new System.Drawing.Point(13, 39);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(573, 551);
            this.videoSourcePlayer.TabIndex = 7;
            this.videoSourcePlayer.Text = "Video";
            this.videoSourcePlayer.VideoSource = null;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(885, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enable detection";
            // 
            // myCheckBox
            // 
            this.myCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.myCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.myCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.myCheckBox.FlatAppearance.BorderSize = 2;
            this.myCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myCheckBox.Location = new System.Drawing.Point(978, 9);
            this.myCheckBox.Name = "myCheckBox";
            this.myCheckBox.Padding = new System.Windows.Forms.Padding(6);
            this.myCheckBox.Size = new System.Drawing.Size(46, 24);
            this.myCheckBox.TabIndex = 8;
            this.myCheckBox.Text = "myCheckBox";
            this.myCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.myCheckBox.UseVisualStyleBackColor = false;
            this.myCheckBox.CheckedChanged += new System.EventHandler(this.myCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1038, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myCheckBox);
            this.Controls.Add(this.videoSourcePlayer);
            this.Controls.Add(this.table);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.stopVideoButton);
            this.Controls.Add(this.startVideoButton);
            this.Controls.Add(this.deviceListComboBox);
            this.MinimumSize = new System.Drawing.Size(1050, 640);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinalForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.table.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox deviceListComboBox;
        private System.Windows.Forms.Button startVideoButton;
        private System.Windows.Forms.Button stopVideoButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Accord.Controls.VideoSourcePlayer videoSourcePlayer;
        private MyCheckBox myCheckBox;
        private System.Windows.Forms.Label label1;
    }
}