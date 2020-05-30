using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Request_for_quotation_supplier
{
    public class ERPRequest_for_quotation_supplier : ERPNextObjectBase
    {
        public ERPRequest_for_quotation_supplier() : this(new ERPObject(DocType.Request_for_quotation_supplier)) { }
        public ERPRequest_for_quotation_supplier(ERPObject obj) : base(obj) { }

        public static ERPRequest_for_quotation_supplier Create(long sendemail, long emailsent, string supplier, string contact, long noquote, Quotestatus quotestatus, string suppliername, string emailid)

        {
            ERPRequest_for_quotation_supplier obj = new ERPRequest_for_quotation_supplier();
            obj.send_email = sendemail;
            obj.email_sent = emailsent;
            obj.supplier = supplier;
            obj.contact = contact;
            obj.no_quote = noquote;
            obj.quote_status = quotestatus;
            obj.supplier_name = suppliername;
            obj.email_id = emailid;
            return obj;
        }

        public long send_email
        {
            get { return data.send_email; }
            set { data.send_email = value; }
        }

        public long email_sent
        {
            get { return data.email_sent; }
            set { data.email_sent = value; }
        }

        public string supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        public string contact
        {
            get { return data.contact; }
            set { data.contact = value; }
        }

        public long no_quote
        {
            get { return data.no_quote; }
            set { data.no_quote = value; }
        }

        public Quotestatus quote_status
        {
            get { return parseEnum<Quotestatus>(data.quote_status); }
            set { data.quote_status = value.ToString(); }
        }

        public string supplier_name
        {
            get { return data.supplier_name; }
            set { data.supplier_name = value; }
        }

        public string email_id
        {
            get { return data.email_id; }
            set { data.email_id = value; }
        }


    }

    //Enums go here
    public enum Quotestatus
    {
        [Description("Pending")]
        Pending,
        [Description("Received")]
        Received,
        [Description("No Quote")]
        NoQuote,
    }


}