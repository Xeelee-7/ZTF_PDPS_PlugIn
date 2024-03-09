
namespace ZTF_PDPS_Command
{
    partial class lightSensorProperty
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelSensorName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txObjGridCtrlSensorCheckedWith = new Tecnomatix.Engineering.Ui.TxObjGridCtrl();
            this.txNumericEditBoxCtrlRange = new Tecnomatix.Engineering.Ui.TxNumericEditBoxCtrl();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxNormalFalseTrue = new System.Windows.Forms.CheckBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOK.Location = new System.Drawing.Point(396, 411);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(77, 33);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelSensorName
            // 
            this.labelSensorName.AutoSize = true;
            this.labelSensorName.Location = new System.Drawing.Point(21, 27);
            this.labelSensorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSensorName.Name = "labelSensorName";
            this.labelSensorName.Size = new System.Drawing.Size(47, 15);
            this.labelSensorName.TabIndex = 11;
            this.labelSensorName.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(79, 26);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(565, 25);
            this.textBoxName.TabIndex = 12;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Location = new System.Drawing.Point(484, 411);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(77, 33);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.txObjGridCtrlSensorCheckedWith);
            this.groupBox.Font = new System.Drawing.Font("宋体", 7.666667F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox.Location = new System.Drawing.Point(9, 106);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox.Size = new System.Drawing.Size(641, 271);
            this.groupBox.TabIndex = 14;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Check Interfercence With:";
            // 
            // txObjGridCtrlSensorCheckedWith
            // 
            this.txObjGridCtrlSensorCheckedWith.AllowDrop = true;
            this.txObjGridCtrlSensorCheckedWith.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txObjGridCtrlSensorCheckedWith.AutoScroll = true;
            this.txObjGridCtrlSensorCheckedWith.AutoSize = true;
            this.txObjGridCtrlSensorCheckedWith.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txObjGridCtrlSensorCheckedWith.ChangeGeneralSelection = false;
            this.txObjGridCtrlSensorCheckedWith.CurrentRow = -1;
            this.txObjGridCtrlSensorCheckedWith.EnableMultipleSelection = true;
            this.txObjGridCtrlSensorCheckedWith.EnableRecurringObjects = false;
            this.txObjGridCtrlSensorCheckedWith.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txObjGridCtrlSensorCheckedWith.ListenToPick = false;
            this.txObjGridCtrlSensorCheckedWith.Location = new System.Drawing.Point(4, 17);
            this.txObjGridCtrlSensorCheckedWith.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txObjGridCtrlSensorCheckedWith.Name = "txObjGridCtrlSensorCheckedWith";
            this.txObjGridCtrlSensorCheckedWith.PickLevel = Tecnomatix.Engineering.Ui.TxPickLevel.Component;
            this.txObjGridCtrlSensorCheckedWith.ReadOnly = false;
            this.txObjGridCtrlSensorCheckedWith.Size = new System.Drawing.Size(633, 245);
            this.txObjGridCtrlSensorCheckedWith.TabIndex = 10;
            this.txObjGridCtrlSensorCheckedWith.ValidatorType = Tecnomatix.Engineering.Ui.TxValidatorType.AnyLocatableObject;
            this.txObjGridCtrlSensorCheckedWith.SelectionChanged += new Tecnomatix.Engineering.Ui.TxObjGridCtrl_SelectionChangedEventHandler(this.txObjGridCtrlSensorCheckedWith_SelectcionChanged);
            // 
            // txNumericEditBoxCtrlRange
            // 
            this.txNumericEditBoxCtrlRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txNumericEditBoxCtrlRange.AutoSize = true;
            this.txNumericEditBoxCtrlRange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txNumericEditBoxCtrlRange.Location = new System.Drawing.Point(455, 64);
            this.txNumericEditBoxCtrlRange.LowerBound = -7.92281525142643E+18D;
            this.txNumericEditBoxCtrlRange.Margin = new System.Windows.Forms.Padding(2);
            this.txNumericEditBoxCtrlRange.Name = "txNumericEditBoxCtrlRange";
            this.txNumericEditBoxCtrlRange.ReadOnly = false;
            this.txNumericEditBoxCtrlRange.Size = new System.Drawing.Size(106, 21);
            this.txNumericEditBoxCtrlRange.StepSize = 1D;
            this.txNumericEditBoxCtrlRange.TabIndex = 15;
            this.txNumericEditBoxCtrlRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txNumericEditBoxCtrlRange.ThousandsSeparator = false;
            this.txNumericEditBoxCtrlRange.UpperBound = 7.92281525142643E+18D;
            this.txNumericEditBoxCtrlRange.UseDecimalPlacesFromOption = true;
            this.txNumericEditBoxCtrlRange.Value = 0D;
            this.txNumericEditBoxCtrlRange.ValueType = Tecnomatix.Engineering.Ui.TxNumericEditValueType.Linear;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(568, 64);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(74, 21);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "CurrentCheckRange:";
            // 
            // checkBoxNormalFalseTrue
            // 
            this.checkBoxNormalFalseTrue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxNormalFalseTrue.AutoSize = true;
            this.checkBoxNormalFalseTrue.Checked = true;
            this.checkBoxNormalFalseTrue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNormalFalseTrue.Location = new System.Drawing.Point(13, 379);
            this.checkBoxNormalFalseTrue.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxNormalFalseTrue.Name = "checkBoxNormalFalseTrue";
            this.checkBoxNormalFalseTrue.Size = new System.Drawing.Size(181, 19);
            this.checkBoxNormalFalseTrue.TabIndex = 18;
            this.checkBoxNormalFalseTrue.Text = "Normal False Signal";
            this.checkBoxNormalFalseTrue.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Location = new System.Drawing.Point(573, 411);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(77, 33);
            this.buttonClose.TabIndex = 19;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // lightSensorProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 474);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.checkBoxNormalFalseTrue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.txNumericEditBoxCtrlRange);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSensorName);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(408, 521);
            this.Name = "lightSensorProperty";
            this.Text = "lightSensorProperty";
            this.Load += new System.EventHandler(this.lightSensorProperty_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelSensorName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox;
        private Tecnomatix.Engineering.Ui.TxNumericEditBoxCtrl txNumericEditBoxCtrlRange;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxNormalFalseTrue;
        private System.Windows.Forms.Button buttonClose;
        private Tecnomatix.Engineering.Ui.TxObjGridCtrl txObjGridCtrlSensorCheckedWith;
    }
}