using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard_variable
{
    public class ERPSupplier_scorecard_variable : ERPNextObjectBase
    {
        public ERPSupplier_scorecard_variable() : this(new ERPObject(DocType.Supplier_scorecard_variable)) { }
        public ERPSupplier_scorecard_variable(ERPObject obj) : base(obj) { }

        public static ERPSupplier_scorecard_variable Create(string variablelabel, long iscustom, string paramname, string path, string description)

        {
            ERPSupplier_scorecard_variable obj = new ERPSupplier_scorecard_variable();
            obj.variable_label = variablelabel;
            obj.is_custom = iscustom;
            obj.param_name = paramname;
            obj.path = path;
            obj.description = description;
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

        public long is_custom
        {
            get { return data.is_custom; }
            set { data.is_custom = value; }
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

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here

}