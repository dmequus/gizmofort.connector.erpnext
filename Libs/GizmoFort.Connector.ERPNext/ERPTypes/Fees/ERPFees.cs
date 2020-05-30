using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Fees
{
    public class ERPFees : ERPNextObjectBase
    {
        public ERPFees() : this(new ERPObject(DocType.Fees)) { }
        public ERPFees(ERPObject obj) : base(obj) { }

        public static ERPFees Create(string studentname, string student, string company, string postingdate, string duedate, string components, string receivableaccount)

        {
            ERPFees obj = new ERPFees();
            obj.student_name = studentname;
            obj.student = student;
            obj.company = company;
            obj.posting_date = postingdate;
            obj.due_date = duedate;
            obj.components = components;
            obj.receivable_account = receivableaccount;
            return obj;
        }

        public string student_name
        {
            get { return data.student_name; }
            set
            {
                data.student_name = value;
                data.name = value;
            }

        }

        public string student
        {
            get { return data.student; }
            set { data.student = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string due_date
        {
            get { return data.due_date; }
            set { data.due_date = value; }
        }

        public string components
        {
            get { return data.components; }
            set { data.components = value; }
        }

        public string receivable_account
        {
            get { return data.receivable_account; }
            set { data.receivable_account = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string fee_schedule
        {
            get { return data.fee_schedule; }
            set { data.fee_schedule = value; }
        }

        private int _include_payment = 0;
        public int include_payment
        {
            get { return data._include_payment; }
            set { data._include_payment = value; }
        }

        private int _send_payment_request = 0;
        public int send_payment_request
        {
            get { return data._send_payment_request; }
            set { data._send_payment_request = value; }
        }

        public string posting_time
        {
            get { return data.posting_time; }
            set { data.posting_time = value; }
        }

        private int _seta_posting_time = 0;
        public int seta_posting_time
        {
            get { return data._seta_posting_time; }
            set { data._seta_posting_time = value; }
        }

        public string program_enrollment
        {
            get { return data.program_enrollment; }
            set { data.program_enrollment = value; }
        }

        public string program
        {
            get { return data.program; }
            set { data.program = value; }
        }

        public string student_batch
        {
            get { return data.student_batch; }
            set { data.student_batch = value; }
        }

        public string student_email
        {
            get { return data.student_email; }
            set { data.student_email = value; }
        }

        public string student_category
        {
            get { return data.student_category; }
            set { data.student_category = value; }
        }

        public string academic_term
        {
            get { return data.academic_term; }
            set { data.academic_term = value; }
        }

        public string academic_year
        {
            get { return data.academic_year; }
            set { data.academic_year = value; }
        }

        public string currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        public string fee_structure
        {
            get { return data.fee_structure; }
            set { data.fee_structure = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
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

        private double _outstanding_amount = 0.0;
        public double outstanding_amount
        {
            get { return data._outstanding_amount; }
            set { data._outstanding_amount = value; }
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


    }

    //Enums go here

}