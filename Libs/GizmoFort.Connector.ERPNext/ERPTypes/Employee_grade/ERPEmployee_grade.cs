using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_grade
{
    public class ERPEmployee_grade : ERPNextObjectBase
    {
        public ERPEmployee_grade() : this(new ERPObject(DocType.Employee_grade)) { }
        public ERPEmployee_grade(ERPObject obj) : base(obj) { }

        public static ERPEmployee_grade Create(string defaultleavepolicy, string defaultsalarystructure)

        {
            ERPEmployee_grade obj = new ERPEmployee_grade();
            obj.default_leave_policy = defaultleavepolicy;
            obj.default_salary_structure = defaultsalarystructure;
            return obj;
        }

        public string default_leave_policy
        {
            get { return data.default_leave_policy; }
            set
            {
                data.default_leave_policy = value;
                data.name = value;
            }

        }

        public string default_salary_structure
        {
            get { return data.default_salary_structure; }
            set { data.default_salary_structure = value; }
        }


    }

    //Enums go here

}