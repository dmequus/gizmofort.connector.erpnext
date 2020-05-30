using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_skill_map
{
    public class ERPEmployee_skill_map : ERPNextObjectBase
    {
        public ERPEmployee_skill_map() : this(new ERPObject(DocType.Employee_skill_map)) { }
        public ERPEmployee_skill_map(ERPObject obj) : base(obj) { }

        public static ERPEmployee_skill_map Create(string employeename)

        {
            ERPEmployee_skill_map obj = new ERPEmployee_skill_map();
            obj.employee_name = employeename;
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

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string designation
        {
            get { return data.designation; }
            set { data.designation = value; }
        }

        public string employee_skills
        {
            get { return data.employee_skills; }
            set { data.employee_skills = value; }
        }

        public string trainings
        {
            get { return data.trainings; }
            set { data.trainings = value; }
        }


    }

    //Enums go here

}