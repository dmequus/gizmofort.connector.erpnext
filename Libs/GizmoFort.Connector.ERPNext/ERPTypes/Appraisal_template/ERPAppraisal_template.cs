using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Appraisal_template
{
    public class ERPAppraisal_template : ERPNextObjectBase
    {
        public ERPAppraisal_template() : this(new ERPObject(DocType.Appraisal_template)) { }
        public ERPAppraisal_template(ERPObject obj) : base(obj) { }

        public static ERPAppraisal_template Create(string kratitle, string description, string goals)

        {
            ERPAppraisal_template obj = new ERPAppraisal_template();
            obj.kra_title = kratitle;
            obj.description = description;
            obj.goals = goals;
            return obj;
        }

        public string kra_title
        {
            get { return data.kra_title; }
            set
            {
                data.kra_title = value;
                data.name = value;
            }

        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string goals
        {
            get { return data.goals; }
            set { data.goals = value; }
        }


    }

    //Enums go here

}