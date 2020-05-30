using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Gst_account
{
    public class ERPGst_account : ERPNextObjectBase
    {
        public ERPGst_account() : this(new ERPObject(DocType.Gst_account)) { }
        public ERPGst_account(ERPObject obj) : base(obj) { }

        public static ERPGst_account Create(string company, string cgstaccount, string sgstaccount, string igstaccount, string cessaccount)

        {
            ERPGst_account obj = new ERPGst_account();
            obj.company = company;
            obj.cgst_account = cgstaccount;
            obj.sgst_account = sgstaccount;
            obj.igst_account = igstaccount;
            obj.cess_account = cessaccount;
            return obj;
        }

        public string company
        {
            get { return data.company; }
            set
            {
                data.company = value;
                data.name = value;
            }

        }

        public string cgst_account
        {
            get { return data.cgst_account; }
            set { data.cgst_account = value; }
        }

        public string sgst_account
        {
            get { return data.sgst_account; }
            set { data.sgst_account = value; }
        }

        public string igst_account
        {
            get { return data.igst_account; }
            set { data.igst_account = value; }
        }

        public string cess_account
        {
            get { return data.cess_account; }
            set { data.cess_account = value; }
        }


    }

    //Enums go here

}