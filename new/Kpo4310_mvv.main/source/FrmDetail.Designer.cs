namespace Kpo4310.mvv.main.source
{
    partial class FrmelementaryParticle
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
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.textBoxCharge = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(124, 32);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(100, 20);
            this.txtboxName.TabIndex = 0;
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(124, 73);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(100, 20);
            this.textBoxGroup.TabIndex = 2;
            // 
            // textBoxCharge
            // 
            this.textBoxCharge.Location = new System.Drawing.Point(124, 117);
            this.textBoxCharge.Name = "textBoxCharge";
            this.textBoxCharge.Size = new System.Drawing.Size(100, 20);
            this.textBoxCharge.TabIndex = 3;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(124, 160);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeight.TabIndex = 4;
            // 
            // FrmelementaryParticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 261);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxCharge);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.txtboxName);
            this.Name = "FrmelementaryParticle";
            this.Text = "Частица";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.TextBox textBoxCharge;
        private System.Windows.Forms.TextBox textBoxWeight;
    }
}