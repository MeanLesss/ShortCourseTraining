namespace ShortCourseTraining.UserControls.DisplayControls
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutStatic = new System.Windows.Forms.FlowLayoutPanel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // flowLayoutStatic
            // 
            this.flowLayoutStatic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutStatic.AutoSize = true;
            this.flowLayoutStatic.Location = new System.Drawing.Point(104, 40);
            this.flowLayoutStatic.Name = "flowLayoutStatic";
            this.flowLayoutStatic.Size = new System.Drawing.Size(1371, 164);
            this.flowLayoutStatic.TabIndex = 1;
            // 
            // panelInfo
            // 
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.Location = new System.Drawing.Point(0, 253);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1523, 693);
            this.panelInfo.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.flowLayoutStatic);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1523, 946);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutStatic;
        private System.Windows.Forms.Panel panelInfo;
    }
}
