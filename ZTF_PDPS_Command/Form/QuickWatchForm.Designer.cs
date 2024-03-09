
namespace ZTF_PDPS_Command
{
    partial class QuickWatchForm
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
            this.signalValuelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signalValuelabel
            // 
            this.signalValuelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signalValuelabel.AutoSize = true;
            this.signalValuelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.signalValuelabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.signalValuelabel.Location = new System.Drawing.Point(1, 0);
            this.signalValuelabel.MaximumSize = new System.Drawing.Size(120, 30);
            this.signalValuelabel.MinimumSize = new System.Drawing.Size(120, 30);
            this.signalValuelabel.Name = "signalValuelabel";
            this.signalValuelabel.Size = new System.Drawing.Size(120, 30);
            this.signalValuelabel.TabIndex = 0;
            this.signalValuelabel.Text = "SignalValue";
            this.signalValuelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuickWatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(120, 30);
            this.ControlBox = false;
            this.Controls.Add(this.signalValuelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(120, 30);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(120, 30);
            this.Name = "QuickWatchForm";
            this.SemiModal = false;
            this.ShowIcon = false;
            this.Text = "QuickWatchForm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuickWatchForm_FormClosing);
            this.Load += new System.EventHandler(this.QuickWatchForm_Load);
            this.Shown += new System.EventHandler(this.QuickWatchForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signalValuelabel;
    }
}