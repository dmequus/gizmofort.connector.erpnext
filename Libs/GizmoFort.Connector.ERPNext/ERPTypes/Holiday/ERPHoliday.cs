using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Holiday
{
    public class ERPHoliday : ERPNextObjectBase
    {
        public ERPHoliday() : this(new ERPObject(DocType.Holiday)) { }
        public ERPHoliday(ERPObject obj) : base(obj) { }

        public static ERPHoliday Create(string holidaydate, string description)

        {
            ERPHoliday obj = new ERPHoliday();
            obj.holiday_date = holidaydate;
            obj.description = description;
            return obj;
        }

        public string holiday_date
        {
            get { return data.holiday_date; }
            set
            {
                data.holiday_date = value;
                data.name = value;
            }

        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        private int _weekly_off = 0;
        public int weekly_off
        {
            get { return data._weekly_off; }
            set { data._weekly_off = value; }
        }


    }

    //Enums go here

}