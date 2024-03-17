using Tecnomatix.Engineering.Ui;
using Tecnomatix.Engineering;
using System;

namespace WpfLibrary_ztf
{
    public class Class1 : TxButtonCommand
    {
        public override string Category => "";

        public override string Name => "ABX";

        public override void Execute(object cmdParams)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
    }
}