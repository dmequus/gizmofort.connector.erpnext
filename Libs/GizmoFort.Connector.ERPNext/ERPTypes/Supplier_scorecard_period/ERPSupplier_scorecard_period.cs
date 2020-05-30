using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard_period
{
    public class ERPSupplier_scorecard_period : ERPNextObjectBase
    {
        public ERPSupplier_scorecard_period() : this(new ERPObject(DocType.Supplier_scorecard_period)) { }
        public ERPSupplier_scorecard_period(ERPObject obj) : base(obj) { }

        public static ERPSupplier_scorecard_period Create(string supplier, string namingseries, double totalscore, string startdate, string enddate, string criteria, string variables, string scorecard, string amendedfrom)

        {
            ERPSupplier_scorecard_period obj = new ERPSupplier_scorecard_period();
            obj.supplier = supplier;
            obj.naming_series = namingseries;
            obj.total_score = totalscore;
            obj.start_date = startdate;
            obj.end_date = enddate;
            obj.criteria = criteria;
            obj.variables = variables;
            obj.scorecard = scorecard;
            obj.amended_from = amendedfrom;
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

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        private double _total_score = 0.0;
        public double total_score
        {
            get { return data._total_score; }
            set { data._total_score = value; }
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

        public string criteria
        {
            get { return data.criteria; }
            set { data.criteria = value; }
        }

        public string variables
        {
            get { return data.variables; }
            set { data.variables = value; }
        }

        public string scorecard
        {
            get { return data.scorecard; }
            set { data.scorecard = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}