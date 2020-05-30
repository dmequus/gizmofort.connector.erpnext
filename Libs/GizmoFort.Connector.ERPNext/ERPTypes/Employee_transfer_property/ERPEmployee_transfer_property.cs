using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_transfer_property
{
    public class ERPEmployee_transfer_property : ERPNextObjectBase
    {
        public ERPEmployee_transfer_property() : this(new ERPObject(DocType.Employee_transfer_property)) { }
        public ERPEmployee_transfer_property(ERPObject obj) : base(obj) { }

        public static ERPEmployee_transfer_property Create(string property, string current, string keyDELnew)

        {
            ERPEmployee_transfer_property obj = new ERPEmployee_transfer_property();
            obj.property = property;
            obj.current = current;
            obj.keyDELnew = keyDELnew;
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


    }

    //Enums go here

}