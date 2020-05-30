using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Authorization_rule
{
    public class ERPAuthorization_rule : ERPNextObjectBase
    {
        public ERPAuthorization_rule() : this(new ERPObject(DocType.Authorization_rule)) { }
        public ERPAuthorization_rule(ERPObject obj) : base(obj) { }

        public static ERPAuthorization_rule Create(Transaction transaction, Basedon basedon, Customeroritem customeroritem, string mastername, string company, double value, string systemrole, string toemp, string systemuser, string todesignation, string approvingrole, string approvinguser)

        {
            ERPAuthorization_rule obj = new ERPAuthorization_rule();
            obj.transaction = transaction;
            obj.based_on = basedon;
            obj.customer_or_item = customeroritem;
            obj.master_name = mastername;
            obj.company = company;
            obj.value = value;
            obj.system_role = systemrole;
            obj.to_emp = toemp;
            obj.system_user = systemuser;
            obj.to_designation = todesignation;
            obj.approving_role = approvingrole;
            obj.approving_user = approvinguser;
            return obj;
        }

        public Transaction transaction
        {
            get { return parseEnum<Transaction>(data.transaction); }
            set { data.transaction = value.ToString(); }
        }

        public Basedon based_on
        {
            get { return parseEnum<Basedon>(data.based_on); }
            set { data.based_on = value.ToString(); }
        }

        public Customeroritem customer_or_item
        {
            get { return parseEnum<Customeroritem>(data.customer_or_item); }
            set { data.customer_or_item = value.ToString(); }
        }

        public string master_name
        {
            get { return data.master_name; }
            set { data.master_name = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public double value
        {
            get { return data.value; }
            set { data.value = value; }
        }

        public string system_role
        {
            get { return data.system_role; }
            set { data.system_role = value; }
        }

        public string to_emp
        {
            get { return data.to_emp; }
            set { data.to_emp = value; }
        }

        public string system_user
        {
            get { return data.system_user; }
            set { data.system_user = value; }
        }

        public string to_designation
        {
            get { return data.to_designation; }
            set { data.to_designation = value; }
        }

        public string approving_role
        {
            get { return data.approving_role; }
            set { data.approving_role = value; }
        }

        public string approving_user
        {
            get { return data.approving_user; }
            set { data.approving_user = value; }
        }


    }

    //Enums go here
    public enum Transaction
    {
        [Description("Sales Order")]
        SalesOrder,
        [Description("Purchase Order")]
        PurchaseOrder,
        [Description("Quotation")]
        Quotation,
        [Description("Delivery Note")]
        DeliveryNote,
        [Description("Sales Invoice")]
        SalesInvoice,
        [Description("Purchase Invoice")]
        PurchaseInvoice,
        [Description("Purchase Receipt")]
        PurchaseReceipt,
        [Description("Appraisal")]
        Appraisal,
    }

    public enum Basedon
    {
        [Description("Grand Total")]
        GrandTotal,
        [Description("Average Discount")]
        AverageDiscount,
        [Description("Customerwise Discount")]
        CustomerwiseDiscount,
        [Description("Itemwise Discount")]
        ItemwiseDiscount,
        [Description("Not Applicable")]
        NotApplicable,
    }

    public enum Customeroritem
    {
        [Description("Customer")]
        Customer,
        [Description("Item")]
        Item,
    }


}