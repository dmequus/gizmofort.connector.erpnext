using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Address
{
    public class ERPAddress : ERPNextObjectBase
    {
        public ERPAddress() : this(new ERPObject(DocType.Address)) { }
        public ERPAddress(ERPObject obj) : base(obj) { }

        //Mandatory
        public static ERPAddress Create(string addressTitle, AddressType addressType, string addressline1, string city, string country)
        {
            ERPAddress obj = new ERPAddress();
            obj.address_title = addressTitle;
            obj.address_type = addressType;
            obj.address_line1 = addressline1;
            obj.city = city;
            obj.city = country;
            return obj;
        }

        public string address_title
        {
            get { return data.address_title; }
            set
            {
                data.address_title = value;
                data.name = value;
            }
        }

        public AddressType address_type
        {
            get { return parseEnum<AddressType>(data.address_type); }
            set { data.address_type = value.ToString(); }
        }

        public string address_line1
        {
            get { return data.address_line1; }
            set { data.address_line1 = value; }
        }

        public string city
        {
            get { return data.city; }
            set { data.city = value; }
        }

        public string country
        {
            get { return data.country; }
            set { data.country = value; }
        }

        //Optional
        public string county
        {
            get { return data.county; }
            set { data.county = value; }
        }

        public string state
        {
            get { return data.state; }
            set { data.state = value; }
        }

        //This is zipcode/postcode
        public string pincode
        {
            get { return data.pincode; }
            set { data.pincode = value; }
        }

        private int _is_your_company_address = 0;
        public int is_your_company_address
        {
            get { return data._is_your_company_address; }
            set { data._is_your_company_address = value; }
        }

        private int _disabled = 0;
        public int disabled
        {
            get { return data._disabled; }
            set { data._disabled = value; }
        }

        public string email_id
        {
            get { return data.email_id; }
            set { data.email_id = value; }
        }

        public string fax
        {
            get { return data.fax; }
            set { data.fax = value; }
        }

        private int _is_shipping_address = 0;
        public int is_shipping_address
        {
            get { return data._is_shipping_address; }
            set { data._is_shipping_address = value; }
        }

        public string phone
        {
            get { return data.phone; }
            set { data.phone = value; }
        }

        private int _is_primary_address = 0;
        public int is_primary_address
        {
            get { return data._is_primary_address; }
            set { data._is_primary_address = value; }
        }

        public string address_line_2
        {
            get { return data.address_line_2; }
            set { data.address_line_2 = value; }
        }

        public string tax_category
        {
            get { return data.tax_category; }
            set { data.tax_category = value; }
        }

        public enum AddressType
        {
            Billing,
            Shipping,
            Office,
            Personal,
            Plant,
            Postal,
            Shop,
            Subsidiary,
            Warehouse,
            Current,
            Permanent,
            Other,
        }
    }
}
