using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Warehouse_type
{
    public class ERPWarehouse_type : ERPNextObjectBase
    {
        public ERPWarehouse_type() : this(new ERPObject(DocType.Warehouse_type)) { }
        public ERPWarehouse_type(ERPObject obj) : base(obj) { }

        public static ERPWarehouse_type Create()

        {
            ERPWarehouse_type obj = new ERPWarehouse_type();
            return obj;
        }

        public string description
        {
            get { return data.description; }
            set
            {
                data.description = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}