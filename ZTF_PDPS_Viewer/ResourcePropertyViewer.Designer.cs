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
            this.My = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectLink = new Tecnomatix.Engineering.Ui.TxObjEditBoxCtrl();
            this.My.SuspendLayout();
            this.SuspendLayout();
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
            // selectLink
            // 
            this.selectLink.KeepFaceEmphasizedWhenControlIsNotFocused = true;
            this.selectLink.ListenToPick = true;
            this.selectLink.Location = new System.Drawing.Point(60, 75);
            this.selectLink.Name = "selectLink";
            this.selectLink.Object = null;
            this.selectLink.PickAndClear = false;
            this.selectLink.PickLevel = Tecnomatix.Engineering.Ui.TxPickLevel.Component;
            this.selectLink.PickOnly = false;
            this.selectLink.ReadOnly = false;
            this.selectLink.Size = new System.Drawing.Size(271, 28);
            this.selectLink.TabIndex = 4;
            this.selectLink.ValidatorType = Tecnomatix.Engineering.Ui.TxValidatorType.AnyLocatableObject;
            // 
            // ResourcePropertyViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ContextMenuStrip = this.My;
            this.Controls.Add(this.selectLink);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "ResourcePropertyViewer";
            this.Size = new System.Drawing.Size(496, 343);
            this.My.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip My;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private Tecnomatix.Engineering.Ui.TxObjEditBoxCtrl selectLink;
    }
}
