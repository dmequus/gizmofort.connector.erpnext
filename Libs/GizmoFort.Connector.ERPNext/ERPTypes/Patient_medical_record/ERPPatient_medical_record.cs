using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_medical_record
{
    public class ERPPatient_medical_record : ERPNextObjectBase
    {
        public ERPPatient_medical_record() : this(new ERPObject(DocType.Patient_medical_record)) { }
        public ERPPatient_medical_record(ERPObject obj) : base(obj) { }

        public static ERPPatient_medical_record Create(string patient)

        {
            ERPPatient_medical_record obj = new ERPPatient_medical_record();
            obj.patient = patient;
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

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string attach
        {
            get { return data.attach; }
            set { data.attach = value; }
        }

        public string subject
        {
            get { return data.subject; }
            set { data.subject = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string communication_date
        {
            get { return data.communication_date; }
            set { data.communication_date = value; }
        }

        public string reference_doctype
        {
            get { return data.reference_doctype; }
            set { data.reference_doctype = value; }
        }

        public string reference_name
        {
            get { return data.reference_name; }
            set { data.reference_name = value; }
        }

        public string reference_owner
        {
            get { return data.reference_owner; }
            set { data.reference_owner = value; }
        }

        public string user
        {
            get { return data.user; }
            set { data.user = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Open")]
        Open,
        [Description("Close")]
        Close,
    }


}