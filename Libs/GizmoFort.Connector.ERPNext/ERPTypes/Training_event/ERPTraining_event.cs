using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Training_event
{
    public class ERPTraining_event : ERPNextObjectBase
    {
        public ERPTraining_event() : this(new ERPObject(DocType.Training_event)) { }
        public ERPTraining_event(ERPObject obj) : base(obj) { }

        public static ERPTraining_event Create(string eventname, string trainingprogram, Eventstatus eventstatus, int hascertificate, Type type, Level level, string company, string trainername, string traineremail, string supplier, string contactnumber, string course, string location, string starttime, string endtime, string introduction, string employees, string amendedfrom, string employeeemails)

        {
            ERPTraining_event obj = new ERPTraining_event();
            obj.event_name = eventname;
            obj.training_program = trainingprogram;
            obj.event_status = eventstatus;
            obj.has_certificate = hascertificate;
            obj.type = type;
            obj.level = level;
            obj.company = company;
            obj.trainer_name = trainername;
            obj.trainer_email = traineremail;
            obj.supplier = supplier;
            obj.contact_number = contactnumber;
            obj.course = course;
            obj.location = location;
            obj.start_time = starttime;
            obj.end_time = endtime;
            obj.introduction = introduction;
            obj.employees = employees;
            obj.amended_from = amendedfrom;
            obj.employee_emails = employeeemails;
            return obj;
        }

        public string event_name
        {
            get { return data.event_name; }
            set
            {
                data.event_name = value;
                data.name = value;
            }

        }

        public string training_program
        {
            get { return data.training_program; }
            set { data.training_program = value; }
        }

        public Eventstatus event_status
        {
            get { return parseEnum<Eventstatus>(data.event_status); }
            set { data.event_status = value.ToString(); }
        }

        private int _has_certificate = 0;
        public int has_certificate
        {
            get { return data._has_certificate; }
            set { data._has_certificate = value; }
        }

        public Type type
        {
            get { return parseEnum<Type>(data.type); }
            set { data.type = value.ToString(); }
        }

        public Level level
        {
            get { return parseEnum<Level>(data.level); }
            set { data.level = value.ToString(); }
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

        public string course
        {
            get { return data.course; }
            set { data.course = value; }
        }

        public string location
        {
            get { return data.location; }
            set { data.location = value; }
        }

        public string start_time
        {
            get { return data.start_time; }
            set { data.start_time = value; }
        }

        public string end_time
        {
            get { return data.end_time; }
            set { data.end_time = value; }
        }

        public string introduction
        {
            get { return data.introduction; }
            set { data.introduction = value; }
        }

        public string employees
        {
            get { return data.employees; }
            set { data.employees = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string employee_emails
        {
            get { return data.employee_emails; }
            set { data.employee_emails = value; }
        }


    }

    //Enums go here
    public enum Eventstatus
    {
        [Description("Scheduled")]
        Scheduled,
        [Description("Completed")]
        Completed,
        [Description("Cancelled")]
        Cancelled,
    }

    public enum Type
    {
        [Description("Seminar")]
        Seminar,
        [Description("Theory")]
        Theory,
        [Description("Workshop")]
        Workshop,
        [Description("Conference")]
        Conference,
        [Description("Exam")]
        Exam,
        [Description("Internet")]
        Internet,
        [Description("Self-Study")]
        SelfStudy,
    }

    public enum Level
    {
        [Description("Beginner")]
        Beginner,
        [Description("Intermediate")]
        Intermediate,
        [Description("Advance")]
        Advance,
    }


}