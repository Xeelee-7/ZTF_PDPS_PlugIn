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
    public partial class QuickWatchForm : TxForm
    {
        private TxPlcSignalBase selectedSignal;
        private TxSimulationPlayer player;
        public QuickWatchForm()
        {
            InitializeComponent();
            player = TxApplication.ActiveDocument.SimulationPlayer;
            player.SimulationCleared += Player_SimulationCleared;
            TxApplication.ActiveSelection.ItemsSet += TxSelection_ItemsSet;

        }

        private void TxSelection_ItemsSet(object sender, TxSelection_ItemsSetEventArgs e)
        {
            if (player.IsSimulationReset()||(e.ObjectList.Count!=1)||(e.ObjectList==null))
            {
                this.Hide();
                return;
            }
            if (e.ObjectList[0] is TxPlcSignalBase signal)
            {
                //if (selectedSignal != null)
                //{
                //    selectedSignal.ValueChanged -= SelectedSignal_ValueChanged;
                //}
                selectedSignal = signal;
                RefreshSelectedSignalValue();
                selectedSignal.ValueChanged += SelectedSignal_ValueChanged;
                this.Location = new Point(Control.MousePosition.X + 5, Control.MousePosition.Y - 50);
                this.Show();
            }
            else
            {
                this.Hide();
            }
        }

        private void RefreshSelectedSignalValue()
        {
            signalValuelabel.Text = ParseSignalValueToText(selectedSignal);
            this.Refresh();
        }

        private string ParseSignalValueToText(TxPlcSignalBase txPlcSignal)
        {
            switch (selectedSignal.DataType)
            {
                case TxPlcSignalDataType.Bool:
                    return txPlcSignal.Value.BooleanValue.ToString();
                case TxPlcSignalDataType.Byte:
                    return txPlcSignal.Value.ByteValue.ToString();
                case TxPlcSignalDataType.Word:
                    return txPlcSignal.Value.WordValue.ToString();
                case TxPlcSignalDataType.DWord:
                    return txPlcSignal.Value.DWordValue.ToString();
                case TxPlcSignalDataType.Int:
                    return txPlcSignal.Value.IntValue.ToString();
                case TxPlcSignalDataType.DInt:
                    return txPlcSignal.Value.DIntValue.ToString();
                case TxPlcSignalDataType.Real:
                    return txPlcSignal.Value.RealValue.ToString();
                case TxPlcSignalDataType.LReal:
                    return txPlcSignal.Value.LRealValue.ToString();
                case TxPlcSignalDataType.SInt:
                    return txPlcSignal.Value.SIntValue.ToString();
                default:
                    return string.Empty;
            }
        }

        private void SelectedSignal_ValueChanged(object sender, TxPlcSignal_ValueChangedEventArgs args)
        {
            RefreshSelectedSignalValue();
        }

        private void Player_SimulationCleared(object sender, TxSimulationPlayer_SimulationClearedEventArgs args)
        {
            this.Hide();
        }

        private void QuickWatchForm_Load(object sender, EventArgs e)
        {
            
        }

        private void QuickWatchForm_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void QuickWatchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TxApplication.ActiveSelection.ItemsSet -= TxSelection_ItemsSet;
 
        }
    }
}
