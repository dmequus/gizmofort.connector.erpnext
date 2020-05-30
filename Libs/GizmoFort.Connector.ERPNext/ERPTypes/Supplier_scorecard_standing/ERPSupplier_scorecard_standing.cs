using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard_standing
{
    public class ERPSupplier_scorecard_standing : ERPNextObjectBase
    {
        public ERPSupplier_scorecard_standing() : this(new ERPObject(DocType.Supplier_scorecard_standing)) { }
        public ERPSupplier_scorecard_standing(ERPObject obj) : base(obj) { }

        public static ERPSupplier_scorecard_standing Create(string standingname, Standingcolor standingcolor, double mingrade, double maxgrade, int warnrfqs, int warnpos, int preventrfqs, int preventpos, int notifysupplier, int notifyemployee, string employeelink)

        {
            ERPSupplier_scorecard_standing obj = new ERPSupplier_scorecard_standing();
            obj.standing_name = standingname;
            obj.standing_color = standingcolor;
            obj.min_grade = mingrade;
            obj.max_grade = maxgrade;
            obj.warn_rfqs = warnrfqs;
            obj.warn_pos = warnpos;
            obj.prevent_rfqs = preventrfqs;
            obj.prevent_pos = preventpos;
            obj.notify_supplier = notifysupplier;
            obj.notify_employee = notifyemployee;
            obj.employee_link = employeelink;
            return obj;
        }

        public string standing_name
        {
            get { return data.standing_name; }
            set
            {
                data.standing_name = value;
                data.name = value;
            }

        }

        public Standingcolor standing_color
        {
            get { return parseEnum<Standingcolor>(data.standing_color); }
            set { data.standing_color = value.ToString(); }
        }

        private double _min_grade = 0.0;
        public double min_grade
        {
            get { return data._min_grade; }
            set { data._min_grade = value; }
        }

        private double _max_grade = 0.0;
        public double max_grade
        {
            get { return data._max_grade; }
            set { data._max_grade = value; }
        }

        private int _warn_rfqs = 0;
        public int warn_rfqs
        {
            get { return data._warn_rfqs; }
            set { data._warn_rfqs = value; }
        }

        private int _warn_pos = 0;
        public int warn_pos
        {
            get { return data._warn_pos; }
            set { data._warn_pos = value; }
        }

        private int _prevent_rfqs = 0;
        public int prevent_rfqs
        {
            get { return data._prevent_rfqs; }
            set { data._prevent_rfqs = value; }
        }

        private int _prevent_pos = 0;
        public int prevent_pos
        {
            get { return data._prevent_pos; }
            set { data._prevent_pos = value; }
        }

        private int _notify_supplier = 0;
        public int notify_supplier
        {
            get { return data._notify_supplier; }
            set { data._notify_supplier = value; }
        }

        private int _notify_employee = 0;
        public int notify_employee
        {
            get { return data._notify_employee; }
            set { data._notify_employee = value; }
        }

        public string employee_link
        {
            get { return data.employee_link; }
            set { data.employee_link = value; }
        }


    }

    //Enums go here
    public enum Standingcolor
    {
        [Description("Blue")]
        Blue,
        [Description("Purple")]
        Purple,
        [Description("Green")]
        Green,
        [Description("Yellow")]
        Yellow,
        [Description("Orange")]
        Orange,
        [Description("Red")]
        Red,
    }


}