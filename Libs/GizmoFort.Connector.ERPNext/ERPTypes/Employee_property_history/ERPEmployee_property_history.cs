using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_property_history
{
    public class ERPEmployee_property_history : ERPNextObjectBase
    {
        public ERPEmployee_property_history() : this(new ERPObject(DocType.Employee_property_history)) { }
        public ERPEmployee_property_history(ERPObject obj) : base(obj) { }

        public static ERPEmployee_property_history Create(string property, string current, string keyDELnew, string fieldname)

        {
            ERPEmployee_property_history obj = new ERPEmployee_property_history();
            obj.property = property;
            obj.current = current;
            obj.keyDELnew = keyDELnew;
            obj.fieldname = fieldname;
            return obj;
        }

        public string property
        {
            get { return data.property; }
            set
            {
                data.property = value;
                data.name = value;
            }

        }

        public string current
        {
            get { return data.current; }
            set { data.current = value; }
        }

        public string keyDELnew
        {
            get { return data.keyDELnew; }
            set { data.keyDELnew = value; }
        }

        public string fieldname
        {
            get { return data.fieldname; }
            set { data.fieldname = value; }
        }


    }

    //Enums go here

}