
namespace ZTF_PDPS_Command
{
    partial class PoseCreaterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoseCreaterForm));
            this.buttonCreat = new System.Windows.Forms.Button();
            this.checkBoxTypeA = new System.Windows.Forms.CheckBox();
            this.checkBoxTypeB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonCreat
            // 
            this.buttonCreat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreat.Location = new System.Drawing.Point(280, 116);
            this.buttonCreat.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreat.Name = "buttonCreat";
            this.buttonCreat.Size = new System.Drawing.Size(74, 27);
            this.buttonCreat.TabIndex = 0;
            this.buttonCreat.Text = "Creat";
            this.buttonCreat.UseVisualStyleBackColor = true;
            this.buttonCreat.Click += new System.EventHandler(this.buttonCreat_Click);
            // 
            // checkBoxTypeA
            // 
            this.checkBoxTypeA.AutoSize = true;
            this.checkBoxTypeA.Checked = true;
            this.checkBoxTypeA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTypeA.Location = new System.Drawing.Point(47, 34);
            this.checkBoxTypeA.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxTypeA.Name = "checkBoxTypeA";
            this.checkBoxTypeA.Size = new System.Drawing.Size(125, 19);
            this.checkBoxTypeA.TabIndex = 1;
            this.checkBoxTypeA.Text = "OPEN VALUE 0";
            this.checkBoxTypeA.UseVisualStyleBackColor = true;
            this.checkBoxTypeA.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxTypeB
            // 
            this.checkBoxTypeB.AutoSize = true;
            this.checkBoxTypeB.Location = new System.Drawing.Point(47, 65);
            this.checkBoxTypeB.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxTypeB.Name = "checkBoxTypeB";
            this.checkBoxTypeB.Size = new System.Drawing.Size(133, 19);
            this.checkBoxTypeB.TabIndex = 2;
            this.checkBoxTypeB.Text = "CLOSE VALUE 0";
            this.checkBoxTypeB.UseVisualStyleBackColor = true;
            this.checkBoxTypeB.CheckedChanged += new System.EventHandler(this.checkBoxTypeB_CheckedChanged);
            // 
            // PoseCreaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 149);
            this.Controls.Add(this.checkBoxTypeB);
            this.Controls.Add(this.checkBoxTypeA);
            this.Controls.Add(this.buttonCreat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PoseCreaterForm";
            this.Text = "PoseCreatForm";
            this.Load += new System.EventHandler(this.PoseCreaterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreat;
        private System.Windows.Forms.CheckBox checkBoxTypeA;
        private System.Windows.Forms.CheckBox checkBoxTypeB;
    }
}