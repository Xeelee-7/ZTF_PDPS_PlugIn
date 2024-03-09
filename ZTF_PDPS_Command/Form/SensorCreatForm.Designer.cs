
namespace ZTF_PDPS_Command
{
    partial class CreatLightSensor
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
            this.CreatNewSensor = new System.Windows.Forms.Button();
            this.pickedFrame = new Tecnomatix.Engineering.Ui.TxFrameEditBoxCtrl();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SensorCheckLength = new Tecnomatix.Engineering.Ui.TxNumericEditBoxCtrl();
            this.SensorCheckObjects = new Tecnomatix.Engineering.Ui.TxObjGridCtrl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NormallyFalse = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreatNewSensor
            // 
            this.CreatNewSensor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatNewSensor.Location = new System.Drawing.Point(304, 772);
            this.CreatNewSensor.Name = "CreatNewSensor";
            this.CreatNewSensor.Size = new System.Drawing.Size(132, 45);
            this.CreatNewSensor.TabIndex = 1;
            this.CreatNewSensor.Text = "Creat";
            this.CreatNewSensor.UseVisualStyleBackColor = true;
            this.CreatNewSensor.Click += new System.EventHandler(this.CreatNewSensor_Click);
            // 
            // pickedFrame
            // 
            this.pickedFrame.EnableRelativeToWorkingFrameCoordinates = false;
            this.pickedFrame.ListenToPick = true;
            this.pickedFrame.Location = new System.Drawing.Point(163, 333);
            this.pickedFrame.Name = "pickedFrame";
            this.pickedFrame.PickLevel = Tecnomatix.Engineering.Ui.TxPickLevel.Application;
            this.pickedFrame.Size = new System.Drawing.Size(280, 42);
            this.pickedFrame.TabIndex = 4;
            this.pickedFrame.ValidatorType = Tecnomatix.Engineering.Ui.TxValidatorType.AnyLocatableObject;
            this.pickedFrame.VisualizePickedFrameInGraphicViewer = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(27, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pick Point";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(114, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 35);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(27, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(34, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Beam Parameters";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SensorCheckLength);
            this.panel1.Location = new System.Drawing.Point(31, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 86);
            this.panel1.TabIndex = 9;
            // 
            // SensorCheckLength
            // 
            this.SensorCheckLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SensorCheckLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SensorCheckLength.Location = new System.Drawing.Point(160, 32);
            this.SensorCheckLength.LowerBound = -7.92281525142643E+18D;
            this.SensorCheckLength.Name = "SensorCheckLength";
            this.SensorCheckLength.ReadOnly = false;
            this.SensorCheckLength.Size = new System.Drawing.Size(247, 36);
            this.SensorCheckLength.StepSize = 1D;
            this.SensorCheckLength.TabIndex = 10;
            this.SensorCheckLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SensorCheckLength.ThousandsSeparator = false;
            this.SensorCheckLength.UpperBound = 7.92281525142643E+18D;
            this.SensorCheckLength.UseDecimalPlacesFromOption = true;
            this.SensorCheckLength.Value = 50D;
            this.SensorCheckLength.ValueType = Tecnomatix.Engineering.Ui.TxNumericEditValueType.Linear;
            // 
            // SensorCheckObjects
            // 
            this.SensorCheckObjects.AllowDrop = true;
            this.SensorCheckObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SensorCheckObjects.AutoScroll = true;
            this.SensorCheckObjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SensorCheckObjects.ChangeGeneralSelection = false;
            this.SensorCheckObjects.CurrentRow = -1;
            this.SensorCheckObjects.EnableMultipleSelection = true;
            this.SensorCheckObjects.EnableRecurringObjects = false;
            this.SensorCheckObjects.ListenToPick = false;
            this.SensorCheckObjects.Location = new System.Drawing.Point(19, 37);
            this.SensorCheckObjects.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SensorCheckObjects.Name = "SensorCheckObjects";
            this.SensorCheckObjects.PickLevel = Tecnomatix.Engineering.Ui.TxPickLevel.Component;
            this.SensorCheckObjects.ReadOnly = false;
            this.SensorCheckObjects.Size = new System.Drawing.Size(360, 202);
            this.SensorCheckObjects.TabIndex = 10;
            this.SensorCheckObjects.ValidatorType = Tecnomatix.Engineering.Ui.TxValidatorType.AnyLocatableObject;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.SensorCheckObjects);
            this.panel2.Location = new System.Drawing.Point(31, 471);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 256);
            this.panel2.TabIndex = 11;
            // 
            // NormallyFalse
            // 
            this.NormallyFalse.AutoSize = true;
            this.NormallyFalse.Location = new System.Drawing.Point(31, 409);
            this.NormallyFalse.Name = "NormallyFalse";
            this.NormallyFalse.Size = new System.Drawing.Size(294, 28);
            this.NormallyFalse.TabIndex = 12;
            this.NormallyFalse.Text = "Normally False Signal";
            this.NormallyFalse.UseVisualStyleBackColor = true;
            // 
            // CreatLightSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(474, 829);
            this.Controls.Add(this.NormallyFalse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pickedFrame);
            this.Controls.Add(this.CreatNewSensor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(500, 900);
            this.Name = "CreatLightSensor";
            this.Text = "CreatLightSensor";
            this.Load += new System.EventHandler(this.SensorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreatNewSensor;
        private Tecnomatix.Engineering.Ui.TxFrameEditBoxCtrl pickedFrame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Tecnomatix.Engineering.Ui.TxNumericEditBoxCtrl SensorCheckLength;
        private Tecnomatix.Engineering.Ui.TxObjGridCtrl SensorCheckObjects;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox NormallyFalse;
    }
}