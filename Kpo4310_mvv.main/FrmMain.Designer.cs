namespace Kpo4310.mvv.main
{
    partial class FrmMain
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
            this.MMenu = new System.Windows.Forms.MenuStrip();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnelementaryParticle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpenelementaryParticle = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dgvelementaryParticles = new System.Windows.Forms.DataGridView();
            this.param1 = new System.Windows.Forms.TextBox();
            this.param2 = new System.Windows.Forms.TextBox();
            this.MMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvelementaryParticles)).BeginInit();
            this.SuspendLayout();
            // 
            // MMenu
            // 
            this.MMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile,
            this.mnelementaryParticle});
            this.MMenu.Location = new System.Drawing.Point(0, 0);
            this.MMenu.Name = "MMenu";
            this.MMenu.Size = new System.Drawing.Size(546, 24);
            this.MMenu.TabIndex = 0;
            this.MMenu.Text = "menuStrip1";
            // 
            // mmFile
            // 
            this.mmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnExit,
            this.mnOpen,
            this.saveFile});
            this.mmFile.Name = "mmFile";
            this.mmFile.Size = new System.Drawing.Size(57, 20);
            this.mmFile.Text = "1&.Файл";
            this.mmFile.Click += new System.EventHandler(this.mmFile_Click);
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(152, 22);
            this.mnExit.Text = "Выход";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // mnOpen
            // 
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.Size = new System.Drawing.Size(152, 22);
            this.mnOpen.Text = "Открыть";
            this.mnOpen.Click += new System.EventHandler(this.mnOpen_Click);
            // 
            // saveFile
            // 
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(152, 22);
            this.saveFile.Text = "Сохранить";
            this.saveFile.Click += new System.EventHandler(this.saveToFile_Click);
            // 
            // mnelementaryParticle
            // 
            this.mnelementaryParticle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnOpenelementaryParticle});
            this.mnelementaryParticle.Name = "mnelementaryParticle";
            this.mnelementaryParticle.Size = new System.Drawing.Size(76, 20);
            this.mnelementaryParticle.Text = "2&.Частицы";
            // 
            // mnOpenelementaryParticle
            // 
            this.mnOpenelementaryParticle.Name = "mnOpenelementaryParticle";
            this.mnOpenelementaryParticle.Size = new System.Drawing.Size(215, 22);
            this.mnOpenelementaryParticle.Text = "Открыть данные частицы";
            this.mnOpenelementaryParticle.Click += new System.EventHandler(this.mnOpenelementaryParticle_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(546, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "SStatus";
            // 
            // dgvelementaryParticles
            // 
            this.dgvelementaryParticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvelementaryParticles.Location = new System.Drawing.Point(68, 58);
            this.dgvelementaryParticles.Name = "dgvelementaryParticles";
            this.dgvelementaryParticles.Size = new System.Drawing.Size(240, 150);
            this.dgvelementaryParticles.TabIndex = 2;
            // 
            // param1
            // 
            this.param1.Location = new System.Drawing.Point(386, 58);
            this.param1.Name = "param1";
            this.param1.Size = new System.Drawing.Size(100, 20);
            this.param1.TabIndex = 3;
            // 
            // param2
            // 
            this.param2.Location = new System.Drawing.Point(386, 188);
            this.param2.Name = "param2";
            this.param2.Size = new System.Drawing.Size(100, 20);
            this.param2.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 261);
            this.Controls.Add(this.param2);
            this.Controls.Add(this.param1);
            this.Controls.Add(this.dgvelementaryParticles);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MMenu);
            this.Name = "FrmMain";
            this.Text = "KPO4310:Maryina";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MMenu.ResumeLayout(false);
            this.MMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvelementaryParticles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MMenu;
        private System.Windows.Forms.ToolStripMenuItem mmFile;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.ToolStripMenuItem mnOpen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dgvelementaryParticles;
        private System.Windows.Forms.ToolStripMenuItem mnelementaryParticle;
        private System.Windows.Forms.ToolStripMenuItem mnOpenelementaryParticle;
        private System.Windows.Forms.TextBox param1;
        private System.Windows.Forms.TextBox param2;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
    }
}

