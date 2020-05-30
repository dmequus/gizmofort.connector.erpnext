using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Assessment_group
{
    public class ERPAssessment_group : ERPNextObjectBase
    {
        public ERPAssessment_group() : this(new ERPObject(DocType.Assessment_group)) { }
        public ERPAssessment_group(ERPObject obj) : base(obj) { }

        public static ERPAssessment_group Create(string assessmentgroupname, string parentassessmentgroup)

        {
            ERPAssessment_group obj = new ERPAssessment_group();
            obj.assessment_group_name = assessmentgroupname;
            obj.parent_assessment_group = parentassessmentgroup;
            return obj;
        }

        public string assessment_group_name
        {
            get { return data.assessment_group_name; }
            set
            {
                data.assessment_group_name = value;
                data.name = value;
            }

        }

        public string parent_assessment_group
        {
            get { return data.parent_assessment_group; }
            set { data.parent_assessment_group = value; }
        }

        private int _is_group = 0;
        public int is_group
        {
            get { return data._is_group; }
            set { data._is_group = value; }
        }

        private int _lft = 0;
        public int lft
        {
            get { return data._lft; }
            set { data._lft = value; }
        }

        private int _rgt = 0;
        public int rgt
        {
            get { return data._rgt; }
            set { data._rgt = value; }
        }

        public string old_parent
        {
            get { return data.old_parent; }
            set { data.old_parent = value; }
        }


    }

    //Enums go here

}