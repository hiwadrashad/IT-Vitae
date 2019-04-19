namespace De_Dierentuin
{
    partial class Form1
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
            this.FeedAll = new System.Windows.Forms.Button();
            this.FeedMonkeys = new System.Windows.Forms.Button();
            this.FeedLions = new System.Windows.Forms.Button();
            this.FeedElephants = new System.Windows.Forms.Button();
            this.CreateMonkey = new System.Windows.Forms.Button();
            this.CreateLion = new System.Windows.Forms.Button();
            this.CreateElephant = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FeedAll
            // 
            this.FeedAll.Location = new System.Drawing.Point(12, 12);
            this.FeedAll.Name = "FeedAll";
            this.FeedAll.Size = new System.Drawing.Size(175, 54);
            this.FeedAll.TabIndex = 0;
            this.FeedAll.Text = "Feed all animals";
            this.FeedAll.UseVisualStyleBackColor = true;
            this.FeedAll.Click += new System.EventHandler(this.FeedAll_Click);
            // 
            // FeedMonkeys
            // 
            this.FeedMonkeys.Location = new System.Drawing.Point(193, 12);
            this.FeedMonkeys.Name = "FeedMonkeys";
            this.FeedMonkeys.Size = new System.Drawing.Size(175, 54);
            this.FeedMonkeys.TabIndex = 1;
            this.FeedMonkeys.Text = "Feed the monkeys";
            this.FeedMonkeys.UseVisualStyleBackColor = true;
            this.FeedMonkeys.Click += new System.EventHandler(this.FeedMonkeys_Click);
            // 
            // FeedLions
            // 
            this.FeedLions.Location = new System.Drawing.Point(374, 12);
            this.FeedLions.Name = "FeedLions";
            this.FeedLions.Size = new System.Drawing.Size(175, 54);
            this.FeedLions.TabIndex = 2;
            this.FeedLions.Text = "Feed the lions";
            this.FeedLions.UseVisualStyleBackColor = true;
            this.FeedLions.Click += new System.EventHandler(this.FeedLions_Click);
            // 
            // FeedElephants
            // 
            this.FeedElephants.Location = new System.Drawing.Point(555, 12);
            this.FeedElephants.Name = "FeedElephants";
            this.FeedElephants.Size = new System.Drawing.Size(175, 54);
            this.FeedElephants.TabIndex = 3;
            this.FeedElephants.Text = "Feed the elephants";
            this.FeedElephants.UseVisualStyleBackColor = true;
            this.FeedElephants.Click += new System.EventHandler(this.FeedElephants_Click);
            // 
            // CreateMonkey
            // 
            this.CreateMonkey.Location = new System.Drawing.Point(93, 72);
            this.CreateMonkey.Name = "CreateMonkey";
            this.CreateMonkey.Size = new System.Drawing.Size(184, 68);
            this.CreateMonkey.TabIndex = 4;
            this.CreateMonkey.Text = "Create monkey";
            this.CreateMonkey.UseVisualStyleBackColor = true;
            this.CreateMonkey.Click += new System.EventHandler(this.CreateMonkey_Click);
            // 
            // CreateLion
            // 
            this.CreateLion.Location = new System.Drawing.Point(283, 72);
            this.CreateLion.Name = "CreateLion";
            this.CreateLion.Size = new System.Drawing.Size(184, 68);
            this.CreateLion.TabIndex = 5;
            this.CreateLion.Text = "Create lion";
            this.CreateLion.UseVisualStyleBackColor = true;
            this.CreateLion.Click += new System.EventHandler(this.CreateLion_Click);
            // 
            // CreateElephant
            // 
            this.CreateElephant.Location = new System.Drawing.Point(473, 72);
            this.CreateElephant.Name = "CreateElephant";
            this.CreateElephant.Size = new System.Drawing.Size(184, 68);
            this.CreateElephant.TabIndex = 6;
            this.CreateElephant.Text = "Create elephant";
            this.CreateElephant.UseVisualStyleBackColor = true;
            this.CreateElephant.Click += new System.EventHandler(this.CreateElephant_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(102, 188);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(175, 212);
            this.listBox.TabIndex = 7;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(415, 188);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(242, 212);
            this.dataGridView.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 412);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.CreateElephant);
            this.Controls.Add(this.CreateLion);
            this.Controls.Add(this.CreateMonkey);
            this.Controls.Add(this.FeedElephants);
            this.Controls.Add(this.FeedLions);
            this.Controls.Add(this.FeedMonkeys);
            this.Controls.Add(this.FeedAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FeedAll;
        private System.Windows.Forms.Button FeedMonkeys;
        private System.Windows.Forms.Button FeedLions;
        private System.Windows.Forms.Button FeedElephants;
        private System.Windows.Forms.Button CreateMonkey;
        private System.Windows.Forms.Button CreateLion;
        private System.Windows.Forms.Button CreateElephant;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

