using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Department
{
    public class ERPDepartment : ERPNextObjectBase
    {
        public ERPDepartment() : this(new ERPObject(DocType.Department)) { }
        public ERPDepartment(ERPObject obj) : base(obj) { }

        public static ERPDepartment Create(string departmentname, string company)

        {
            ERPDepartment obj = new ERPDepartment();
            obj.department_name = departmentname;
            obj.company = company;
            return obj;
        }

        public string department_name
        {
            get { return data.department_name; }
            set
            {
                data.department_name = value;
                data.name = value;
            }

        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string parent_department
        {
            get { return data.parent_department; }
            set { data.parent_department = value; }
        }

        public long is_group
        {
            get { return data.is_group; }
            set { data.is_group = value; }
        }

        public long disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        public string leave_block_list
        {
            get { return data.leave_block_list; }
            set { data.leave_block_list = value; }
        }

        public string leave_approvers
        {
            get { return data.leave_approvers; }
            set { data.leave_approvers = value; }
        }

        public string expense_approvers
        {
            get { return data.expense_approvers; }
            set { data.expense_approvers = value; }
        }

        public int lft
        {
            get { return data.lft; }
            set { data.lft = value; }
        }

        public int rgt
        {
            get { return data.rgt; }
            set { data.rgt = value; }
        }

        public string old_parent
        {
            get { return data.old_parent; }
            set { data.old_parent = value; }
        }

        public string payroll_cost_center
        {
            get { return data.payroll_cost_center; }
            set { data.payroll_cost_center = value; }
        }


    }

    //Enums go here

}