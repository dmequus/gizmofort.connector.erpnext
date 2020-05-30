using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_internal_work_history
{
    public class ERPEmployee_internal_work_history : ERPNextObjectBase
    {
        public ERPEmployee_internal_work_history() : this(new ERPObject(DocType.Employee_internal_work_history)) { }
        public ERPEmployee_internal_work_history(ERPObject obj) : base(obj) { }

        public static ERPEmployee_internal_work_history Create(string branch, string department, string designation, string fromdate, string todate)

        {
            ERPEmployee_internal_work_history obj = new ERPEmployee_internal_work_history();
            obj.branch = branch;
            obj.department = department;
            obj.designation = designation;
            obj.from_date = fromdate;
            obj.to_date = todate;
            return obj;
        }

        public string branch
        {
            get { return data.branch; }
            set
            {
                data.branch = value;
                data.name = value;
            }

        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string designation
        {
            get { return data.designation; }
            set { data.designation = value; }
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


    }

    //Enums go here

}