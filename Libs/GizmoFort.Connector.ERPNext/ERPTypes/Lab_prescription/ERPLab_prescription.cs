using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Lab_prescription
{
    public class ERPLab_prescription : ERPNextObjectBase
    {
        public ERPLab_prescription() : this(new ERPObject(DocType.Lab_prescription)) { }
        public ERPLab_prescription(ERPObject obj) : base(obj) { }

        public static ERPLab_prescription Create(string labtestcode)

        {
            ERPLab_prescription obj = new ERPLab_prescription();
            obj.lab_test_code = labtestcode;
            return obj;
        }

        public string lab_test_code
        {
            get { return data.lab_test_code; }
            set
            {
                data.lab_test_code = value;
                data.name = value;
            }

        }

        public string lab_test_name
        {
            get { return data.lab_test_name; }
            set { data.lab_test_name = value; }
        }

        public long invoiced
        {
            get { return data.invoiced; }
            set { data.invoiced = value; }
        }

        public string lab_test_comment
        {
            get { return data.lab_test_comment; }
            set { data.lab_test_comment = value; }
        }

        public long lab_test_created
        {
            get { return data.lab_test_created; }
            set { data.lab_test_created = value; }
        }


    }

    //Enums go here

}