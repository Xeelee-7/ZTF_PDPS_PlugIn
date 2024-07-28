using EngineeringInternalExtension;
using EngineeringInternalExtension.ModelObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using Tecnomatix.Engineering;
using Tecnomatix.Engineering.DataTypes;
using Tecnomatix.Engineering.Plc;
using Tecnomatix.Engineering.Ui;

namespace ZTF_PDPS_Command
{
    #region Robot
    public class RobotToPose : TxButtonCommand
    {
        public override string Category => "ZTFCommand";
        public override string Name => "_RobotToPose";
        public override void Execute(object cmdParams)
        {
            TxApplication.ActiveUndoManager.StartTransaction();
            RobotPoseSelectForm robotPoseSelectForm = new RobotPoseSelectForm();
            robotPoseSelectForm.Show();
            TxApplication.ActiveUndoManager.EndTransaction();
        }
    }
    #endregion

    #region Sensor
    public class SensorDetectionZoneVisible : TxButtonCommand
    {
        public override string Category => "ZTFCommand";

        public override string Name => "_SensorDetectionZoneVisible";

        public override void Execute(object cmdParams)
        {
            TxObjectList lightSensors = TxApplication.ActiveDocument.PhysicalRoot.GetAllDescendants(new TxTypeFilter(typeof(TxPlcLightSensor)));
            foreach (var item in lightSensors)
            {
                TxPlcLightSensor lightSensor = item as TxPlcLightSensor;
                lightSensor.IsDetectionZoneVisible = true;
                TxApplication.RefreshDisplay();
            }

        }
    }
    public class SensorDetectionZoneUnVisible : TxButtonCommand
    {
        public override string Category => "ZTFCommand";

        public override string Name => "_SensorDetectionZoneUnVisible";
        public override void Execute(object cmdParams)
        {
            TxObjectList lightSensors = TxApplication.ActiveDocument.PhysicalRoot.GetAllDescendants(new TxTypeFilter(typeof(TxPlcLightSensor)));
            foreach (var item in lightSensors)
            {
                TxPlcLightSensor lightSensor = item as TxPlcLightSensor;
                lightSensor.IsDetectionZoneVisible = false;
                TxApplication.RefreshDisplay();
            }

        }
    }
    public class SensorSignalRname : TxButtonCommand
    {
        public override string Category => "ZTFCommand";

        public override string Name => "_SensorSignalRname";
        public override string Description => "Rname SensorSignal Name the same as Sensor Name";
        public override void Execute(object cmdParams)
        {
            TxObjectList lightSensors = TxApplication.ActiveDocument.PhysicalRoot.GetAllDescendants(new TxTypeFilter(typeof(TxPlcLightSensor)));
            foreach (var item in lightSensors)
            {
                TxPlcLightSensor lightSensor = item as TxPlcLightSensor;
                lightSensor.Signal.Name = lightSensor.Name;
                TxApplication.RefreshDisplay();
            }
        }
    }
    public class CreateLightSensor : TxButtonCommand
    {
        public override string Category => "ZTFCommand";
        public override string Name => "_CreateLightSensor";
        public override void Execute(object cmdParams)
        {
            CreatLightSensor sensorForm = new CreatLightSensor();
            sensorForm.Show();
        }
    }
    public class LightSensorPropertyForm : TxButtonCommand
    {
        public override string Category => "ZTFCommand";
        public override string Name => "_LightSensorProperty";
        public override void Execute(object cmdParams)
        {
            if (TxApplication.ActiveSelection.GetLastPickedItem().GetType().ToString().Contains("TxPlcLightSensor"))
            {
                lightSensorProperty sensorPropertyForm = new lightSensorProperty();
                sensorPropertyForm.Show();
            }
        }
    }
    #endregion

    #region LogicBlock
    public class CreateCylinderLB : TxButtonCommand
    {
        public override string Category => "ZTFCommand";
        public override string Name => "_CreateCylinderLB ";
        public override string Description => "Add normal cylinder logic block（添加气缸逻辑块，如果选择气缸已经有逻辑，现有逻辑会被覆盖）";
        string deviceFullPath = null;
        TxPose poseOpen = null;
        TxPose poseClose = null;
        public override void Execute(object cmdParams)
        {
            TxObjectList txObjects = TxApplication.ActiveSelection.GetItems();

            foreach (TxDevice txObject in txObjects)
            {
                if (canAddLB(txObject))
                {
                    AddLogicToCylinder(txObject);
                }
                else
                {
                    TxMessageBox.Show($"{txObject.Name}' OPEN or CLOSE pose can not find \r\n Or t he pose is defined at the instance level of the device", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TxMessageBox.Show("Add LogicBlock Complete.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void AddLogicToCylinder(TxDevice device)
        {
            try
            {
                deviceFullPath = (device.StorageObject as TxLibraryStorage).FullPath;
            }
            catch (Exception)
            {
                MessageBox.Show($"Can not get the {device.Name}'s path");
            }
            foreach (TxPose pose in device.PoseList)
            {
                if (pose.Name == "OPEN")
                {
                    poseOpen = pose;
                }
                if (pose.Name == "CLOSE")
                {
                    poseClose = pose;
                }
            }

            device.SetModelingScope();
            if (device.LogicBehavior == null)
            {
                device.CreateLogicBehavior(new TxPlcLogicBehaviorCreationData());
            }
            else
            {
                device.LogicBehavior.Delete();
                device.CreateLogicBehavior(new TxPlcLogicBehaviorCreationData());
            }
            //Set Unit
            TxLinearUnitEnumEx val = 0;
            TxAngularUnitEnumEx val2 = 0;
            TxUnitsOptions.TxLinearUnit linearUnit = TxApplication.Options.Units.LinearUnit;
            TxUnitsOptions.TxAngularUnit angularUnit = TxApplication.Options.Units.AngularUnit;
            switch (linearUnit)
            {
                case TxUnitsOptions.TxLinearUnit.Millimeter:
                    val = (TxLinearUnitEnumEx)0;
                    break;
                case TxUnitsOptions.TxLinearUnit.Centimeter:
                    val = (TxLinearUnitEnumEx)1;
                    break;
                case TxUnitsOptions.TxLinearUnit.Meter:
                    val = (TxLinearUnitEnumEx)2;
                    break;
                case TxUnitsOptions.TxLinearUnit.Inch:
                    val = (TxLinearUnitEnumEx)3;
                    break;
                case TxUnitsOptions.TxLinearUnit.Foot:
                    val = (TxLinearUnitEnumEx)4;
                    break;
            }
            switch (angularUnit)
            {
                case TxUnitsOptions.TxAngularUnit.Degree:
                    val2 = (TxAngularUnitEnumEx)0;
                    break;
                case TxUnitsOptions.TxAngularUnit.Radian:
                    val2 = (TxAngularUnitEnumEx)1;
                    break;
            }
            TxPlcLogicBehavior txPlcLogicBehavior = device.LogicBehavior;
            TxLogicBehaviorEx.SetLogicBehaviorUnits(txPlcLogicBehavior, val, val2);

            AddLogicToSingleCylinder(txPlcLogicBehavior);
            //Set Password
            //device.LogicBehavior.SetPassword("");
            //device.LogicBehavior.LockWithPassword();
            //
            device.EndModeling(deviceFullPath);

        }
        private bool canAddLB(TxDevice device)
        {
            bool canAddLB = false;
            bool containOpen = false;
            bool containClose = false;
            foreach (TxPose pose in device.PoseList)
            {
                if (pose.Name == "OPEN" & !pose.IsAtInstance)
                {
                    containOpen = true;
                }
                if (pose.Name == "CLOSE" & !pose.IsAtInstance)
                {
                    containClose = true;
                }
            }
            canAddLB = containOpen && containClose;
            return canAddLB;
        }
        private void AddLogicToSingleCylinder(TxPlcLogicBehavior txPlcLogicBehavior)
        {
            ITxPlcLogicBehaviorEntry openEntry = CreatEntry("OPEN", txPlcLogicBehavior, TxPlcHardwareType.Bool);
            ITxPlcLogicBehaviorEntry closeEntry = CreatEntry("CLOSE", txPlcLogicBehavior, TxPlcHardwareType.Bool);

            ITxPlcLogicBehaviorParameter atOpenSensor = CreatAtPoseSensor("at_open_position", txPlcLogicBehavior, poseOpen);
            ITxPlcLogicBehaviorParameter atCloseSensor = CreatAtPoseSensor("at_close_position", txPlcLogicBehavior, poseClose);
            TxPlcValue txPlcValue = new TxPlcValue() { RealValue = (float)1.5 };
            TxPlcLogicBehaviorConstantCreationData actionTimeCreationData = new TxPlcLogicBehaviorConstantCreationData("actionTime", txPlcValue) { HardwareType = TxPlcHardwareType.Real };
            ITxPlcLogicBehaviorConstant actionTime = txPlcLogicBehavior.CreateConstant(actionTimeCreationData);

            ITxPlcLogicBehaviorExit atOpenExit = CreatExit("At_OPEN", txPlcLogicBehavior, TxPlcHardwareType.Bool);
            atOpenExit.Expression = CreatExpression_At_Postion(atOpenSensor);
            ITxPlcLogicBehaviorExit atCloseExit = CreatExit("At_CLOSE", txPlcLogicBehavior, TxPlcHardwareType.Bool);
            atCloseExit.Expression = CreatExpression_At_Postion(atCloseSensor);

            ITxPlcLogicBehaviorAction moveToOpenPose = CreatAction_MoveToPose("MoveToOPEN", txPlcLogicBehavior, poseOpen, actionTime);
            moveToOpenPose.Expression = CreatExpression_MoveToPoseAction(openEntry, closeEntry, atOpenSensor);
            ITxPlcLogicBehaviorAction moveToClosePose = CreatAction_MoveToPose("MoveToCLOSE", txPlcLogicBehavior, poseClose, actionTime);
            moveToClosePose.Expression = CreatExpression_MoveToPoseAction(closeEntry, openEntry, atCloseSensor);
        }

        private static ITxPlcLogicBehaviorEntry CreatEntry(string entryName, TxPlcLogicBehavior logicBehavior, TxPlcHardwareType plcHardwareType)
        {
            TxPlcLogicBehaviorEntryCreationData entryCreationData = new TxPlcLogicBehaviorEntryCreationData() { Name = entryName, HardwareType = plcHardwareType };
            ITxPlcLogicBehaviorEntry entry = logicBehavior.CreateEntry(entryCreationData);
            return entry;
        }
        private static ITxPlcLogicBehaviorExit CreatExit(string exitName, TxPlcLogicBehavior logicBehavior, TxPlcHardwareType plcHardwareType)
        {
            TxPlcLogicBehaviorExitCreationData exitCreationData = new TxPlcLogicBehaviorExitCreationData() { Name = exitName, HardwareType = plcHardwareType };
            ITxPlcLogicBehaviorExit exit = logicBehavior.CreateExit(exitCreationData);
            return exit;
        }
        private static ITxPlcLogicBehaviorParameter CreatAtPoseSensor(string name, TxPlcLogicBehavior logicBehavior, TxPose pose)
        {

            TxPlcLogicBehaviorAtPoseSensorData atPoseSensorData = new TxPlcLogicBehaviorAtPoseSensorData(pose, 0.02, -0.01, 0.01, false);
            TxPlcLogicBehaviorAtPoseSensorParameterCreationData atPoseSensorParameterCreationData = new TxPlcLogicBehaviorAtPoseSensorParameterCreationData(name, atPoseSensorData);
            return logicBehavior.CreateParameter(atPoseSensorParameterCreationData);
        }
        private static ITxPlcLogicBehaviorAction CreatAction_MoveToPose(String name, TxPlcLogicBehavior logicBehavior, TxPose pose, ITxPlcLogicBehaviorConstant actionTime)
        {
            TxPlcExpressionBuilder txPlcExpressionBuilder = new TxPlcExpressionBuilder();
            txPlcExpressionBuilder.Add(actionTime);

            TxPlcLogicBehaviorMoveToPoseActionCreationData moveToPoseActionCreationData = new TxPlcLogicBehaviorMoveToPoseActionCreationData()
            {
                Name = name,
                Pose = pose,
                VelocityExpressionType = TxPlcVelocityExpressionType.TimeBased,
                VelocityExpression = txPlcExpressionBuilder.Expression
            };
            return logicBehavior.CreateAction(moveToPoseActionCreationData);
        }
        //Expression
        private static TxPlcExpression CreatExpression_Const(double actionParam)
        {
            TxPlcExpressionBuilder txPlcExpressionBuilder = new TxPlcExpressionBuilder();
            TxPlcValue txPlcValue = new TxPlcValue();
            txPlcValue.RealValue = (float)actionParam;
            txPlcExpressionBuilder.Add(TxPlcSignalDataType.Real, txPlcValue);
            return txPlcExpressionBuilder.Expression;
        }
        private static TxPlcExpression CreatExpression_MoveToPoseAction(ITxPlcLogicBehaviorEntry entry1, ITxPlcLogicBehaviorEntry entry2, ITxPlcLogicBehaviorParameter atPoseSensor)
        {
            //Set "at_open_position OR CLOSE" or "at_close_position OR OPEN" as expression
            TxPlcExpressionBuilder expressionBuilder1 = new TxPlcExpressionBuilder();
            expressionBuilder1.Add(entry2);
            expressionBuilder1.Add(TxPlcExpressionOperator.Or);
            expressionBuilder1.Add(atPoseSensor);
            TxPlcFunctionParameterData txPlcFunctionParameterData1 = new TxPlcFunctionParameterData();
            txPlcFunctionParameterData1.SetAsExpression(expressionBuilder1.Expression);
            //Set "CLOSE" or "OPEN" as expression
            TxPlcExpressionBuilder expressionBuilder2 = new TxPlcExpressionBuilder();
            expressionBuilder2.Add(entry1);
            TxPlcFunctionParameterData txPlcFunctionParameterData2 = new TxPlcFunctionParameterData();
            txPlcFunctionParameterData2.SetAsExpression(expressionBuilder2.Expression);

            ArrayList parameters = new ArrayList();
            parameters.Add(txPlcFunctionParameterData2);
            parameters.Add(txPlcFunctionParameterData1);

            TxPlcExpressionBuilder actionBuilder = new TxPlcExpressionBuilder();
            actionBuilder.Add(TxPlcExpressionFunctionType.SR, parameters);

            return actionBuilder.Expression;
        }
        private static TxPlcExpression CreatExpression_At_Postion(ITxPlcLogicBehaviorParameter positionSensor)
        {
            TxPlcExpressionBuilder txPlcExpressionBuilder = new TxPlcExpressionBuilder();
            txPlcExpressionBuilder.Add(positionSensor);
            return txPlcExpressionBuilder.Expression;
        }

    }
    public class CopyRobotLB : TxButtonCommand
    {
        public override string Category => "ZTFCommand";

        public override string Name => "_CopyRobotLB";
        public override string Description => "NOT COMPLETE IMP---";

        public override void Execute(object cmdParams)
        {
            TxResourceCreationData txResourceCreationData = new TxResourceCreationData("KUKA LB");
            TxApplication.ActiveDocument.PhysicalRoot.CreateResource(txResourceCreationData);

        }
    }
    public class AddServoLB : TxButtonCommand
    {
        public override string Category => "ZTFCommand";
        public override string Name => "_AddServoLB ";
        public override string Description => "Add STO";
        string deviceFullPath = null;
        public override void Execute(object cmdParams)
        {
            TxObjectList txObjects = TxApplication.ActiveSelection.GetItems();

            foreach (ITxComponent txObject in txObjects)
            {
                AddLogicToServo(txObject);
            }
            TxMessageBox.Show("Add LogicBlock Complete.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void AddLogicToServo(ITxComponent device)
        {
            try
            {
                deviceFullPath = ((device as ITxStorable).StorageObject as TxLibraryStorage).FullPath;
            }
            catch (Exception)
            {
                MessageBox.Show($"Can not get the {device.Name}'s path");
            }

            device.SetModelingScope();
            TxPlcLogicBehavior txPlcLogicBehavior = (device as ITxPlcLogicResource).LogicBehavior;
            AddLogicToSingleServo(txPlcLogicBehavior);

            device.EndModeling(deviceFullPath);

        }
        private void AddLogicToSingleServo(TxPlcLogicBehavior txPlcLogicBehavior)
        {
            ITxPlcLogicBehaviorEntry STOEntry = CreatEntry("STO", txPlcLogicBehavior, TxPlcHardwareType.Bool);
            ITxPlcLogicBehaviorEntry homeTrig = txPlcLogicBehavior.Entries[0];
            ITxPlcLogicBehaviorAction homeMode = txPlcLogicBehavior.Actions[0];
            ITxPlcLogicBehaviorAction ActMode = txPlcLogicBehavior.Actions[1];
            ITxPlcLogicBehaviorEntry triger1 = txPlcLogicBehavior.Entries[1];
            ITxPlcLogicBehaviorEntry triger2 = txPlcLogicBehavior.Entries[2];
            ITxPlcLogicBehaviorEntry locateLocation = txPlcLogicBehavior.Entries[3];
            ITxPlcLogicBehaviorParameter jointPosition = txPlcLogicBehavior.Parameters[2];

            #region  actmode
            TxPlcExpressionBuilder expressionBuilder1 = new TxPlcExpressionBuilder();
            expressionBuilder1.Add(triger1);
            expressionBuilder1.Add(TxPlcExpressionOperator.Or);
            expressionBuilder1.Add(triger2);
            TxPlcFunctionParameterData txPlcFunctionParameterData1 = new TxPlcFunctionParameterData();
            txPlcFunctionParameterData1.SetAsExpression(expressionBuilder1.Expression);
            //
            TxPlcExpressionBuilder expressionBuilder2 = new TxPlcExpressionBuilder();
            expressionBuilder2.Add(locateLocation);
            expressionBuilder2.Add(TxPlcExpressionOperator.IsEqualTo);
            expressionBuilder2.Add(jointPosition);
            TxPlcFunctionParameterData txPlcFunctionParameterData2 = new TxPlcFunctionParameterData();
            txPlcFunctionParameterData2.SetAsExpression(expressionBuilder2.Expression);

            ArrayList parameters = new ArrayList();
            parameters.Add(txPlcFunctionParameterData1);
            parameters.Add(txPlcFunctionParameterData2);

            TxPlcExpressionBuilder actionBuilder = new TxPlcExpressionBuilder();
            actionBuilder.Add(TxPlcExpressionFunctionType.SR, parameters);
            actionBuilder.Add(TxPlcExpressionOperator.And);
            actionBuilder.Add(STOEntry);
            TxPlcExpression newExpression = actionBuilder.Expression;
            ActMode.Expression= newExpression;
            #endregion
            //homeMode 
            TxPlcExpressionBuilder expressionBuilderA = new TxPlcExpressionBuilder();
            expressionBuilderA.Add(homeTrig);
            TxPlcFunctionParameterData txPlcFunctionParameterDataA = new TxPlcFunctionParameterData();
            txPlcFunctionParameterDataA.SetAsExpression(expressionBuilderA.Expression);
            //
            TxPlcValue txPlcValue = new TxPlcValue();
            txPlcValue.IntValue = 0;
            TxPlcExpressionBuilder expressionBuilderB = new TxPlcExpressionBuilder();
            expressionBuilderB.Add(jointPosition);
            expressionBuilderB.Add(TxPlcExpressionOperator.IsEqualTo);
            expressionBuilderB.Add(TxPlcSignalDataType.Int, txPlcValue);
            TxPlcFunctionParameterData txPlcFunctionParameterDataB = new TxPlcFunctionParameterData();
            txPlcFunctionParameterDataB.SetAsExpression(expressionBuilderB.Expression);

            ArrayList parametersA = new ArrayList();
            parametersA.Add(txPlcFunctionParameterDataA);
            parametersA.Add(txPlcFunctionParameterDataB);

            TxPlcExpressionBuilder actionBuilderA = new TxPlcExpressionBuilder();
            actionBuilderA.Add(TxPlcExpressionFunctionType.SR, parametersA);
            actionBuilderA.Add(TxPlcExpressionOperator.And);
            actionBuilderA.Add(STOEntry);
            homeMode.Expression=actionBuilderA.Expression;


        }

        private static ITxPlcLogicBehaviorEntry CreatEntry(string entryName, TxPlcLogicBehavior logicBehavior, TxPlcHardwareType plcHardwareType)
        {
            TxPlcLogicBehaviorEntryCreationData entryCreationData = new TxPlcLogicBehaviorEntryCreationData() { Name = entryName, HardwareType = plcHardwareType };
            ITxPlcLogicBehaviorEntry entry = logicBehavior.CreateEntry(entryCreationData);
            return entry;
        }
    }
    #endregion

    #region Signal
    public class QuickWatchCmd : TxToggleButtonCommand
    {
        private bool active;
        private TxForm form;
        public override bool Push => active;
        public override string Category => "ZTFCommand";
        public override string Name => "_SignalQuidkWatch";
        public override ITxCommandEnabler CommandEnabler
        {
            get
            {
                Enabler enabler = new Enabler();
                return enabler; 
            }
        }
        public override void Execute(object cmdParams)
        {
            active = !active;
            if (active)
            {
                form = new QuickWatchForm();
                form.Show();
            }
            else
            {
                if (null != form)
                {
                    form.Close();
                }
                form = null;
            }
        }
    }
    public class Enabler : ITxCommandEnabler
    {
        public bool Enable => TxApplication.ActiveDocument.PlatformGlobalServicesProvider.IsLineSimulationMode;
    }
    #endregion

    #region Fixture
    public class PoseCreat : TxButtonCommand
    {
        public override string Category => "ZTFCommand";

        public override string Name => "_PoseCreat";
        public override string Description => "Creat single cylinder OPEN&CLOSE pose/单气缸OPEN&CLOSE POSE的创建 ";
        public override string Bitmap => "CATL.bmp";

        public override void Execute(object cmdParams)
        {
            PoseCreaterForm poseCreatForm = new PoseCreaterForm();
            poseCreatForm.Show();
        }
    }
    public class CylinderCreat : TxButtonCommand
    {
        public override string Category => "ZTFCommand";

        public override string Name => "_SimpleCylinderCreat";
        TxCommandEnablerParam txCommandEnablerParam = new TxCommandEnablerParam() { ebable = true };
        public override ITxCommandEnabler CommandEnabler => new TxCommandEnablerZTF(txCommandEnablerParam);
        public override void Execute(object cmdParams)
        {
            SimpleCylinderForm simpleCylinderForm = new SimpleCylinderForm();
            simpleCylinderForm.Load += SimpleCylinderForm_Load2;
            simpleCylinderForm.FormClosing += SimpleCylinderForm_FormClosing2;
            simpleCylinderForm.Show();
        }

        private void SimpleCylinderForm_FormClosing2(object sender, FormClosingEventArgs e)
        {
            txCommandEnablerParam.ebable = true;
        }

        private void SimpleCylinderForm_Load2(object sender, EventArgs e)
        {
            txCommandEnablerParam.ebable = false;
        }
    }
    internal class TxCommandEnablerZTF : ITxCommandEnabler
    {
        TxCommandEnablerParam enablerParam;
        public TxCommandEnablerZTF(TxCommandEnablerParam enablerParam)
        {
            this.enablerParam = enablerParam;
        }
        public bool Enable => enablerParam.ebable;
    }
    internal class TxCommandEnablerParam
    {
        public bool ebable { get; set; }
        public TxCommandEnablerParam()
        {
            ebable = true;
        }
    }
    public class _JointProperty : TxButtonCommand
    {
        public override string Category => "ZTF_PDPS_Commands";

        public override string Name => "_JointPropertyModify";

        public override string Description => "Chang joint's speed and acc to 10000 ";

        public override void Execute(object cmdParams)
        {
            foreach (ITxObject allItem in (Collection<ITxObject>)TxApplication.ActiveSelection.GetAllItems())
            {
                ITxComponent txDevice = allItem as ITxComponent;
                if ((txDevice as ITxKinematicsModellable).Joints.Count > 0)
                {
                    string fullPath = ((txDevice as ITxStorable).StorageObject as TxLibraryStorage).FullPath;
                    txDevice.SetModelingScope();
                    foreach (TxJoint joint in (Collection<TxJoint>)(txDevice as ITxKinematicsModellable).Joints)
                    {
                        if (joint.Type == TxJoint.TxJointType.Prismatic)
                        {
                          //  joint.MaxSpeed = 10000.0;
                            joint.MaxAcceleration = 999999.0;
                        }
                        else
                        {
                          //  joint.MaxSpeed = 500.0 * Math.PI / 9.0;
                            joint.MaxAcceleration = 50000.0 * Math.PI / 9.0;
                        }
                    }
                    txDevice.EndModeling(fullPath);
                }
            }
        }
    }
    #endregion

    public class Test : TxButtonCommand
    {
        public override string Category => "TEXT";

        public override string Name
        {
            get
            {
                return "TEXT";
            }
        }
        public override string Bitmap => "EditLogicResource.bmp";
        public override void Execute(object cmdParams)
        {
            TxApplication.ActiveUndoManager.StartTransaction();

            //ITxLocatableObject txObject = TxApplication.ActiveSelection.GetLastPickedItem() as ITxLocatableObject;
            //TxCurve txPolyline = txObject as TxCurve;
            //foreach (TxVector pt in txPolyline.Approximation.Points)
            //{
            //    CreatPOINT(pt, txPolyline);
            //    //
            //}
            SimpleCylinderForm simpleCylinderForm = new SimpleCylinderForm();
            simpleCylinderForm.Show();




            TxApplication.ActiveUndoManager.EndTransaction();
        }
        public void CreatPOINT(TxVector refVector, TxCurve txPolyline)
        {
            IEnumerable<TxParameterizedPoint> points = txPolyline.GetPointByPointToPointDistance(refVector, 0.1);
            TxVector[] txVectors = new TxVector[2];
            int i = 0;
            foreach (TxParameterizedPoint point in points)
            {
                txVectors[i] = point.Point;
                // TxApplication.ActiveDocument.PhysicalRoot.CreateFrame(new TxFrameCreationData("pp", new TxTransformation(point.Point, TxTransformation.TxTransformationType.Translate)));
                i++;
            }
            double deg = Math.Atan((txVectors[1].Y - txVectors[0].Y) / (txVectors[1].X - txVectors[0].X));
            TxTransformation txTransformation = new TxTransformation(refVector, TxTransformation.TxTransformationType.Translate);
            txTransformation *= new TxTransformation(new TxVector(deg, 0, 0), TxTransformation.TxRotationType.EulerZYZ);
            TxApplication.ActiveDocument.PhysicalRoot.CreateFrame(new TxFrameCreationData(
        "111", txTransformation));
        }

    }
}

