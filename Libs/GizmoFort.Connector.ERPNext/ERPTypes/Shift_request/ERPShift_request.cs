using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Shift_request
{
    public class ERPShift_request : ERPNextObjectBase
    {
        public ERPShift_request() : this(new ERPObject(DocType.Shift_request)) { }
        public ERPShift_request(ERPObject obj) : base(obj) { }

        public static ERPShift_request Create(string employeename, string shifttype, string employee, string department, string company, string fromdate, string todate, string amendedfrom)

        {
            ERPShift_request obj = new ERPShift_request();
            obj.employee_name = employeename;
            obj.shift_type = shifttype;
            obj.employee = employee;
            obj.department = department;
            obj.company = company;
            obj.from_date = fromdate;
            obj.to_date = todate;
            obj.amended_from = amendedfrom;
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

        public string shift_type
        {
            get { return data.shift_type; }
            set { data.shift_type = value; }
        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
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

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}