using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Staffing_plan
{
    public class ERPStaffing_plan : ERPNextObjectBase
    {
        public ERPStaffing_plan() : this(new ERPObject(DocType.Staffing_plan)) { }
        public ERPStaffing_plan(ERPObject obj) : base(obj) { }

        public static ERPStaffing_plan Create(string company, string department, string fromdate, string todate, string staffingdetails, double totalestimatedbudget, string amendedfrom)

        {
            ERPStaffing_plan obj = new ERPStaffing_plan();
            obj.company = company;
            obj.department = department;
            obj.from_date = fromdate;
            obj.to_date = todate;
            obj.staffing_details = staffingdetails;
            obj.total_estimated_budget = totalestimatedbudget;
            obj.amended_from = amendedfrom;
            return obj;
        }

        public string company
        {
            get { return data.company; }
            set
            {
                data.company = value;
                data.name = value;
            }

        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string from_date
        {
            get { return data.from_date; }
            set { data.from_date = value; }
        }

        public string to_date
        {
            get { return data.to_date; }
            set { data.to_date = value; }
        }

        public string staffing_details
        {
            get { return data.staffing_details; }
            set { data.staffing_details = value; }
        }

        private double _total_estimated_budget = 0.0;
        public double total_estimated_budget
        {
            get { return data._total_estimated_budget; }
            set { data._total_estimated_budget = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}