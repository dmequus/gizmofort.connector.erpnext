using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Maintenance_schedule_item
{
    public class ERPMaintenance_schedule_item : ERPNextObjectBase
    {
        public ERPMaintenance_schedule_item() : this(new ERPObject(DocType.Maintenance_schedule_item)) { }
        public ERPMaintenance_schedule_item(ERPObject obj) : base(obj) { }

        public static ERPMaintenance_schedule_item Create(string itemcode, string itemname, string description, string startdate, string enddate, Periodicity periodicity, int noofvisits, string salesperson, string serialno, string salesorder)

        {
            ERPMaintenance_schedule_item obj = new ERPMaintenance_schedule_item();
            obj.item_code = itemcode;
            obj.item_name = itemname;
            obj.description = description;
            obj.start_date = startdate;
            obj.end_date = enddate;
            obj.periodicity = periodicity;
            obj.no_of_visits = noofvisits;
            obj.sales_person = salesperson;
            obj.serial_no = serialno;
            obj.sales_order = salesorder;
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

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string start_date
        {
            get { return data.start_date; }
            set { data.start_date = value; }
        }

        public string end_date
        {
            get { return data.end_date; }
            set { data.end_date = value; }
        }

        public Periodicity periodicity
        {
            get { return parseEnum<Periodicity>(data.periodicity); }
            set { data.periodicity = value.ToString(); }
        }

        private int _no_of_visits = 0;
        public int no_of_visits
        {
            get { return data._no_of_visits; }
            set { data._no_of_visits = value; }
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

        public string sales_order
        {
            get { return data.sales_order; }
            set { data.sales_order = value; }
        }


    }

    //Enums go here
    public enum Periodicity
    {
        [Description("Weekly")]
        Weekly,
        [Description("Monthly")]
        Monthly,
        [Description("Quarterly")]
        Quarterly,
        [Description("Half Yearly")]
        HalfYearly,
        [Description("Yearly")]
        Yearly,
        [Description("Random")]
        Random,
    }


}