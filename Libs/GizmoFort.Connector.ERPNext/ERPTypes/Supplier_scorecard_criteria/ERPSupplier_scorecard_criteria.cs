using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard_criteria
{
    public class ERPSupplier_scorecard_criteria : ERPNextObjectBase
    {
        public ERPSupplier_scorecard_criteria() : this(new ERPObject(DocType.Supplier_scorecard_criteria)) { }
        public ERPSupplier_scorecard_criteria(ERPObject obj) : base(obj) { }

        public static ERPSupplier_scorecard_criteria Create(string criterianame, double maxscore, string formula, double weight)

        {
            ERPSupplier_scorecard_criteria obj = new ERPSupplier_scorecard_criteria();
            obj.criteria_name = criterianame;
            obj.max_score = maxscore;
            obj.formula = formula;
            obj.weight = weight;
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

        public double max_score
        {
            get { return data.max_score; }
            set { data.max_score = value; }
        }

        public string formula
        {
            get { return data.formula; }
            set { data.formula = value; }
        }

        public double weight
        {
            get { return data.weight; }
            set { data.weight = value; }
        }


    }

    //Enums go here

}