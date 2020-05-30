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

        private int _number_of_positions = 0;
        public int number_of_positions
        {
            get { return data._number_of_positions; }
            set { data._number_of_positions = value; }
        }

        private double _estimated_cost_per_position = 0.0;
        public double estimated_cost_per_position
        {
            get { return data._estimated_cost_per_position; }
            set { data._estimated_cost_per_position = value; }
        }

        private int _current_count = 0;
        public int current_count
        {
            get { return data._current_count; }
            set { data._current_count = value; }
        }

        private int _current_openings = 0;
        public int current_openings
        {
            get { return data._current_openings; }
            set { data._current_openings = value; }
        }

        private int _vacancies = 0;
        public int vacancies
        {
            get { return data._vacancies; }
            set { data._vacancies = value; }
        }

        private double _total_estimated_cost = 0.0;
        public double total_estimated_cost
        {
            get { return data._total_estimated_cost; }
            set { data._total_estimated_cost = value; }
        }


    }

    //Enums go here

}