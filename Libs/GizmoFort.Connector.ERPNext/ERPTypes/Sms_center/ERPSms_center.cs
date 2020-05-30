using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sms_center
{
    public class ERPSms_center : ERPNextObjectBase
    {
        public ERPSms_center() : this(new ERPObject(DocType.Sms_center)) { }
        public ERPSms_center(ERPObject obj) : base(obj) { }

        public static ERPSms_center Create(Sendto sendto, string customer, string supplier, string salespartner, string department, string branch, string receiverlist, string message, int totalcharacters, int totalmessages)

        {
            ERPSms_center obj = new ERPSms_center();
            obj.send_to = sendto;
            obj.customer = customer;
            obj.supplier = supplier;
            obj.sales_partner = salespartner;
            obj.department = department;
            obj.branch = branch;
            obj.receiver_list = receiverlist;
            obj.message = message;
            obj.total_characters = totalcharacters;
            obj.total_messages = totalmessages;
            return obj;
        }

        public Sendto send_to
        {
            get { return parseEnum<Sendto>(data.send_to); }
            set { data.send_to = value.ToString(); }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        public string sales_partner
        {
            get { return data.sales_partner; }
            set { data.sales_partner = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string branch
        {
            get { return data.branch; }
            set { data.branch = value; }
        }

        public string receiver_list
        {
            get { return data.receiver_list; }
            set { data.receiver_list = value; }
        }

        public string message
        {
            get { return data.message; }
            set { data.message = value; }
        }

        private int _total_characters = 0;
        public int total_characters
        {
            get { return data._total_characters; }
            set { data._total_characters = value; }
        }

        private int _total_messages = 0;
        public int total_messages
        {
            get { return data._total_messages; }
            set { data._total_messages = value; }
        }


    }

    //Enums go here
    public enum Sendto
    {
        [Description("All Contact")]
        AllContact,
        [Description("All Customer Contact")]
        AllCustomerContact,
        [Description("All Supplier Contact")]
        AllSupplierContact,
        [Description("All Sales Partner Contact")]
        AllSalesPartnerContact,
        [Description("All Lead (Open)")]
        AllLeadOpen,
        [Description("All Employee (Active)")]
        AllEmployeeActive,
        [Description("All Sales Person")]
        AllSalesPerson,
    }


}