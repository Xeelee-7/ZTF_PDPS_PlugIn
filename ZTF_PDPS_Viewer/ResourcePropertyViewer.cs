using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tecnomatix.Engineering.Ui;
using Tecnomatix.Engineering;

namespace ZTF_PDPS_Viewer
{
    public partial class ResourcePropertyViewer : UserControl,ITxViewerControl,ITxViewerUpdate
    {
        
        public ResourcePropertyViewer()
        {
            InitializeComponent();
            TxTypeFilterValidator txTypeFilterValidator = new TxTypeFilterValidator(new TxTypeFilter(typeof(TxKinematicLink)));
            selectLink.SetValidator(txTypeFilterValidator);
            

        }

        public string ViewerName => "ResourcePropertyViewer";

        public string Description => "ZTFViewer";

        public ITxViewerMenusCollection Menus => null;

        public event TxViewerControl_MenuDisplayRequestedEventHandler MenuDisplayRequested;






        public void Initialize()
        {
            
        }

        public void RefreshDisplay()
        {
            
        }

        public void Uninitialize()
        {

        }

        private void UpDateShow()
        {

        }

    }
}
