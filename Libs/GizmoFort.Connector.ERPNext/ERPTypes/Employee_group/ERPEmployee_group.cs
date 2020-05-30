using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_group
{
    public class ERPEmployee_group : ERPNextObjectBase
    {
        public ERPEmployee_group() : this(new ERPObject(DocType.Employee_group)) { }
        public ERPEmployee_group(ERPObject obj) : base(obj) { }

        public static ERPEmployee_group Create(string employeegroupname, string employeelist)

        {
            ERPEmployee_group obj = new ERPEmployee_group();
            obj.employee_group_name = employeegroupname;
            obj.employee_list = employeelist;
            return obj;
        }

        public string employee_group_name
        {
            get { return data.employee_group_name; }
            set
            {
                data.employee_group_name = value;
                data.name = value;
            }

        }

        public string employee_list
        {
            get { return data.employee_list; }
            set { data.employee_list = value; }
        }


    }

    //Enums go here

}