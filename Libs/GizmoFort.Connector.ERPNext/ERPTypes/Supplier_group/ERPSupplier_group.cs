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

        private int _is_group = 0;
        public int is_group
        {
            get { return data._is_group; }
            set { data._is_group = value; }
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

        private int _lft = 0;
        public int lft
        {
            get { return data._lft; }
            set { data._lft = value; }
        }

        private int _rgt = 0;
        public int rgt
        {
            get { return data._rgt; }
            set { data._rgt = value; }
        }

        public string old_parent
        {
            get { return data.old_parent; }
            set { data.old_parent = value; }
        }


    }

    //Enums go here

}