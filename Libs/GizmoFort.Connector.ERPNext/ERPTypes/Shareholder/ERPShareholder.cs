using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Shareholder
{
    public class ERPShareholder : ERPNextObjectBase
    {
        public ERPShareholder() : this(new ERPObject(DocType.Shareholder)) { }
        public ERPShareholder(ERPObject obj) : base(obj) { }

        public static ERPShareholder Create(string title, string company)

        {
            ERPShareholder obj = new ERPShareholder();
            obj.title = title;
            obj.company = company;
            return obj;
        }

        public string title
        {
            get { return data.title; }
            set
            {
                data.title = value;
                data.name = value;
            }

        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string folio_no
        {
            get { return data.folio_no; }
            set { data.folio_no = value; }
        }

        public long is_company
        {
            get { return data.is_company; }
            set { data.is_company = value; }
        }

        public string address_html
        {
            get { return data.address_html; }
            set { data.address_html = value; }
        }

        public string contact_html
        {
            get { return data.contact_html; }
            set { data.contact_html = value; }
        }

        public string share_balance
        {
            get { return data.share_balance; }
            set { data.share_balance = value; }
        }

        public string contact_list
        {
            get { return data.contact_list; }
            set { data.contact_list = value; }
        }


    }

    //Enums go here

}