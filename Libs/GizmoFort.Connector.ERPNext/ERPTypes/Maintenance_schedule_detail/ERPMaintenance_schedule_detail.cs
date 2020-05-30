using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Maintenance_schedule_detail
{
    public class ERPMaintenance_schedule_detail : ERPNextObjectBase
    {
        public ERPMaintenance_schedule_detail() : this(new ERPObject(DocType.Maintenance_schedule_detail)) { }
        public ERPMaintenance_schedule_detail(ERPObject obj) : base(obj) { }

        public static ERPMaintenance_schedule_detail Create(string itemcode, string itemname, string scheduleddate, string actualdate, string salesperson, string serialno)

        {
            ERPMaintenance_schedule_detail obj = new ERPMaintenance_schedule_detail();
            obj.item_code = itemcode;
            obj.item_name = itemname;
            obj.scheduled_date = scheduleddate;
            obj.actual_date = actualdate;
            obj.sales_person = salesperson;
            obj.serial_no = serialno;
            return obj;
        }

        public string item_code
        {
            get { return data.item_code; }
            set
            {
                data.item_code = value;
                data.name = value;
            }

        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public string scheduled_date
        {
            get { return data.scheduled_date; }
            set { data.scheduled_date = value; }
        }

        public string actual_date
        {
            get { return data.actual_date; }
            set { data.actual_date = value; }
        }

        public string sales_person
        {
            get { return data.sales_person; }
            set { data.sales_person = value; }
        }

        public string serial_no
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }


    }

    //Enums go here

}