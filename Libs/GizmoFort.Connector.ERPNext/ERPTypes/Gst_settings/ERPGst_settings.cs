using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Gst_settings
{
    public class ERPGst_settings : ERPNextObjectBase
    {
        public ERPGst_settings() : this(new ERPObject(DocType.Gst_settings)) { }
        public ERPGst_settings(ERPObject obj) : base(obj) { }

        public static ERPGst_settings Create(string gstsummary, string gstinemailsenton, string gstaccounts, string b2climit)

        {
            ERPGst_settings obj = new ERPGst_settings();
            obj.gst_summary = gstsummary;
            obj.gstin_email_sent_on = gstinemailsenton;
            obj.gst_accounts = gstaccounts;
            obj.b2c_limit = b2climit;
            return obj;
        }

        public string gst_summary
        {
            get { return data.gst_summary; }
            set
            {
                data.gst_summary = value;
                data.name = value;
            }

        }

        public string gstin_email_sent_on
        {
            get { return data.gstin_email_sent_on; }
            set { data.gstin_email_sent_on = value; }
        }

        public string gst_accounts
        {
            get { return data.gst_accounts; }
            set { data.gst_accounts = value; }
        }

        public string b2c_limit
        {
            get { return data.b2c_limit; }
            set { data.b2c_limit = value; }
        }


    }

    //Enums go here

}