using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Assessment_result_tool
{
    public class ERPAssessment_result_tool : ERPNextObjectBase
    {
        public ERPAssessment_result_tool() : this(new ERPObject(DocType.Assessment_result_tool)) { }
        public ERPAssessment_result_tool(ERPObject obj) : base(obj) { }

        public static ERPAssessment_result_tool Create(string assessmentplan, string studentgroup, string resulthtml)

        {
            ERPAssessment_result_tool obj = new ERPAssessment_result_tool();
            obj.assessment_plan = assessmentplan;
            obj.student_group = studentgroup;
            obj.result_html = resulthtml;
            return obj;
        }

        public string assessment_plan
        {
            get { return data.assessment_plan; }
            set
            {
                data.assessment_plan = value;
                data.name = value;
            }

        }

        public string student_group
        {
            get { return data.student_group; }
            set { data.student_group = value; }
        }

        public string result_html
        {
            get { return data.result_html; }
            set { data.result_html = value; }
        }


    }

    //Enums go here

}