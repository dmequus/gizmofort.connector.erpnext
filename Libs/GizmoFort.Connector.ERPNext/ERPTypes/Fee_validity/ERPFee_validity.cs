using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Fee_validity
{
    public class ERPFee_validity : ERPNextObjectBase
    {
        public ERPFee_validity() : this(new ERPObject(DocType.Fee_validity)) { }
        public ERPFee_validity(ERPObject obj) : base(obj) { }

        public static ERPFee_validity Create(string practitioner, string patient)

        {
            ERPFee_validity obj = new ERPFee_validity();
            obj.practitioner = practitioner;
            obj.patient = patient;
            return obj;
        }

        public string practitioner
        {
            get { return data.practitioner; }
            set
            {
                data.practitioner = value;
                data.name = value;
            }

        }

        public string patient
        {
            get { return data.patient; }
            set { data.patient = value; }
        }

        public int visited
        {
            get { return data.visited; }
            set { data.visited = value; }
        }

        public string valid_till
        {
            get { return data.valid_till; }
            set { data.valid_till = value; }
        }

        public int max_visits
        {
            get { return data.max_visits; }
            set { data.max_visits = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string start_date
        {
            get { return data.start_date; }
            set { data.start_date = value; }
        }

        public string ref_appointments
        {
            get { return data.ref_appointments; }
            set { data.ref_appointments = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Completed")]
        Completed,
        [Description("Pending")]
        Pending,
    }


}