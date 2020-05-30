using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Job_applicant
{
    public class ERPJob_applicant : ERPNextObjectBase
    {
        public ERPJob_applicant() : this(new ERPObject(DocType.Job_applicant)) { }
        public ERPJob_applicant(ERPObject obj) : base(obj) { }

        public static ERPJob_applicant Create(string applicantname, string emailid, Status status)

        {
            ERPJob_applicant obj = new ERPJob_applicant();
            obj.applicant_name = applicantname;
            obj.email_id = emailid;
            obj.status = status;
            return obj;
        }

        public string applicant_name
        {
            get { return data.applicant_name; }
            set
            {
                data.applicant_name = value;
                data.name = value;
            }

        }

        public string email_id
        {
            get { return data.email_id; }
            set { data.email_id = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string job_title
        {
            get { return data.job_title; }
            set { data.job_title = value; }
        }

        public string source
        {
            get { return data.source; }
            set { data.source = value; }
        }

        public string source_name
        {
            get { return data.source_name; }
            set { data.source_name = value; }
        }

        public string cover_letter
        {
            get { return data.cover_letter; }
            set { data.cover_letter = value; }
        }

        public string resume_attachment
        {
            get { return data.resume_attachment; }
            set { data.resume_attachment = value; }
        }

        public string notes
        {
            get { return data.notes; }
            set { data.notes = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Open")]
        Open,
        [Description("Replied")]
        Replied,
        [Description("Rejected")]
        Rejected,
        [Description("Hold")]
        Hold,
        [Description("Accepted")]
        Accepted,
    }


}