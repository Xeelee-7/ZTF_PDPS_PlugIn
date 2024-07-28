using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnomatix.Engineering;

namespace BMPTest
{
    public class SimpleButton : TxButtonCommand
    {
        public override string Category => "ZTF";

        public override string Name => nameof(SimpleButton);
        public override string Bitmap => "SimpleButton.bmp";

        public override void Execute(object cmdParams)
        {
            
        }
    }
}
