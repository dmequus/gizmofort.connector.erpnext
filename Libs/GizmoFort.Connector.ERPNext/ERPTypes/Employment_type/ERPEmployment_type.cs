using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employment_type
{
    public class ERPEmployment_type : ERPNextObjectBase
    {
        public ERPEmployment_type() : this(new ERPObject(DocType.Employment_type)) { }
        public ERPEmployment_type(ERPObject obj) : base(obj) { }

        public static ERPEmployment_type Create(string employeetypename)

        {
            ERPEmployment_type obj = new ERPEmployment_type();
            obj.employee_type_name = employeetypename;
            return obj;
        }

        public string employee_type_name
        {
            get { return data.employee_type_name; }
            set
            {
                data.employee_type_name = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}