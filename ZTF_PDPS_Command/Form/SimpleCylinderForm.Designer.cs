namespace ZTF_PDPS_Command
{
    partial class SimpleCylinderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleCylinderForm));
            this._pickCylinder = new Tecnomatix.Engineering.Ui.TxObjEditBoxCtrl();
            this._pickFixedLinkElement = new Tecnomatix.Engineering.Ui.TxObjGridCtrl();
            this._pickAxisFrame = new Tecnomatix.Engineering.Ui.TxFrameEditBoxCtrl();
            this._selectCylinderType = new System.Windows.Forms.ComboBox();
            this._selectAxisDirection = new System.Windows.Forms.ComboBox();
            this._jointLowerLimtValue = new System.Windows.Forms.TextBox();
            this._jointUpperLimtValue = new System.Windows.Forms.TextBox();
            this._reverseDirection = new System.Windows.Forms.CheckBox();
            this._creatKinmatic = new System.Windows.Forms.Button();
            this._selectPoseType = new System.Windows.Forms.ComboBox();
            this._setModeling = new System.Windows.Forms.Button();
            this._endModeling = new System.Windows.Forms.Button();
            this._pickMoveLinkElemet = new Tecnomatix.Engineering.Ui.TxObjGridCtrl();
            this.SuspendLayout();
            // 
            // _pickCylinder
            // 
            this._pickCylinder.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._pickCylinder.KeepFaceEmphasizedWhenControlIsNotFocused = true;
            this._pickCylinder.ListenToPick = true;
            this._pickCylinder.Location = new System.Drawing.Point(14, 12);
            this._pickCylinder.Name = "_pickCylinder";
            this._pickCylinder.Object = null;
            this._pickCylinder.PickAndClear = false;
            this._pickCylinder.PickLevel = Tecnomatix.Engineering.Ui.TxPickLevel.Component;
            this._pickCylinder.PickOnly = false;
            this._pickCylinder.ReadOnly = false;
            this._pickCylinder.Size = new System.Drawing.Size(343, 26);
            this._pickCylinder.TabIndex = 0;
            this._pickCylinder.ValidatorType = Tecnomatix.Engineering.Ui.TxValidatorType.AnyLocatableObject;
            this._pickCylinder.Picked += new Tecnomatix.Engineering.Ui.TxObjEditBoxCtrl_PickedEventHandler(this._pickCylinder_Picked);
            // 
            // _pickFixedLinkElement
            // 
            this._pickFixedLinkElement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pickFixedLinkElement.ChangeGeneralSelection = false;
            this._pickFixedLinkElement.CurrentRow = -1;
            this._pickFixedLinkElement.EnableMultipleSelection = true;
            this._pickFixedLinkElement.EnableRecurringObjects = false;
            this._pickFixedLinkElement.ListenToPick = false;
            this._pickFixedLinkElement.Location = new System.Drawing.Point(10, 115);
            this._pickFixedLinkElement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._pickFixedLinkElement.Name = "_pickFixedLinkElement";
            this._pickFixedLinkElement.PickLevel = Tecnomatix.Engineering.Ui.TxPickLevel.Entity;
            this._pickFixedLinkElement.ReadOnly = false;
            this._pickFixedLinkElement.Size = new System.Drawing.Size(213, 184);
            this._pickFixedLinkElement.TabIndex = 2;
            this._pickFixedLinkElement.ValidatorType = Tecnomatix.Engineering.Ui.TxValidatorType.AnyLocatableObject;
            // 
            // _pickAxisFrame
            // 
            this._pickAxisFrame.EnableRelativeToWorkingFrameCoordinates = true;
            this._pickAxisFrame.ListenToPick = true;
            this._pickAxisFrame.Location = new System.Drawing.Point(14, 316);
            this._pickAxisFrame.Name = "_pickAxisFrame";
            this._pickAxisFrame.PickLevel = Tecnomatix.Engineering.Ui.TxPickLevel.Entity;
            this._pickAxisFrame.Size = new System.Drawing.Size(187, 24);
            this._pickAxisFrame.TabIndex = 4;
            this._pickAxisFrame.ValidatorType = Tecnomatix.Engineering.Ui.TxValidatorType.AnyLocatableObject;
            this._pickAxisFrame.VisualizePickedFrameInGraphicViewer = true;
            // 
            // _selectCylinderType
            // 
            this._selectCylinderType.FormattingEnabled = true;
            this._selectCylinderType.Items.AddRange(new object[] {
            "Prismastic",
            "Rotate"});
            this._selectCylinderType.Location = new System.Drawing.Point(14, 67);
            this._selectCylinderType.Name = "_selectCylinderType";
            this._selectCylinderType.Size = new System.Drawing.Size(343, 23);
            this._selectCylinderType.TabIndex = 1;
            // 
            // _selectAxisDirection
            // 
            this._selectAxisDirection.FormattingEnabled = true;
            this._selectAxisDirection.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this._selectAxisDirection.Location = new System.Drawing.Point(10, 370);
            this._selectAxisDirection.Name = "_selectAxisDirection";
            this._selectAxisDirection.Size = new System.Drawing.Size(194, 23);
            this._selectAxisDirection.TabIndex = 5;
            // 
            // _jointLowerLimtValue
            // 
            this._jointLowerLimtValue.Location = new System.Drawing.Point(15, 433);
            this._jointLowerLimtValue.Name = "_jointLowerLimtValue";
            this._jointLowerLimtValue.Size = new System.Drawing.Size(100, 25);
            this._jointLowerLimtValue.TabIndex = 7;
            // 
            // _jointUpperLimtValue
            // 
            this._jointUpperLimtValue.Location = new System.Drawing.Point(158, 433);
            this._jointUpperLimtValue.Name = "_jointUpperLimtValue";
            this._jointUpperLimtValue.Size = new System.Drawing.Size(100, 25);
            this._jointUpperLimtValue.TabIndex = 8;
            // 
            // _reverseDirection
            // 
            this._reverseDirection.AutoSize = true;
            this._reverseDirection.Location = new System.Drawing.Point(236, 373);
            this._reverseDirection.Name = "_reverseDirection";
            this._reverseDirection.Size = new System.Drawing.Size(85, 19);
            this._reverseDirection.TabIndex = 6;
            this._reverseDirection.Text = "Reverse";
            this._reverseDirection.UseVisualStyleBackColor = true;
            // 
            // _creatKinmatic
            // 
            this._creatKinmatic.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._creatKinmatic.Location = new System.Drawing.Point(379, 545);
            this._creatKinmatic.Name = "_creatKinmatic";
            this._creatKinmatic.Size = new System.Drawing.Size(80, 29);
            this._creatKinmatic.TabIndex = 10;
            this._creatKinmatic.Text = "Creat";
            this._creatKinmatic.UseVisualStyleBackColor = true;
            this._creatKinmatic.Click += new System.EventHandler(this._creatKinmatic_Click);
            // 
            // _selectPoseType
            // 
            this._selectPoseType.FormattingEnabled = true;
            this._selectPoseType.Items.AddRange(new object[] {
            "Upper Limit is Close",
            "Lower Limit is Close"});
            this._selectPoseType.Location = new System.Drawing.Point(15, 496);
            this._selectPoseType.Name = "_selectPoseType";
            this._selectPoseType.Size = new System.Drawing.Size(243, 23);
            this._selectPoseType.TabIndex = 9;
            // 
            // _setModeling
            // 
            this._setModeling.Location = new System.Drawing.Point(405, 29);
            this._setModeling.Name = "_setModeling";
            this._setModeling.Size = new System.Drawing.Size(105, 50);
            this._setModeling.TabIndex = 11;
            this._setModeling.Text = "Set Modeling";
            this._setModeling.UseVisualStyleBackColor = true;
            // 
            // _endModeling
            // 
            this._endModeling.Location = new System.Drawing.Point(525, 29);
            this._endModeling.Name = "_endModeling";
            this._endModeling.Size = new System.Drawing.Size(105, 50);
            this._endModeling.TabIndex = 12;
            this._endModeling.Text = "End Modeling";
            this._endModeling.UseVisualStyleBackColor = true;
            this._endModeling.Click += new System.EventHandler(this._endModeling_Click);
            // 
            // _pickMoveLinkElemet
            // 
            this._pickMoveLinkElemet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pickMoveLinkElemet.ChangeGeneralSelection = false;
            this._pickMoveLinkElemet.CurrentRow = -1;
            this._pickMoveLinkElemet.EnableMultipleSelection = true;
            this._pickMoveLinkElemet.EnableRecurringObjects = false;
            this._pickMoveLinkElemet.ListenToPick = false;
            this._pickMoveLinkElemet.Location = new System.Drawing.Point(236, 115);
            this._pickMoveLinkElemet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._pickMoveLinkElemet.Name = "_pickMoveLinkElemet";
            this._pickMoveLinkElemet.PickLevel = Tecnomatix.Engineering.Ui.TxPickLevel.Entity;
            this._pickMoveLinkElemet.ReadOnly = false;
            this._pickMoveLinkElemet.Size = new System.Drawing.Size(213, 184);
            this._pickMoveLinkElemet.TabIndex = 3;
            this._pickMoveLinkElemet.ValidatorType = Tecnomatix.Engineering.Ui.TxValidatorType.AnyLocatableObject;
            // 
            // SimpleCylinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 586);
            this.Controls.Add(this._pickMoveLinkElemet);
            this.Controls.Add(this._endModeling);
            this.Controls.Add(this._setModeling);
            this.Controls.Add(this._selectPoseType);
            this.Controls.Add(this._creatKinmatic);
            this.Controls.Add(this._reverseDirection);
            this.Controls.Add(this._jointUpperLimtValue);
            this.Controls.Add(this._jointLowerLimtValue);
            this.Controls.Add(this._selectAxisDirection);
            this.Controls.Add(this._selectCylinderType);
            this.Controls.Add(this._pickAxisFrame);
            this.Controls.Add(this._pickFixedLinkElement);
            this.Controls.Add(this._pickCylinder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimpleCylinderForm";
            this.SemiModal = false;
            this.Text = "SimpleCylinderForm";
            this.Load += new System.EventHandler(this.SimpleCylinderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tecnomatix.Engineering.Ui.TxObjEditBoxCtrl _pickCylinder;
        private Tecnomatix.Engineering.Ui.TxObjGridCtrl _pickFixedLinkElement;
        private Tecnomatix.Engineering.Ui.TxFrameEditBoxCtrl _pickAxisFrame;
        private System.Windows.Forms.ComboBox _selectCylinderType;
        private System.Windows.Forms.ComboBox _selectAxisDirection;
        private System.Windows.Forms.TextBox _jointLowerLimtValue;
        private System.Windows.Forms.TextBox _jointUpperLimtValue;
        private System.Windows.Forms.CheckBox _reverseDirection;
        private System.Windows.Forms.Button _creatKinmatic;
        private System.Windows.Forms.ComboBox _selectPoseType;
        private System.Windows.Forms.Button _setModeling;
        private System.Windows.Forms.Button _endModeling;
        private Tecnomatix.Engineering.Ui.TxObjGridCtrl _pickMoveLinkElemet;
    }
}