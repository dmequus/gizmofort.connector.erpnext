using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_onboarding_activity
{
    public class ERPEmployee_onboarding_activity : ERPNextObjectBase
    {
        public ERPEmployee_onboarding_activity() : this(new ERPObject(DocType.Employee_onboarding_activity)) { }
        public ERPEmployee_onboarding_activity(ERPObject obj) : base(obj) { }

        public static ERPEmployee_onboarding_activity Create(string activityname, string user, string role, int completed, int requiredforemployeecreation, string description)

        {
            ERPEmployee_onboarding_activity obj = new ERPEmployee_onboarding_activity();
            obj.activity_name = activityname;
            obj.user = user;
            obj.role = role;
            obj.completed = completed;
            obj.required_for_employee_creation = requiredforemployeecreation;
            obj.description = description;
            return obj;
        }

        public string activity_name
        {
            get { return data.activity_name; }
            set
            {
                data.activity_name = value;
                data.name = value;
            }

        }

        public string user
        {
            get { return data.user; }
            set { data.user = value; }
        }

        public string role
        {
            get { return data.role; }
            set { data.role = value; }
        }

        private int _completed = 0;
        public int completed
        {
            get { return data._completed; }
            set { data._completed = value; }
        }

        private int _required_for_employee_creation = 0;
        public int required_for_employee_creation
        {
            get { return data._required_for_employee_creation; }
            set { data._required_for_employee_creation = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here

}