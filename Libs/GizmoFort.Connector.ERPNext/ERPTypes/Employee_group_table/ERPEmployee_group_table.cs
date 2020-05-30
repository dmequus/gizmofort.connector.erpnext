using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_group_table
{
    public class ERPEmployee_group_table : ERPNextObjectBase
    {
        public ERPEmployee_group_table() : this(new ERPObject(DocType.Employee_group_table)) { }
        public ERPEmployee_group_table(ERPObject obj) : base(obj) { }

        public static ERPEmployee_group_table Create()

        {
            ERPEmployee_group_table obj = new ERPEmployee_group_table();
            return obj;
        }

        public string employee
        {
            get { return data.employee; }
            set
            {
                data.employee = value;
                data.name = value;
            }

        }

        public string employee_name
        {
            get { return data.employee_name; }
            set { data.employee_name = value; }
        }

        public string user_id
        {
            get { return data.user_id; }
            set { data.user_id = value; }
        }


    }

    //Enums go here

}