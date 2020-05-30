using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_onboarding_activity
{
    public class ERPEmployee_onboarding_activity : ERPNextObjectBase
    {
        public ERPEmployee_onboarding_activity() : this(new ERPObject(DocType.Employee_onboarding_activity)) { }
        public ERPEmployee_onboarding_activity(ERPObject obj) : base(obj) { }

        public static ERPEmployee_onboarding_activity Create(string activityname, string user, string role, long completed, long requiredforemployeecreation, string description)

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

        public long completed
        {
            get { return data.completed; }
            set { data.completed = value; }
        }

        public long required_for_employee_creation
        {
            get { return data.required_for_employee_creation; }
            set { data.required_for_employee_creation = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here

}