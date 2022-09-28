namespace Photo_Nach {
    partial class FrmMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.chkSpaces = new System.Windows.Forms.CheckBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkStretch = new System.Windows.Forms.CheckBox();
            this.lblIndex = new System.Windows.Forms.Label();
            this.btnRemoveChapters = new System.Windows.Forms.Button();
            this.trackBlack = new System.Windows.Forms.TrackBar();
            this.chkZoharMode = new System.Windows.Forms.CheckBox();
            this.chkTrackSingle = new System.Windows.Forms.CheckBox();
            this.lblCustomWidth = new System.Windows.Forms.Label();
            this.numCustomWidth = new System.Windows.Forms.NumericUpDown();
            this.chkSofis = new System.Windows.Forms.CheckBox();
            this.chkSanitize = new System.Windows.Forms.CheckBox();
            this.chkCrowns = new System.Windows.Forms.CheckBox();
            this.chkCantillations = new System.Windows.Forms.CheckBox();
            this.chkChataf = new System.Windows.Forms.CheckBox();
            this.chkNekudos = new System.Windows.Forms.CheckBox();
            this.chkDottedLetters = new System.Windows.Forms.CheckBox();
            this.chkTabs = new System.Windows.Forms.CheckBox();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCustomWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(0, 0);
            this.txtInput.Margin = new System.Windows.Forms.Padding(6);
            this.txtInput.MaxLength = 0;
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInput.Size = new System.Drawing.Size(284, 661);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.StateChanged_CheckedChanged);
            // 
            // chkSpaces
            // 
            this.chkSpaces.AutoSize = true;
            this.chkSpaces.Location = new System.Drawing.Point(11, 114);
            this.chkSpaces.Margin = new System.Windows.Forms.Padding(6);
            this.chkSpaces.Name = "chkSpaces";
            this.chkSpaces.Size = new System.Drawing.Size(148, 28);
            this.chkSpaces.TabIndex = 4;
            this.chkSpaces.Text = "Ignore &spaces";
            this.chkSpaces.UseVisualStyleBackColor = true;
            this.chkSpaces.CheckedChanged += new System.EventHandler(this.StateChanged_CheckedChanged);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkStretch);
            this.grpOptions.Controls.Add(this.lblIndex);
            this.grpOptions.Controls.Add(this.btnRemoveChapters);
            this.grpOptions.Controls.Add(this.trackBlack);
            this.grpOptions.Controls.Add(this.chkZoharMode);
            this.grpOptions.Controls.Add(this.chkTrackSingle);
            this.grpOptions.Controls.Add(this.lblCustomWidth);
            this.grpOptions.Controls.Add(this.numCustomWidth);
            this.grpOptions.Controls.Add(this.chkSofis);
            this.grpOptions.Controls.Add(this.chkSanitize);
            this.grpOptions.Controls.Add(this.chkCrowns);
            this.grpOptions.Controls.Add(this.chkCantillations);
            this.grpOptions.Controls.Add(this.chkChataf);
            this.grpOptions.Controls.Add(this.chkNekudos);
            this.grpOptions.Controls.Add(this.chkDottedLetters);
            this.grpOptions.Controls.Add(this.chkTabs);
            this.grpOptions.Controls.Add(this.chkSpaces);
            this.grpOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpOptions.Location = new System.Drawing.Point(284, 0);
            this.grpOptions.Margin = new System.Windows.Forms.Padding(6);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Padding = new System.Windows.Forms.Padding(6);
            this.grpOptions.Size = new System.Drawing.Size(400, 661);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Diacritical Options";
            // 
            // chkStretch
            // 
            this.chkStretch.AutoSize = true;
            this.chkStretch.Checked = true;
            this.chkStretch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStretch.Location = new System.Drawing.Point(9, 598);
            this.chkStretch.Name = "chkStretch";
            this.chkStretch.Size = new System.Drawing.Size(144, 28);
            this.chkStretch.TabIndex = 17;
            this.chkStretch.Text = "St&retch Image";
            this.chkStretch.UseVisualStyleBackColor = true;
            this.chkStretch.CheckedChanged += new System.EventHandler(this.ChkStretch_CheckedChanged);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(9, 468);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(77, 24);
            this.lblIndex.TabIndex = 16;
            this.lblIndex.Text = "Index: 0";
            // 
            // btnRemoveChapters
            // 
            this.btnRemoveChapters.Location = new System.Drawing.Point(9, 542);
            this.btnRemoveChapters.Name = "btnRemoveChapters";
            this.btnRemoveChapters.Size = new System.Drawing.Size(275, 50);
            this.btnRemoveChapters.TabIndex = 15;
            this.btnRemoveChapters.Text = "Remove Chapters";
            this.btnRemoveChapters.UseVisualStyleBackColor = true;
            this.btnRemoveChapters.Click += new System.EventHandler(this.BtnRemoveChapters_Click);
            // 
            // trackBlack
            // 
            this.trackBlack.Enabled = false;
            this.trackBlack.Location = new System.Drawing.Point(92, 468);
            this.trackBlack.Name = "trackBlack";
            this.trackBlack.Size = new System.Drawing.Size(235, 45);
            this.trackBlack.TabIndex = 14;
            this.trackBlack.Scroll += new System.EventHandler(this.StateChanged_CheckedChanged);
            // 
            // chkZoharMode
            // 
            this.chkZoharMode.AutoSize = true;
            this.chkZoharMode.Location = new System.Drawing.Point(11, 508);
            this.chkZoharMode.Name = "chkZoharMode";
            this.chkZoharMode.Size = new System.Drawing.Size(205, 28);
            this.chkZoharMode.TabIndex = 13;
            this.chkZoharMode.Text = "&Zohar Colored Mode";
            this.chkZoharMode.UseVisualStyleBackColor = true;
            this.chkZoharMode.CheckedChanged += new System.EventHandler(this.StateChanged_CheckedChanged);
            // 
            // chkTrackSingle
            // 
            this.chkTrackSingle.AutoSize = true;
            this.chkTrackSingle.Location = new System.Drawing.Point(11, 433);
            this.chkTrackSingle.Name = "chkTrackSingle";
            this.chkTrackSingle.Size = new System.Drawing.Size(219, 28);
            this.chkTrackSingle.TabIndex = 13;
            this.chkTrackSingle.Text = "Trac&k single character:";
            this.chkTrackSingle.UseVisualStyleBackColor = true;
            this.chkTrackSingle.CheckedChanged += new System.EventHandler(this.ChkTrackSingle_CheckedChanged);
            // 
            // lblCustomWidth
            // 
            this.lblCustomWidth.AutoSize = true;
            this.lblCustomWidth.Location = new System.Drawing.Point(8, 397);
            this.lblCustomWidth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCustomWidth.Name = "lblCustomWidth";
            this.lblCustomWidth.Size = new System.Drawing.Size(128, 24);
            this.lblCustomWidth.TabIndex = 11;
            this.lblCustomWidth.Text = "Custom &width:";
            // 
            // numCustomWidth
            // 
            this.numCustomWidth.Location = new System.Drawing.Point(148, 395);
            this.numCustomWidth.Margin = new System.Windows.Forms.Padding(6);
            this.numCustomWidth.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numCustomWidth.Name = "numCustomWidth";
            this.numCustomWidth.Size = new System.Drawing.Size(179, 29);
            this.numCustomWidth.TabIndex = 12;
            this.numCustomWidth.ValueChanged += new System.EventHandler(this.StateChanged_CheckedChanged);
            // 
            // chkSofis
            // 
            this.chkSofis.AutoSize = true;
            this.chkSofis.Location = new System.Drawing.Point(11, 74);
            this.chkSofis.Margin = new System.Windows.Forms.Padding(6);
            this.chkSofis.Name = "chkSofis";
            this.chkSofis.Size = new System.Drawing.Size(128, 28);
            this.chkSofis.TabIndex = 3;
            this.chkSofis.Text = "Ignore S&ofis";
            this.chkSofis.UseVisualStyleBackColor = true;
            this.chkSofis.CheckedChanged += new System.EventHandler(this.StateChanged_CheckedChanged);
            // 
            // chkSanitize
            // 
            this.chkSanitize.AutoSize = true;
            this.chkSanitize.Location = new System.Drawing.Point(12, 34);
            this.chkSanitize.Margin = new System.Windows.Forms.Padding(6);
            this.chkSanitize.Name = "chkSanitize";
            this.chkSanitize.Size = new System.Drawing.Size(324, 28);
            this.chkSanitize.TabIndex = 2;
            this.chkSanitize.Text = "Sanitize &Input (remove punctuation)";
            this.chkSanitize.UseVisualStyleBackColor = true;
            this.chkSanitize.CheckedChanged += new System.EventHandler(this.StateChanged_CheckedChanged);
            // 
            // chkCrowns
            // 
            this.chkCrowns.AutoSize = true;
            this.chkCrowns.Location = new System.Drawing.Point(12, 354);
            this.chkCrowns.Margin = new System.Windows.Forms.Padding(6);
            this.chkCrowns.Name = "chkCrowns";
            this.chkCrowns.Size = new System.Drawing.Size(152, 28);
            this.chkCrowns.TabIndex = 10;
            this.chkCrowns.Text = "Ignore C&rowns";
            this.chkCrowns.UseVisualStyleBackColor = true;
            this.chkCrowns.CheckedChanged += new System.EventHandler(this.StateChanged_CheckedChanged);
            // 
            // chkCantillations
            // 
            this.chkCantillations.AutoSize = true;
            this.chkCantillations.Location = new System.Drawing.Point(12, 314);
            this.chkCantillations.Margin = new System.Windows.Forms.Padding(6);
            this.chkCantillations.Name = "chkCantillations";
            this.chkCantillations.Size = new System.Drawing.Size(187, 28);
            this.chkCantillations.TabIndex = 9;
            this.chkCantillations.Text = "Ignore C&antillations";
            this.chkCantillations.UseVisualStyleBackColor = true;
            this.chkCantillations.CheckedChanged += new System.EventHandler(this.StateChanged_CheckedChanged);
            // 
            // chkChataf
            // 
            this.chkChataf.AutoSize = true;
            this.chkChataf.Location = new System.Drawing.Point(12, 274);
            this.chkChataf.Margin = new System.Windows.Forms.Padding(6);
            this.chkChataf.Name = "chkChataf";
            this.chkChataf.Size = new System.Drawing.Size(221, 28);
            this.chkChataf.TabIndex = 8;
            this.chkChataf.Text = "Ignore &Chataf Nekudos";
            this.chkChataf.UseVisualStyleBackColor = true;
            this.chkChataf.CheckedChanged += new System.EventHandler(this.StateChanged_CheckedChanged);
            // 
            // chkNekudos
            // 
            this.chkNekudos.AutoSize = true;
            this.chkNekudos.Location = new System.Drawing.Point(12, 234);
            this.chkNekudos.Margin = new System.Windows.Forms.Padding(6);
            this.chkNekudos.Name = "chkNekudos";
            this.chkNekudos.Size = new System.Drawing.Size(309, 28);
            this.chkNekudos.TabIndex = 7;
            this.chkNekudos.Text = "Ignore &Nekudos (includes Chataf)";
            this.chkNekudos.UseVisualStyleBackColor = true;
            this.chkNekudos.CheckedChanged += new System.EventHandler(this.StateChanged_CheckedChanged);
            // 
            // chkDottedLetters
            // 
            this.chkDottedLetters.AutoSize = true;
            this.chkDottedLetters.Location = new System.Drawing.Point(12, 194);
            this.chkDottedLetters.Margin = new System.Windows.Forms.Padding(6);
            this.chkDottedLetters.Name = "chkDottedLetters";
            this.chkDottedLetters.Size = new System.Drawing.Size(197, 28);
            this.chkDottedLetters.TabIndex = 6;
            this.chkDottedLetters.Text = "Ignore &dots in letters";
            this.chkDottedLetters.UseVisualStyleBackColor = true;
            this.chkDottedLetters.CheckedChanged += new System.EventHandler(this.StateChanged_CheckedChanged);
            // 
            // chkTabs
            // 
            this.chkTabs.AutoSize = true;
            this.chkTabs.Location = new System.Drawing.Point(11, 154);
            this.chkTabs.Margin = new System.Windows.Forms.Padding(6);
            this.chkTabs.Name = "chkTabs";
            this.chkTabs.Size = new System.Drawing.Size(206, 28);
            this.chkTabs.TabIndex = 5;
            this.chkTabs.Text = "Ignore &tabs && dashes";
            this.chkTabs.UseVisualStyleBackColor = true;
            this.chkTabs.CheckedChanged += new System.EventHandler(this.StateChanged_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.grpOptions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Nach";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCustomWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.CheckBox chkSpaces;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox chkCrowns;
        private System.Windows.Forms.CheckBox chkCantillations;
        private System.Windows.Forms.CheckBox chkChataf;
        private System.Windows.Forms.CheckBox chkNekudos;
        private System.Windows.Forms.CheckBox chkDottedLetters;
        private System.Windows.Forms.CheckBox chkTabs;
        private System.Windows.Forms.Label lblCustomWidth;
        private System.Windows.Forms.CheckBox chkSofis;
        private System.Windows.Forms.NumericUpDown numCustomWidth;
        private System.Windows.Forms.CheckBox chkSanitize;
        private System.Windows.Forms.CheckBox chkTrackSingle;
        private System.Windows.Forms.TrackBar trackBlack;
        private System.Windows.Forms.CheckBox chkZoharMode;
        private System.Windows.Forms.Button btnRemoveChapters;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.CheckBox chkStretch;
    }
}

