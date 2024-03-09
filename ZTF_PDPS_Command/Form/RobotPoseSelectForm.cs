using System;
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
    public partial class RobotPoseSelectForm : TxForm
    {
        TxObjectList txRobots;
        TxTypeFilter txTypeFilterRobot;
        public RobotPoseSelectForm()
        {
            InitializeComponent();
            SemiModal = false;
            
        }

        private void buttonMoveToPose_Click(object sender, EventArgs e)
        {
            listBoxLog.Items.Clear();
            if (textBoxPoseName.Text!=String.Empty)
            {
                foreach (var robot in txRobots)
                {
                    bool getPose = false;
                    TxRobot txRobot = robot as TxRobot;
                    foreach (var txRobotPose in txRobot.PoseList)
                    {
                        if (txRobotPose.Name == textBoxPoseName.Text)
                        {
                            txRobot.CurrentPose = ((TxPose)txRobotPose).PoseData;
                            getPose = true;
                        }
                    }
                    if (!getPose)
                    {
                       // TxMessageBox.Show(($"机器人：{robot.Name} 不存在POSE:{textBoxPoseName.Text}"),"Waring",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        listBoxLog.Items.Add($"机器人：{robot.Name} 不存在POSE:{textBoxPoseName.Text}");
                    }
                }
            }
            else
            {
                // TxMessageBox.Show("请输入一个POSE名称", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listBoxLog.Items.Add("请输入一个POSE名称");
            }
            if (listBoxLog.Items.Count<1)
            {
                listBoxLog.Items.Add("机器人POSE跳转完成");
            }
            TxApplication.RefreshDisplay();
        }

        private void RobotPoseSelectForm_Load(object sender, EventArgs e)
        {
            txTypeFilterRobot = new TxTypeFilter(typeof(TxRobot));
            txRobots = TxApplication.ActiveDocument.PhysicalRoot.GetAllDescendants(txTypeFilterRobot);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
