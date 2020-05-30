using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Grading_scale_interval
{
    public class ERPGrading_scale_interval : ERPNextObjectBase
    {
        public ERPGrading_scale_interval() : this(new ERPObject(DocType.Grading_scale_interval)) { }
        public ERPGrading_scale_interval(ERPObject obj) : base(obj) { }

        public static ERPGrading_scale_interval Create(string gradecode, double threshold, string gradedescription)

        {
            ERPGrading_scale_interval obj = new ERPGrading_scale_interval();
            obj.grade_code = gradecode;
            obj.threshold = threshold;
            obj.grade_description = gradedescription;
            return obj;
        }

        public string grade_code
        {
            get { return data.grade_code; }
            set
            {
                data.grade_code = value;
                data.name = value;
            }

        }

        private double _threshold = 0.0;
        public double threshold
        {
            get { return data._threshold; }
            set { data._threshold = value; }
        }

        public string grade_description
        {
            get { return data.grade_description; }
            set { data.grade_description = value; }
        }


    }

    //Enums go here

}