using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Appraisal_template_goal
{
    public class ERPAppraisal_template_goal : ERPNextObjectBase
    {
        public ERPAppraisal_template_goal() : this(new ERPObject(DocType.Appraisal_template_goal)) { }
        public ERPAppraisal_template_goal(ERPObject obj) : base(obj) { }

        public static ERPAppraisal_template_goal Create(string kra, double perweightage)

        {
            ERPAppraisal_template_goal obj = new ERPAppraisal_template_goal();
            obj.kra = kra;
            obj.per_weightage = perweightage;
            return obj;
        }

        public string kra
        {
            get { return data.kra; }
            set
            {
                data.kra = value;
                data.name = value;
            }

        }

        public double per_weightage
        {
            get { return data.per_weightage; }
            set { data.per_weightage = value; }
        }


    }

    //Enums go here

}