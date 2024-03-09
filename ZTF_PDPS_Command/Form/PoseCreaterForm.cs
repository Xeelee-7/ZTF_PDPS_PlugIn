using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tecnomatix.Engineering;
using Tecnomatix.Engineering.Ui;


namespace ZTF_PDPS_Command
{
    public partial class PoseCreaterForm : TxForm
    {
        string deviceFullPath = null;
        public PoseCreaterForm()
        {
            InitializeComponent();
            checkBoxTypeA.Checked = true;
            checkBoxTypeB.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTypeA.Checked)
            {
                checkBoxTypeB.Checked = false;
            }
            else
            {
                checkBoxTypeB.Checked = true;
            }
        }

        private void checkBoxTypeB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTypeB.Checked)
            {
                checkBoxTypeA.Checked = false;
            }
            else
            {
                checkBoxTypeA.Checked = true;
            }
        }

        private void buttonCreat_Click(object sender, EventArgs e)
        {
            TxObjectList jointObjects = new TxObjectList();
            jointObjects = TxApplication.ActiveSelection.GetFilteredItems(new TxTypeFilter(typeof(TxDevice)));

            foreach (TxDevice jointObject in jointObjects)
            {

                if (CheckJointNumber(jointObject) == 1)
                {
                    try
                    {
                        deviceFullPath = (jointObject.StorageObject as TxLibraryStorage).FullPath;
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show($"Can not get the {jointObject.Name}'s path");
                    }

                    jointObject.SetModelingScope();
                    // Creat OPEN&CLOSE POSE                   
                    foreach (TxJoint joint in jointObject.Joints)
                    {
                        if (!joint.IsDependent)
                        {
                            if (!CheckIsAlreadyHasPose(jointObject, "OPEN"))
                            {
                                if (checkBoxTypeA.Checked)
                                {
                                    JointPoseCreat(jointObject, joint, "OPEN", joint.HardLimitsData.LowerHardLimit);
                                }
                                else
                                {
                                    JointPoseCreat(jointObject, joint, "OPEN", joint.HardLimitsData.UpperHardLimit);
                                }
                                
                            }
                            if (!CheckIsAlreadyHasPose(jointObject, "CLOSE"))
                            {
                                if (checkBoxTypeA.Checked)
                                {
                                    JointPoseCreat(jointObject, joint, "CLOSE", joint.HardLimitsData.UpperHardLimit);
                                }
                                else
                                {
                                    JointPoseCreat(jointObject, joint, "CLOSE", joint.HardLimitsData.LowerHardLimit);
                                }
                                
                            }
                        }
                    }
                    jointObject.EndModeling(deviceFullPath);
                }
                else
                {
                    MessageBox.Show($"{jointObject.Name}'s joint is more than one");
                }
            }
        }
        private int CheckJointNumber(TxDevice jointObject)
        {
            int jointNum = 0;
            foreach (TxJoint joint in jointObject.Joints)
            {
                if (!joint.IsDependent)
                {
                    jointNum++;
                }
            }
            return jointNum;
        }
        private bool CheckIsAlreadyHasPose(TxDevice jointObject, string poseName)

        {
            bool hasPoseNameValue = false;
            foreach (var pose in jointObject.PoseList)
            {
                if (pose.Name == poseName)
                {
                    hasPoseNameValue = true;
                }
            }
            return hasPoseNameValue;
        }
        private void JointPoseCreat(TxDevice jointObject, TxJoint joint, string name, double jointValue)
        {
            TxPoseData txPoseDataMin = new TxPoseData();
            txPoseDataMin.JointValues = new ArrayList() { jointValue };
            jointObject.CreatePose(new TxPoseCreationData(name, txPoseDataMin));
        }

        private void PoseCreaterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
