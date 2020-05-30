using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Therapy_plan
{
    public class ERPTherapy_plan : ERPNextObjectBase
    {
        public ERPTherapy_plan() : this(new ERPObject(DocType.Therapy_plan)) { }
        public ERPTherapy_plan(ERPObject obj) : base(obj) { }

        public static ERPTherapy_plan Create(string patient, string startdate, string therapyplandetails)

        {
            ERPTherapy_plan obj = new ERPTherapy_plan();
            obj.patient = patient;
            obj.start_date = startdate;
            obj.therapy_plan_details = therapyplandetails;
            return obj;
        }

        public string patient
        {
            get { return data.patient; }
            set
            {
                data.patient = value;
                data.name = value;
            }

        }

        public string start_date
        {
            get { return data.start_date; }
            set { data.start_date = value; }
        }

        public string therapy_plan_details
        {
            get { return data.therapy_plan_details; }
            set { data.therapy_plan_details = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string patient_name
        {
            get { return data.patient_name; }
            set { data.patient_name = value; }
        }

        public string title
        {
            get { return data.title; }
            set { data.title = value; }
        }

        public int total_sessions
        {
            get { return data.total_sessions; }
            set { data.total_sessions = value; }
        }

        public int total_sessions_completed
        {
            get { return data.total_sessions_completed; }
            set { data.total_sessions_completed = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Not Started")]
        NotStarted,
        [Description("In Progress")]
        InProgress,
        [Description("Completed")]
        Completed,
        [Description("Cancelled")]
        Cancelled,
    }


}