
using System;
using System.Windows.Forms;
using Tecnomatix.Engineering;
using Tecnomatix.Engineering.DataTypes;
using Tecnomatix.Engineering.Ui;
using Tecnomatix.Planning;

namespace ZTF_PDPS_Command
{
    public partial class SimpleCylinderForm : TxForm
    {
        #region type filter
        TxTypeFilter canCreatCtlinderTypeFilter;
        TxTypeFilter dimensionalGeometryTypeFilter;
        TxTypeFilter txGroup_dimensionalGeometryTypeFilter;
        #endregion

        //param
        ITxComponent cylinderModel;       
        TxObjectList cylinderModelAllElements;//Directe Descendant Elements

        TxObjectList<ITxKinematicLinkElement> fixedLinkElements = new TxObjectList<ITxKinematicLinkElement>();
        TxObjectList<ITxKinematicLinkElement> moveLinkElements = new TxObjectList<ITxKinematicLinkElement>();

        TxGroup fixedLinkElementsSelect = TxApplication.ActiveDocument.PhysicalRoot.CreateGroup(new TxGroupCreationData("FixedLinkElementsGroup"));
        TxGroup moveLinkElementsSelect = TxApplication.ActiveDocument.PhysicalRoot.CreateGroup(new TxGroupCreationData("moveLinkElementsGroup"));

        double distance;
        TxVector vector1, vector2;

        public SimpleCylinderForm()
        {
            InitializeComponent();

            TypeFilterDefine();
            InitDefaultValue();
        }

        private void SimpleCylinderForm_Load(object sender, EventArgs e)
        {


        }
        private void TypeFilterDefine()
        {
            canCreatCtlinderTypeFilter = new TxTypeFilter(typeof(ITxComponent));
            canCreatCtlinderTypeFilter.AddExcludedType(typeof(TxRobot));

            dimensionalGeometryTypeFilter = new TxTypeFilter(typeof(ITx2Or3DimensionalGeometry));

            txGroup_dimensionalGeometryTypeFilter = new TxTypeFilter(dimensionalGeometryTypeFilter);
            txGroup_dimensionalGeometryTypeFilter.AddIncludedType(typeof(ITxGroup));

            _pickCylinder.SetValidator(new TxTypeFilterValidator(canCreatCtlinderTypeFilter));
            _pickFixedLinkElement.SetValidator(new TxTypeFilterValidator(txGroup_dimensionalGeometryTypeFilter));
            _pickMoveLinkElemet.SetValidator(new TxTypeFilterValidator(dimensionalGeometryTypeFilter));
        }
        private void RefreachViewer()
        {

        }
        private void GetValueFromViewer()
        {
            cylinderModel = _pickCylinder.Object as ITxComponent;

            //
            (cylinderModel  as ITxObjectCollection).AddObject(moveLinkElementsSelect);
            (cylinderModel as ITxObjectCollection).AddObject(fixedLinkElementsSelect);
            //
            foreach (TxGroup item in (cylinderModel as ITxObjectCollection).GetAllDescendants(new TxTypeFilter(typeof(ITxGroup))))
            {
                if (item.Name == "FixedLinkElementsGroup")
                {
                    item.AddObjects(_pickFixedLinkElement.Objects);
                    fixedLinkElementsSelect= item;

                }
                if (item.Name == "moveLinkElementsGroup")
                {
                    item.AddObjects(_pickMoveLinkElemet.Objects);
                    moveLinkElementsSelect= item;
                }
            }

        }
        private void InitDefaultValue()
        {
            _selectCylinderType.SelectedIndex = 0;
            _selectAxisDirection.SelectedIndex = 0;
            _selectPoseType.SelectedIndex = 0;
        }

        private void _creatKinmatic_Click(object sender, EventArgs e)
        {
            GetValueFromViewer();
            GetMoveLinkElements(cylinderModel as ITxObjectCollection, fixedLinkElementsSelect, moveLinkElementsSelect);

            TxKinematicLinkCreationData moveLinkCreationData = new TxKinematicLinkCreationData("MoveLink");
            TxKinematicLink moveLink = (cylinderModel as ITxKinematicsModellable).CreateLink(moveLinkCreationData);
            moveLink.AddElements(moveLinkElements);

            cylinderModelAllElements.Add(fixedLinkElementsSelect);
            foreach (var item in cylinderModelAllElements)
            {
                fixedLinkElements.Add(item as ITxKinematicLinkElement);
            }

            TxKinematicLinkCreationData fixLinkCreationData = new TxKinematicLinkCreationData("FixedLink");
            TxKinematicLink fixedLink = (cylinderModel as ITxKinematicsModellable).CreateLink(fixLinkCreationData);
            fixedLink.AddElements(fixedLinkElements);



        }

        private void _pickCylinder_Picked(object sender, TxObjEditBoxCtrl_PickedEventArgs args)
        {

        }

        private void _endModeling_Click(object sender, EventArgs e)
        {
            string fillName = null;
            string storagePath;
            ((cylinderModel as ITxStorable).StorageObject as TxLocalStorage).SaveComponent();
            TxPlanningToolInstance toolInstance = (cylinderModel as ITxProcessModelObject).PlanningRepresentation as TxPlanningToolInstance;
            try
            {
                object prop = toolInstance.Prototype.GetType().GetProperty("FullPath").GetValue(toolInstance.Prototype);
                storagePath = prop.ToString();
                cylinderModel.EndModeling(storagePath);
                return;
            }
            catch (Exception)
            {
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save the Cojt Resource";
            saveFileDialog.InitialDirectory = TxApplication.SystemRootDirectory;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = cylinderModel.Name + ".cojt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fillName = saveFileDialog.InitialDirectory + saveFileDialog.FileName;
                cylinderModel.EndModeling(fillName);
            }

        }

        private void GetMoveLinkElements(ITxObjectCollection cylinderModel, TxGroup fixedLinkElementsSelect, TxGroup moveLinkElementsSelect)
        {
                  

            if (fixedLinkElementsSelect == null || fixedLinkElementsSelect.Count == 0 || moveLinkElementsSelect.Count == 0)
            { return; }

            cylinderModelAllElements = cylinderModel.GetDirectDescendants(new TxTypeFilter(txGroup_dimensionalGeometryTypeFilter));

            cylinderModelAllElements.Remove(fixedLinkElementsSelect);
            cylinderModelAllElements.Remove(moveLinkElementsSelect);
            moveLinkElements.Add(moveLinkElementsSelect);
            GetMoveLinkElement(cylinderModelAllElements, moveLinkElementsSelect);
        }
        private void GetMoveLinkElement(TxObjectList cylinderModelAllElements, ITxLocatableObject moveLinkElementsSelect)
        {
            TxObjectList< ITxLocatableObject> elementAttached = new TxObjectList<ITxLocatableObject>();
            for (int i = cylinderModelAllElements.Count - 1; i >= 0; i--)
            {
                moveLinkElementsSelect.GetMinimalDistance((ITxLocatableObject)cylinderModelAllElements[i], out distance, out vector1, out vector2);
                if (distance > 0.2) return;
               
                moveLinkElements.Add(cylinderModelAllElements[i] as ITxKinematicLinkElement);

                elementAttached.Add(cylinderModelAllElements[i] as ITxLocatableObject);
            }

            foreach (var item in elementAttached)
            {
                cylinderModelAllElements.Remove(item);
            }
            foreach (var item in elementAttached)
            {
                GetMoveLinkElement(cylinderModelAllElements, item);
            }
            
        }
    }
}
