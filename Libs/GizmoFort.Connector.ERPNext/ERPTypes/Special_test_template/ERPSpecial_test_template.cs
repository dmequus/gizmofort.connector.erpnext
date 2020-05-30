using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Special_test_template
{
    public class ERPSpecial_test_template : ERPNextObjectBase
    {
        public ERPSpecial_test_template() : this(new ERPObject(DocType.Special_test_template)) { }
        public ERPSpecial_test_template(ERPObject obj) : base(obj) { }

        public static ERPSpecial_test_template Create(string particulars)

        {
            ERPSpecial_test_template obj = new ERPSpecial_test_template();
            obj.particulars = particulars;
            return obj;
        }

        public string particulars
        {
            get { return data.particulars; }
            set
            {
                data.particulars = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}