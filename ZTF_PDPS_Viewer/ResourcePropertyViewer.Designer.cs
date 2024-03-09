namespace ZTF_PDPS_Viewer
{
    partial class ResourcePropertyViewer
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxResourceType = new System.Windows.Forms.TextBox();
            this.labelResourceType = new System.Windows.Forms.Label();
            this.labelABSLocation = new System.Windows.Forms.Label();
            this.textBoxABSLocation = new System.Windows.Forms.TextBox();
            this.My = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.My.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxResourceType
            // 
            this.textBoxResourceType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResourceType.Location = new System.Drawing.Point(177, 66);
            this.textBoxResourceType.Name = "textBoxResourceType";
            this.textBoxResourceType.ReadOnly = true;
            this.textBoxResourceType.Size = new System.Drawing.Size(283, 25);
            this.textBoxResourceType.TabIndex = 0;
            // 
            // labelResourceType
            // 
            this.labelResourceType.AutoSize = true;
            this.labelResourceType.Location = new System.Drawing.Point(20, 69);
            this.labelResourceType.Name = "labelResourceType";
            this.labelResourceType.Size = new System.Drawing.Size(111, 15);
            this.labelResourceType.TabIndex = 1;
            this.labelResourceType.Text = "ResourceType:";
            // 
            // labelABSLocation
            // 
            this.labelABSLocation.AutoSize = true;
            this.labelABSLocation.Location = new System.Drawing.Point(20, 128);
            this.labelABSLocation.Name = "labelABSLocation";
            this.labelABSLocation.Size = new System.Drawing.Size(151, 15);
            this.labelABSLocation.TabIndex = 2;
            this.labelABSLocation.Text = "AbsoluteLocation :";
            // 
            // textBoxABSLocation
            // 
            this.textBoxABSLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxABSLocation.Location = new System.Drawing.Point(177, 128);
            this.textBoxABSLocation.Multiline = true;
            this.textBoxABSLocation.Name = "textBoxABSLocation";
            this.textBoxABSLocation.ReadOnly = true;
            this.textBoxABSLocation.Size = new System.Drawing.Size(283, 64);
            this.textBoxABSLocation.TabIndex = 3;
            // 
            // My
            // 
            this.My.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.My.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.My.Name = "My";
            this.My.Size = new System.Drawing.Size(106, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(105, 24);
            this.toolStripMenuItem1.Text = "122";
            // 
            // ResourcePropertyViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ContextMenuStrip = this.My;
            this.Controls.Add(this.textBoxABSLocation);
            this.Controls.Add(this.labelABSLocation);
            this.Controls.Add(this.labelResourceType);
            this.Controls.Add(this.textBoxResourceType);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "ResourcePropertyViewer";
            this.Size = new System.Drawing.Size(496, 246);
            this.My.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResourceType;
        private System.Windows.Forms.Label labelResourceType;
        private System.Windows.Forms.Label labelABSLocation;
        private System.Windows.Forms.TextBox textBoxABSLocation;
        private System.Windows.Forms.ContextMenuStrip My;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
