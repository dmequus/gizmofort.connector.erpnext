using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard_scoring_standing
{
    public class ERPSupplier_scorecard_scoring_standing : ERPNextObjectBase
    {
        public ERPSupplier_scorecard_scoring_standing() : this(new ERPObject(DocType.Supplier_scorecard_scoring_standing)) { }
        public ERPSupplier_scorecard_scoring_standing(ERPObject obj) : base(obj) { }

        public static ERPSupplier_scorecard_scoring_standing Create(string standingname, Standingcolor standingcolor, double mingrade, double maxgrade, long warnrfqs, long warnpos, long preventrfqs, long preventpos, long notifysupplier, long notifyemployee, string employeelink)

        {
            ERPSupplier_scorecard_scoring_standing obj = new ERPSupplier_scorecard_scoring_standing();
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

        public double min_grade
        {
            get { return data.min_grade; }
            set { data.min_grade = value; }
        }

        public double max_grade
        {
            get { return data.max_grade; }
            set { data.max_grade = value; }
        }

        public long warn_rfqs
        {
            get { return data.warn_rfqs; }
            set { data.warn_rfqs = value; }
        }

        public long warn_pos
        {
            get { return data.warn_pos; }
            set { data.warn_pos = value; }
        }

        public long prevent_rfqs
        {
            get { return data.prevent_rfqs; }
            set { data.prevent_rfqs = value; }
        }

        public long prevent_pos
        {
            get { return data.prevent_pos; }
            set { data.prevent_pos = value; }
        }

        public long notify_supplier
        {
            get { return data.notify_supplier; }
            set { data.notify_supplier = value; }
        }

        public long notify_employee
        {
            get { return data.notify_employee; }
            set { data.notify_employee = value; }
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