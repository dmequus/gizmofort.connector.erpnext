using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_period
{
    public class ERPLeave_period : ERPNextObjectBase
    {
        public ERPLeave_period() : this(new ERPObject(DocType.Leave_period)) { }
        public ERPLeave_period(ERPObject obj) : base(obj) { }

        public static ERPLeave_period Create(string fromdate, string todate, long isactive, string company, string optionalholidaylist)

        {
            ERPLeave_period obj = new ERPLeave_period();
            obj.from_date = fromdate;
            obj.to_date = todate;
            obj.is_active = isactive;
            obj.company = company;
            obj.optional_holiday_list = optionalholidaylist;
            return obj;
        }

        public string from_date
        {
            get { return data.from_date; }
            set
            {
                data.from_date = value;
                data.name = value;
            }

        }

        public string to_date
        {
            get { return data.to_date; }
            set { data.to_date = value; }
        }

        public long is_active
        {
            get { return data.is_active; }
            set { data.is_active = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string optional_holiday_list
        {
            get { return data.optional_holiday_list; }
            set { data.optional_holiday_list = value; }
        }


    }

    //Enums go here

}