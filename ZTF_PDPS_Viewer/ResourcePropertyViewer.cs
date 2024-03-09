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
            TxApplication.ActiveSelection.ItemsSet += TxSelection_ItemsSet;
            
            

        }

        private void TxSelection_ItemsSet(object sender, TxSelection_ItemsSetEventArgs e)
        {
            if (e.ObjectList.Count>0)
            {
                textBoxResourceType.Text = e.ObjectList[0].GetType().ToString();
                if (e.ObjectList[0] is ITxLocatableObject)
                {
                    ITxLocatableObject locatableObject = (ITxLocatableObject)e.ObjectList[0];
                    textBoxABSLocation.Text = locatableObject.AbsoluteLocation.Translation+"\r\n"+ locatableObject.AbsoluteLocation.RotationRPY_XYZ;
                }
                else
                {
                    textBoxABSLocation.Text=null; 
                }
            }
            this.RefreshDisplay();
        }

        public string ViewerName => "ResourcePropertyViewer";

        public string Description => "ZTFViewer";

        public ITxViewerMenusCollection Menus => null;

        public event TxViewerControl_MenuDisplayRequestedEventHandler MenuDisplayRequested;


        protected override void OnMouseDown(MouseEventArgs e)

        {

            if (e.Button == MouseButtons.Right)

            {

                Point position = new Point(e.X, e.Y);

                FireMenuDisplayRequested("My", position);

            }

            base.OnMouseDown(e);
            

        }



        private void FireMenuDisplayRequested(string viewerName, Point viewerPosition)

        {

            if (MenuDisplayRequested != null)

                MenuDisplayRequested(this, new TxViewerControl_MenuDisplayRequestedEventArgs(viewerName, viewerPosition));

        }


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
