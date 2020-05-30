using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Fee_schedule
{
    public class ERPFee_schedule : ERPNextObjectBase
    {
        public ERPFee_schedule() : this(new ERPObject(DocType.Fee_schedule)) { }
        public ERPFee_schedule(ERPObject obj) : base(obj) { }

        public static ERPFee_schedule Create(string feestructure, string duedate, string academicyear, string studentgroups)

        {
            ERPFee_schedule obj = new ERPFee_schedule();
            obj.fee_structure = feestructure;
            obj.due_date = duedate;
            obj.academic_year = academicyear;
            obj.student_groups = studentgroups;
            return obj;
        }

        public string fee_structure
        {
            get { return data.fee_structure; }
            set
            {
                data.fee_structure = value;
                data.name = value;
            }

        }

        public string due_date
        {
            get { return data.due_date; }
            set { data.due_date = value; }
        }

        public string academic_year
        {
            get { return data.academic_year; }
            set { data.academic_year = value; }
        }

        public string student_groups
        {
            get { return data.student_groups; }
            set { data.student_groups = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public Feecreationstatus fee_creation_status
        {
            get { return parseEnum<Feecreationstatus>(data.fee_creation_status); }
            set { data.fee_creation_status = value.ToString(); }
        }

        private int _send_email = 0;
        public int send_email
        {
            get { return data._send_email; }
            set { data._send_email = value; }
        }

        public string student_category
        {
            get { return data.student_category; }
            set { data.student_category = value; }
        }

        public string program
        {
            get { return data.program; }
            set { data.program = value; }
        }

        public string academic_term
        {
            get { return data.academic_term; }
            set { data.academic_term = value; }
        }

        public string currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        public string components
        {
            get { return data.components; }
            set { data.components = value; }
        }

        private double _total_amount = 0.0;
        public double total_amount
        {
            get { return data._total_amount; }
            set { data._total_amount = value; }
        }

        private double _grand_total = 0.0;
        public double grand_total
        {
            get { return data._grand_total; }
            set { data._grand_total = value; }
        }

        public string grand_total_in_words
        {
            get { return data.grand_total_in_words; }
            set { data.grand_total_in_words = value; }
        }

        public string letter_head
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
        }

        public string select_print_heading
        {
            get { return data.select_print_heading; }
            set { data.select_print_heading = value; }
        }

        public string receivable_account
        {
            get { return data.receivable_account; }
            set { data.receivable_account = value; }
        }

        public string income_account
        {
            get { return data.income_account; }
            set { data.income_account = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string error_log
        {
            get { return data.error_log; }
            set { data.error_log = value; }
        }


    }

    //Enums go here
    public enum Feecreationstatus
    {
        [Description("In Process")]
        InProcess,
        [Description("Failed")]
        Failed,
        [Description("Successful")]
        Successful,
    }


}