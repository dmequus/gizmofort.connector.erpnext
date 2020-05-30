using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard
{
    public class ERPSupplier_scorecard : ERPNextObjectBase
    {
        public ERPSupplier_scorecard() : this(new ERPObject(DocType.Supplier_scorecard)) { }
        public ERPSupplier_scorecard(ERPObject obj) : base(obj) { }

        public static ERPSupplier_scorecard Create(string supplier, string supplierscore, string indicatorcolor, string status, Period period, string weightingfunction, string standings, string criteria, long warnrfqs, long warnpos, long preventrfqs, long preventpos, long notifysupplier, long notifyemployee, string employee)

        {
            ERPSupplier_scorecard obj = new ERPSupplier_scorecard();
            obj.supplier = supplier;
            obj.supplier_score = supplierscore;
            obj.indicator_color = indicatorcolor;
            obj.status = status;
            obj.period = period;
            obj.weighting_function = weightingfunction;
            obj.standings = standings;
            obj.criteria = criteria;
            obj.warn_rfqs = warnrfqs;
            obj.warn_pos = warnpos;
            obj.prevent_rfqs = preventrfqs;
            obj.prevent_pos = preventpos;
            obj.notify_supplier = notifysupplier;
            obj.notify_employee = notifyemployee;
            obj.employee = employee;
            return obj;
        }

        public string supplier
        {
            get { return data.supplier; }
            set
            {
                data.supplier = value;
                data.name = value;
            }

        }

        public string supplier_score
        {
            get { return data.supplier_score; }
            set { data.supplier_score = value; }
        }

        public string indicator_color
        {
            get { return data.indicator_color; }
            set { data.indicator_color = value; }
        }

        public string status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        public Period period
        {
            get { return parseEnum<Period>(data.period); }
            set { data.period = value.ToString(); }
        }

        public string weighting_function
        {
            get { return data.weighting_function; }
            set { data.weighting_function = value; }
        }

        public string standings
        {
            get { return data.standings; }
            set { data.standings = value; }
        }

        public string criteria
        {
            get { return data.criteria; }
            set { data.criteria = value; }
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

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }


    }

    //Enums go here
    public enum Period
    {
        [Description("Per Week")]
        PerWeek,
        [Description("Per Month")]
        PerMonth,
        [Description("Per Year")]
        PerYear,
    }


}