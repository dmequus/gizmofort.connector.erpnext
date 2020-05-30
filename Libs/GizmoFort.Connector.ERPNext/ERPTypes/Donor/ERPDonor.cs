using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Donor
{
    public class ERPDonor : ERPNextObjectBase
    {
        public ERPDonor() : this(new ERPObject(DocType.Donor)) { }
        public ERPDonor(ERPObject obj) : base(obj) { }

        public static ERPDonor Create(string donorname, string donortype, string email, string image, string addresshtml, string contacthtml)

        {
            ERPDonor obj = new ERPDonor();
            obj.donor_name = donorname;
            obj.donor_type = donortype;
            obj.email = email;
            obj.image = image;
            obj.address_html = addresshtml;
            obj.contact_html = contacthtml;
            return obj;
        }

        public string donor_name
        {
            get { return data.donor_name; }
            set
            {
                data.donor_name = value;
                data.name = value;
            }

        }

        public string donor_type
        {
            get { return data.donor_type; }
            set { data.donor_type = value; }
        }

        public string email
        {
            get { return data.email; }
            set { data.email = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
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


    }

    //Enums go here

}