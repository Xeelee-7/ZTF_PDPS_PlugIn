using System;
using Tecnomatix.Engineering;
using Tecnomatix.Engineering.Ui;
using Tecnomatix.Planning;

namespace ZTF_PDPS_Command
{
    public partial class lightSensorProperty : TxForm
    {
        TxPlcLightSensor pickedLightSensor;
        TxPlcLightSensor sensorPropertyStore;
        public lightSensorProperty()
        {
            InitializeComponent();
            pickedLightSensor = (TxPlcLightSensor)TxApplication.ActiveSelection.GetLastPickedItem();
            sensorPropertyStore = pickedLightSensor;
        }



        private void lightSensorProperty_Load(object sender, EventArgs e)
        {
            TxTypeFilter txTypeFilter = new TxTypeFilter();
            txTypeFilter.AddIncludedType(typeof(ITxLocatableObject));
            txTypeFilter.AddIncludedType(typeof(ITxPlanningPart));
            TxTypeFilterValidator txTypeFilterValidator = new TxTypeFilterValidator(txTypeFilter);
            txObjGridCtrlSensorCheckedWith.SetValidator(txTypeFilterValidator);
            txObjGridCtrlSensorCheckedWith.Objects = pickedLightSensor.ObjectsToCheckInterferenceWith;




            textBoxName.Text = pickedLightSensor.Name;
            //sensorRange
            txNumericEditBoxCtrlRange.LowerBound = 0;
            txNumericEditBoxCtrlRange.UpperBound = pickedLightSensor.MaxRange;
            txNumericEditBoxCtrlRange.Text = pickedLightSensor.CurrentRange.ToString();
            //
            // Signal Statue
            checkBoxNormalFalseTrue.Checked = pickedLightSensor.NormallyFalseSignal;
            //
            txObjGridCtrlSensorCheckedWith.Focus();
        }



        private void txObjGridCtrlSensorCheckedWith_SelectcionChanged(object sender, TxObjGridCtrl_SelectionChangedEventArgs args)
        {
            TxApplication.ActiveSelection.Clear();
            TxSelection txSelection=TxApplication.ActiveSelection;
            foreach (var item in txObjGridCtrlSensorCheckedWith.SelectedObjects)
            {
                if (item.GetType()==typeof(TxPlanningPartInstance))
                {
                    TxObjectList txObjects = TxApplication.ActiveDocument.GetObjectsByName(item.Name);
                    foreach (var txobj in txObjects)
                    {
                        txSelection.AddItems(new TxObjectList() { txobj });
                    }
                }
                else
                {
                    txSelection.AddItems(new TxObjectList() { item });
                }
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Signal name changed
            pickedLightSensor.Name = textBoxName.Text;
            pickedLightSensor.Signal.Name = pickedLightSensor.Name;
            //Signal current range
            pickedLightSensor.CurrentRange = Convert.ToDouble(txNumericEditBoxCtrlRange.Text);
            // Is normal false or no
            pickedLightSensor.NormallyFalseSignal = checkBoxNormalFalseTrue.Checked;
            // Sensor checked with objects
            pickedLightSensor.ObjectsToCheckInterferenceWith = txObjGridCtrlSensorCheckedWith.Objects;
            //
            //
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxName.Text = sensorPropertyStore.Name;
            txNumericEditBoxCtrlRange.Text = sensorPropertyStore.CurrentRange.ToString();
            checkBoxNormalFalseTrue.Checked = sensorPropertyStore.NormallyFalseSignal;
            txObjGridCtrlSensorCheckedWith.Objects = sensorPropertyStore.ObjectsToCheckInterferenceWith;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            txNumericEditBoxCtrlRange.Text = sensorPropertyStore.CurrentRange.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
