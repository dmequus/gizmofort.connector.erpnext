using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Warehouse
{
    public class ERPWarehouse : ERPNextObjectBase
    {
        public ERPWarehouse() : this(new ERPObject(DocType.Warehouse)) { }
        public ERPWarehouse(ERPObject obj) : base(obj) { }

        public static ERPWarehouse Create(string warehousename, string company)

        {
            ERPWarehouse obj = new ERPWarehouse();
            obj.warehouse_name = warehousename;
            obj.company = company;
            return obj;
        }

        public string warehouse_name
        {
            get { return data.warehouse_name; }
            set
            {
                data.warehouse_name = value;
                data.name = value;
            }

        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public long is_group
        {
            get { return data.is_group; }
            set { data.is_group = value; }
        }

        public long disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        public string account
        {
            get { return data.account; }
            set { data.account = value; }
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

        public string email_id
        {
            get { return data.email_id; }
            set { data.email_id = value; }
        }

        public string phone_no
        {
            get { return data.phone_no; }
            set { data.phone_no = value; }
        }

        public string mobile_no
        {
            get { return data.mobile_no; }
            set { data.mobile_no = value; }
        }

        public string address_line_1
        {
            get { return data.address_line_1; }
            set { data.address_line_1 = value; }
        }

        public string address_line_2
        {
            get { return data.address_line_2; }
            set { data.address_line_2 = value; }
        }

        public string city
        {
            get { return data.city; }
            set { data.city = value; }
        }

        public string state
        {
            get { return data.state; }
            set { data.state = value; }
        }

        public string pin
        {
            get { return data.pin; }
            set { data.pin = value; }
        }

        public string parent_warehouse
        {
            get { return data.parent_warehouse; }
            set { data.parent_warehouse = value; }
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

        public string warehouse_type
        {
            get { return data.warehouse_type; }
            set { data.warehouse_type = value; }
        }


    }

    //Enums go here

}