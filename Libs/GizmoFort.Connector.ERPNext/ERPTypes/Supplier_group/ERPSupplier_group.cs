using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier_group
{
    public class ERPSupplier_group : ERPNextObjectBase
    {
        public ERPSupplier_group() : this(new ERPObject(DocType.Supplier_group)) { }
        public ERPSupplier_group(ERPObject obj) : base(obj) { }

        public static ERPSupplier_group Create(string suppliergroupname)

        {
            ERPSupplier_group obj = new ERPSupplier_group();
            obj.supplier_group_name = suppliergroupname;
            return obj;
        }

        public string supplier_group_name
        {
            get { return data.supplier_group_name; }
            set
            {
                data.supplier_group_name = value;
                data.name = value;
            }

        }

        public string parent_supplier_group
        {
            get { return data.parent_supplier_group; }
            set { data.parent_supplier_group = value; }
        }

        public long is_group
        {
            get { return data.is_group; }
            set { data.is_group = value; }
        }

        public string payment_terms
        {
            get { return data.payment_terms; }
            set { data.payment_terms = value; }
        }

        public string accounts
        {
            get { return data.accounts; }
            set { data.accounts = value; }
        }

        public int lft
        {
            get { return data.lft; }
            set { data.lft = value; }
        }

        public int rgt
        {
            get { return data.rgt; }
            set { data.rgt = value; }
        }

        public string old_parent
        {
            get { return data.old_parent; }
            set { data.old_parent = value; }
        }


    }

    //Enums go here

}