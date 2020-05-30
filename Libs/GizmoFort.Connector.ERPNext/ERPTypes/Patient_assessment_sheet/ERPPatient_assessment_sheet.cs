using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_assessment_sheet
{
    public class ERPPatient_assessment_sheet : ERPNextObjectBase
    {
        public ERPPatient_assessment_sheet() : this(new ERPObject(DocType.Patient_assessment_sheet)) { }
        public ERPPatient_assessment_sheet(ERPObject obj) : base(obj) { }

        public static ERPPatient_assessment_sheet Create(string parameter, string score)

        {
            ERPPatient_assessment_sheet obj = new ERPPatient_assessment_sheet();
            obj.parameter = parameter;
            obj.score = score;
            return obj;
        }

        public string parameter
        {
            get { return data.parameter; }
            set
            {
                data.parameter = value;
                data.name = value;
            }

        }

        public string score
        {
            get { return data.score; }
            set { data.score = value; }
        }

        public string time
        {
            get { return data.time; }
            set { data.time = value; }
        }

        public string comments
        {
            get { return data.comments; }
            set { data.comments = value; }
        }


    }

    //Enums go here

}