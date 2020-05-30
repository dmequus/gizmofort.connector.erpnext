using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Job_opening
{
    public class ERPJob_opening : ERPNextObjectBase
    {
        public ERPJob_opening() : this(new ERPObject(DocType.Job_opening)) { }
        public ERPJob_opening(ERPObject obj) : base(obj) { }

        public static ERPJob_opening Create(string jobtitle, string company, Status status, string designation, string department, string staffingplan, int plannedvacancies, long publish, string route, string description)

        {
            ERPJob_opening obj = new ERPJob_opening();
            obj.job_title = jobtitle;
            obj.company = company;
            obj.status = status;
            obj.designation = designation;
            obj.department = department;
            obj.staffing_plan = staffingplan;
            obj.planned_vacancies = plannedvacancies;
            obj.publish = publish;
            obj.route = route;
            obj.description = description;
            return obj;
        }

        public string job_title
        {
            get { return data.job_title; }
            set
            {
                data.job_title = value;
                data.name = value;
            }

        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string designation
        {
            get { return data.designation; }
            set { data.designation = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string staffing_plan
        {
            get { return data.staffing_plan; }
            set { data.staffing_plan = value; }
        }

        public int planned_vacancies
        {
            get { return data.planned_vacancies; }
            set { data.planned_vacancies = value; }
        }

        public long publish
        {
            get { return data.publish; }
            set { data.publish = value; }
        }

        public string route
        {
            get { return data.route; }
            set { data.route = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Open")]
        Open,
        [Description("Closed")]
        Closed,
    }


}