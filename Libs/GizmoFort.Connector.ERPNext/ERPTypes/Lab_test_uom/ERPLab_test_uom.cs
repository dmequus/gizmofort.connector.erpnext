using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Lab_test_uom
{
    public class ERPLab_test_uom : ERPNextObjectBase
    {
        public ERPLab_test_uom() : this(new ERPObject(DocType.Lab_test_uom)) { }
        public ERPLab_test_uom(ERPObject obj) : base(obj) { }

        public static ERPLab_test_uom Create(string labtestuom, string uomdescription)

        {
            ERPLab_test_uom obj = new ERPLab_test_uom();
            obj.lab_test_uom = labtestuom;
            obj.uom_description = uomdescription;
            return obj;
        }

        public string lab_test_uom
        {
            get { return data.lab_test_uom; }
            set
            {
                data.lab_test_uom = value;
                data.name = value;
            }

        }

        public string uom_description
        {
            get { return data.uom_description; }
            set { data.uom_description = value; }
        }


    }

    //Enums go here

}