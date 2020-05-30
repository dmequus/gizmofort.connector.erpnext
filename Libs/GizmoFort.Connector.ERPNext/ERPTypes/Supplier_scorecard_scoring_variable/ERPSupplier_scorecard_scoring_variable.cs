using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard_scoring_variable
{
    public class ERPSupplier_scorecard_scoring_variable : ERPNextObjectBase
    {
        public ERPSupplier_scorecard_scoring_variable() : this(new ERPObject(DocType.Supplier_scorecard_scoring_variable)) { }
        public ERPSupplier_scorecard_scoring_variable(ERPObject obj) : base(obj) { }

        public static ERPSupplier_scorecard_scoring_variable Create(string variablelabel, string description, double value, string paramname, string path)

        {
            ERPSupplier_scorecard_scoring_variable obj = new ERPSupplier_scorecard_scoring_variable();
            obj.variable_label = variablelabel;
            obj.description = description;
            obj.value = value;
            obj.param_name = paramname;
            obj.path = path;
            return obj;
        }

        public string variable_label
        {
            get { return data.variable_label; }
            set
            {
                data.variable_label = value;
                data.name = value;
            }

        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public double value
        {
            get { return data.value; }
            set { data.value = value; }
        }

        public string param_name
        {
            get { return data.param_name; }
            set { data.param_name = value; }
        }

        public string path
        {
            get { return data.path; }
            set { data.path = value; }
        }


    }

    //Enums go here

}