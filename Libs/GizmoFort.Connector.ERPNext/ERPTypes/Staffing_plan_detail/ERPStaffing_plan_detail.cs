using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Staffing_plan_detail
{
    public class ERPStaffing_plan_detail : ERPNextObjectBase
    {
        public ERPStaffing_plan_detail() : this(new ERPObject(DocType.Staffing_plan_detail)) { }
        public ERPStaffing_plan_detail(ERPObject obj) : base(obj) { }

        public static ERPStaffing_plan_detail Create(string designation)

        {
            ERPStaffing_plan_detail obj = new ERPStaffing_plan_detail();
            obj.designation = designation;
            return obj;
        }

        public string designation
        {
            get { return data.designation; }
            set
            {
                data.designation = value;
                data.name = value;
            }

        }

        public int number_of_positions
        {
            get { return data.number_of_positions; }
            set { data.number_of_positions = value; }
        }

        public double estimated_cost_per_position
        {
            get { return data.estimated_cost_per_position; }
            set { data.estimated_cost_per_position = value; }
        }

        public int current_count
        {
            get { return data.current_count; }
            set { data.current_count = value; }
        }

        public int current_openings
        {
            get { return data.current_openings; }
            set { data.current_openings = value; }
        }

        public int vacancies
        {
            get { return data.vacancies; }
            set { data.vacancies = value; }
        }

        public double total_estimated_cost
        {
            get { return data.total_estimated_cost; }
            set { data.total_estimated_cost = value; }
        }


    }

    //Enums go here

}