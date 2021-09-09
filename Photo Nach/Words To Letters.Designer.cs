
namespace Photo_Nach
{
    partial class Words_To_Letters
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Words_To_Letters));
            this.txtWords = new System.Windows.Forms.TextBox();
            this.txtLetters = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbLookupWord = new System.Windows.Forms.ComboBox();
            this.cbLookupCharacter = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtWords
            // 
            this.txtWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWords.Location = new System.Drawing.Point(3, 3);
            this.txtWords.MaxLength = 0;
            this.txtWords.Multiline = true;
            this.txtWords.Name = "txtWords";
            this.txtWords.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWords.Size = new System.Drawing.Size(386, 426);
            this.txtWords.TabIndex = 0;
            this.txtWords.TextChanged += new System.EventHandler(this.TxtWords_TextChanged);
            // 
            // txtLetters
            // 
            this.txtLetters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLetters.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetters.Location = new System.Drawing.Point(395, 3);
            this.txtLetters.MaxLength = 0;
            this.txtLetters.Multiline = true;
            this.txtLetters.Name = "txtLetters";
            this.txtLetters.ReadOnly = true;
            this.txtLetters.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLetters.Size = new System.Drawing.Size(386, 426);
            this.txtLetters.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtWords, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLetters, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbLookupWord, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbLookupCharacter, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 461);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cbLookupWord
            // 
            this.cbLookupWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbLookupWord.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLookupWord.FormattingEnabled = true;
            this.cbLookupWord.Location = new System.Drawing.Point(3, 435);
            this.cbLookupWord.Name = "cbLookupWord";
            this.cbLookupWord.Size = new System.Drawing.Size(386, 33);
            this.cbLookupWord.TabIndex = 2;
            this.cbLookupWord.SelectedIndexChanged += new System.EventHandler(this.CbLookupWord_SelectedIndexChanged);
            this.cbLookupWord.TextChanged += new System.EventHandler(this.CbLookupWord_SelectedIndexChanged);
            // 
            // cbLookupCharacter
            // 
            this.cbLookupCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbLookupCharacter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLookupCharacter.FormattingEnabled = true;
            this.cbLookupCharacter.Location = new System.Drawing.Point(395, 435);
            this.cbLookupCharacter.Name = "cbLookupCharacter";
            this.cbLookupCharacter.Size = new System.Drawing.Size(386, 33);
            this.cbLookupCharacter.TabIndex = 2;
            this.cbLookupCharacter.SelectedIndexChanged += new System.EventHandler(this.CbLookupCharacter_SelectedIndexChanged);
            this.cbLookupCharacter.TextChanged += new System.EventHandler(this.CbLookupCharacter_SelectedIndexChanged);
            // 
            // Words_To_Letters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Words_To_Letters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Words to Letters";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.TextBox txtLetters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbLookupWord;
        private System.Windows.Forms.ComboBox cbLookupCharacter;
        private System.Windows.Forms.ToolTip toolTip;
    }
}