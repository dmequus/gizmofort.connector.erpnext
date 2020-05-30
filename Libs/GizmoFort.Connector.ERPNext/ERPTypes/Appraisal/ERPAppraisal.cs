using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Appraisal
{
    public class ERPAppraisal : ERPNextObjectBase
    {
        public ERPAppraisal() : this(new ERPObject(DocType.Appraisal)) { }
        public ERPAppraisal(ERPObject obj) : base(obj) { }

        public static ERPAppraisal Create(string employeename, string namingseries, string kratemplate, string employee, Status status, string startdate, string enddate, string department, string goals, double totalscore, string remarks, string company, string amendedfrom)

        {
            ERPAppraisal obj = new ERPAppraisal();
            obj.employee_name = employeename;
            obj.naming_series = namingseries;
            obj.kra_template = kratemplate;
            obj.employee = employee;
            obj.status = status;
            obj.start_date = startdate;
            obj.end_date = enddate;
            obj.department = department;
            obj.goals = goals;
            obj.total_score = totalscore;
            obj.remarks = remarks;
            obj.company = company;
            obj.amended_from = amendedfrom;
            return obj;
        }

        public string employee_name
        {
            get { return data.employee_name; }
            set
            {
                data.employee_name = value;
                data.name = value;
            }

        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string kra_template
        {
            get { return data.kra_template; }
            set { data.kra_template = value; }
        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
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

        public string end_date
        {
            get { return data.end_date; }
            set { data.end_date = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string goals
        {
            get { return data.goals; }
            set { data.goals = value; }
        }

        public double total_score
        {
            get { return data.total_score; }
            set { data.total_score = value; }
        }

        public string remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
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


    }

    //Enums go here
    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("Submitted")]
        Submitted,
        [Description("Completed")]
        Completed,
        [Description("Cancelled")]
        Cancelled,
    }


}