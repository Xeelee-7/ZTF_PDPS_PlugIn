using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tecnomatix.Engineering.Ui.WPF;
using Tecnomatix.Engineering;
using Tecnomatix.Engineering.PrivateImplementationDetails;
using Tecnomatix.Engineering.Ui;

namespace ZTF_PDPS_Viewer_WPF
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class LogicResourceSignalViewer : TxWPFViewerUserControl
    {
        public LogicResourceSignalViewer()
        {
            InitializeComponent();
        }

        public  override string ViewerName => "_LogicResourceSignalViewer";

        public override string Description => "LogicResource(LB SCL) conncet signals's statue Viewer";

        public override ITxViewerMenusCollection Menus => null;

        public override event TxViewerControl_MenuDisplayRequestedEventHandler MenuDisplayRequested;

        public override void Initialize()
        {
            
        }

        public override void Uninitialize()
        {
            
        }
    }
}
