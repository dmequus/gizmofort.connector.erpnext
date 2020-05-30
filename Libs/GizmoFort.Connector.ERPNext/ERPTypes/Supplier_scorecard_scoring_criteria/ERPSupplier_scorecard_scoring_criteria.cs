using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard_scoring_criteria
{
    public class ERPSupplier_scorecard_scoring_criteria : ERPNextObjectBase
    {
        public ERPSupplier_scorecard_scoring_criteria() : this(new ERPObject(DocType.Supplier_scorecard_scoring_criteria)) { }
        public ERPSupplier_scorecard_scoring_criteria(ERPObject obj) : base(obj) { }

        public static ERPSupplier_scorecard_scoring_criteria Create(string criterianame, double score, double weight, double maxscore, string formula)

        {
            ERPSupplier_scorecard_scoring_criteria obj = new ERPSupplier_scorecard_scoring_criteria();
            obj.criteria_name = criterianame;
            obj.score = score;
            obj.weight = weight;
            obj.max_score = maxscore;
            obj.formula = formula;
            return obj;
        }

        public string criteria_name
        {
            get { return data.criteria_name; }
            set
            {
                data.criteria_name = value;
                data.name = value;
            }

        }

        private double _score = 0.0;
        public double score
        {
            get { return data._score; }
            set { data._score = value; }
        }

        private double _weight = 0.0;
        public double weight
        {
            get { return data._weight; }
            set { data._weight = value; }
        }

        private double _max_score = 0.0;
        public double max_score
        {
            get { return data._max_score; }
            set { data._max_score = value; }
        }

        public string formula
        {
            get { return data.formula; }
            set { data.formula = value; }
        }


    }

    //Enums go here

}