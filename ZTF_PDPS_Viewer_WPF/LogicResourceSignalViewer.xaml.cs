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
using DnPlcCommands.RuleBasedConnectSignalsToLB;
using System.Collections.ObjectModel;

namespace ZTF_PDPS_Viewer_WPF
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class LogicResourceSignalViewer : TxWPFViewerUserControl
    {
        public CApRBCMainViewModel ViewModel => ((FrameworkElement)this).DataContext as CApRBCMainViewModel;
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
        private void GridViewColumnHeader_SetMinWidth_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.NewSize.Width > 40.0)
                return;
            e.Handled = true;
            (sender as GridViewColumnHeader).Column.Width = 40.0;
        }
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(sender is System.Windows.Controls.ListView listView))
                return;
            ObservableCollection<CApLBModel> selectedLbs = this.ViewModel.SelectedLBs;
            selectedLbs.Clear();
            selectedLbs.AddRange<CApLBModel>(listView.SelectedItems.Cast<CApLBModel>());
            this.ViewModel.UpdateMatchesOnlyFilter_OnSelectedLBCollectionChanged();
        }
        private void ToolBar_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.ToolBar templatedParent = sender as System.Windows.Controls.ToolBar;
            if (!(templatedParent.Template.FindName("OverflowGrid", (FrameworkElement)templatedParent) is FrameworkElement name))
                return;
            name.Visibility = Visibility.Collapsed;
        }
    }
    
}
