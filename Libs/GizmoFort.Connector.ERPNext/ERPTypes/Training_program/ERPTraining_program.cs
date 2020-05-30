using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Training_program
{
    public class ERPTraining_program : ERPNextObjectBase
    {
        public ERPTraining_program() : this(new ERPObject(DocType.Training_program)) { }
        public ERPTraining_program(ERPObject obj) : base(obj) { }

        public static ERPTraining_program Create(string trainingprogram, Status status, string company, string trainername, string traineremail, string supplier, string contactnumber, string description, string amendedfrom)

        {
            ERPTraining_program obj = new ERPTraining_program();
            obj.training_program = trainingprogram;
            obj.status = status;
            obj.company = company;
            obj.trainer_name = trainername;
            obj.trainer_email = traineremail;
            obj.supplier = supplier;
            obj.contact_number = contactnumber;
            obj.description = description;
            obj.amended_from = amendedfrom;
            return obj;
        }

        public string training_program
        {
            get { return data.training_program; }
            set
            {
                data.training_program = value;
                data.name = value;
            }

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

        public string trainer_name
        {
            get { return data.trainer_name; }
            set { data.trainer_name = value; }
        }

        public string trainer_email
        {
            get { return data.trainer_email; }
            set { data.trainer_email = value; }
        }

        public string supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        public string contact_number
        {
            get { return data.contact_number; }
            set { data.contact_number = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Scheduled")]
        Scheduled,
        [Description("Completed")]
        Completed,
        [Description("Cancelled")]
        Cancelled,
    }


}