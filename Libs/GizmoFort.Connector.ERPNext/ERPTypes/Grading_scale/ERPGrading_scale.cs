using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Grading_scale
{
    public class ERPGrading_scale : ERPNextObjectBase
    {
        public ERPGrading_scale() : this(new ERPObject(DocType.Grading_scale)) { }
        public ERPGrading_scale(ERPObject obj) : base(obj) { }

        public static ERPGrading_scale Create(string gradingscalename, string intervals, string amendedfrom, string description)

        {
            ERPGrading_scale obj = new ERPGrading_scale();
            obj.grading_scale_name = gradingscalename;
            obj.intervals = intervals;
            obj.amended_from = amendedfrom;
            obj.description = description;
            return obj;
        }

        public string grading_scale_name
        {
            get { return data.grading_scale_name; }
            set
            {
                data.grading_scale_name = value;
                data.name = value;
            }

        }

        public string intervals
        {
            get { return data.intervals; }
            set { data.intervals = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here

}