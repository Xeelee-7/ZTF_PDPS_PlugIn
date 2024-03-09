using System;
using Tecnomatix.Engineering;
using Tecnomatix.Engineering.Ui;

namespace ZTF_PDPS_Command
{
    public partial class CreatLightSensor : TxForm
    {
        TxTransformation sensorLocation;

        TxCompoundResource selectItem;
        public CreatLightSensor()
        {
            InitializeComponent();
        }

        private void CreatNewSensor_Click(object sender, EventArgs e)
        {
            TxTransformation lastPickLocation = TxApplication.ActiveSelection.GetLastPickedLocation();
            //
            if (pickedFrame.GetLocation() != null)
            {
                TxTransformation pickLocation = pickedFrame.GetLocation();
                sensorLocation = pickLocation;
            }
            else if (lastPickLocation != null)
            {
                sensorLocation = lastPickLocation;
            }
            else
            {
                sensorLocation = new TxTransformation(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }
            sensorLocation *= new TxTransformation(new TxVector(0, -Math.PI / 2, 0), TxTransformation.TxRotationType.EulerZYZ);
            TxPlcLightSensor txPlcLightSensor = TxApplication.ActiveDocument.PhysicalRoot.CreatePlcLightSensor(new TxEmsPlcLightSensorCreationData(textBox1.Text,sensorLocation));
            //Sensor Properties
            txPlcLightSensor.MaxRange = SensorCheckLength.Value;           
            txPlcLightSensor.Signal.Name = txPlcLightSensor.Name;
            txPlcLightSensor.NormallyFalseSignal = NormallyFalse.Checked;          
         

            //
            txPlcLightSensor.ObjectsToCheckInterferenceWith = SensorCheckObjects.Objects;

            //
            if (selectItem!=null)
            {
                selectItem.AddObject(txPlcLightSensor);
            }
            TxApplication.RefreshDisplay();
        }

        private void SensorForm_Load(object sender, EventArgs e)
        {
            selectItem = TxApplication.ActiveSelection.GetLastPickedItem() as TxCompoundResource;
        }


    }
}
