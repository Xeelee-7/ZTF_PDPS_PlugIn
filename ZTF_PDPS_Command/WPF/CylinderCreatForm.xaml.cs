using System;
using Tecnomatix.Engineering;
using Tecnomatix.Engineering.Ui.WPF;

namespace ZTF_PDPS_Command
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class CylinderCreatForm : TxWindow
    {
        public CylinderCreatForm()
        {
            InitializeComponent();
           
           
        }

        private void GetLinkElements(ITxKinematicsModellable txKinematicsModellable, ITx2Or3DimensionalGeometry selfLinkSolid, TxObjectList anotherLinkSolid)
        {
            //
            TxTypeFilter txTypeFilter = new TxTypeFilter();
            txTypeFilter.AddIncludedType(typeof(Tx2Or3DimensionalGeometry));
          
            TxObjectList txObjects = (txKinematicsModellable as ITxObjectCollection).GetAllDescendants(txTypeFilter);
            txObjects.Remove(selfLinkSolid);
            foreach (var txObject in anotherLinkSolid) { txObjects.Remove(txObject); }
            GetElement(txObjects, selfLinkSolid as ITxLocatableObject);
        }


        double distance;
        TxVector pointOnObject, pointOnOther;
        TxObjectList<ITxKinematicLinkElement> collectElements;
        private void GetElement(TxObjectList txObjects, ITxLocatableObject checkSolid)
        {
            TxObjectList selectElements = new TxObjectList();
            for(var index=txObjects.Count-1; index>=0; index--) 
            {
                ITxLocatableObject item = (ITxLocatableObject)txObjects[index];
                item.GetMinimalDistance(checkSolid, out distance,out pointOnObject, out pointOnOther);
                if (distance < 0.5)
                {
                    collectElements.Add(item as ITxKinematicLinkElement);
                    selectElements.Add(item);
                }
            }
            foreach (var txObject in selectElements)
                txObjects.Remove(txObject);
            foreach (ITxLocatableObject elem in selectElements)
            {
                GetElement(txObjects, elem);
            }
        }
    }

}




