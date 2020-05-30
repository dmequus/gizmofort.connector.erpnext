using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Appraisal_goal
{
    public class ERPAppraisal_goal : ERPNextObjectBase
    {
        public ERPAppraisal_goal() : this(new ERPObject(DocType.Appraisal_goal)) { }
        public ERPAppraisal_goal(ERPObject obj) : base(obj) { }

        public static ERPAppraisal_goal Create(string kra, double perweightage, double score, double scoreearned)

        {
            ERPAppraisal_goal obj = new ERPAppraisal_goal();
            obj.kra = kra;
            obj.per_weightage = perweightage;
            obj.score = score;
            obj.score_earned = scoreearned;
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

        public double score
        {
            get { return data.score; }
            set { data.score = value; }
        }

        public double score_earned
        {
            get { return data.score_earned; }
            set { data.score_earned = value; }
        }


    }

    //Enums go here

}