using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_supplier
{
    public class ERPItem_supplier : ERPNextObjectBase
    {
        public ERPItem_supplier() : this(new ERPObject(DocType.Item_supplier)) { }
        public ERPItem_supplier(ERPObject obj) : base(obj) { }

        public static ERPItem_supplier Create(string supplier, string supplierpartno)

        {
            ERPItem_supplier obj = new ERPItem_supplier();
            obj.supplier = supplier;
            obj.supplier_part_no = supplierpartno;
            return obj;
        }

        public string supplier
        {
            get { return data.supplier; }
            set
            {
                data.supplier = value;
                data.name = value;
            }

        }

        public string supplier_part_no
        {
            get { return data.supplier_part_no; }
            set { data.supplier_part_no = value; }
        }


    }

    //Enums go here

}