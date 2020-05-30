using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_transfer
{
    public class ERPEmployee_transfer : ERPNextObjectBase
    {
        public ERPEmployee_transfer() : this(new ERPObject(DocType.Employee_transfer)) { }
        public ERPEmployee_transfer(ERPObject obj) : base(obj) { }

        public static ERPEmployee_transfer Create(string employeename, string employee, string transferdate, string company, string newcompany, string department, string transferdetails, long reallocateleaves, long createnewemployeeid, string newemployeeid, string amendedfrom)

        {
            ERPEmployee_transfer obj = new ERPEmployee_transfer();
            obj.employee_name = employeename;
            obj.employee = employee;
            obj.transfer_date = transferdate;
            obj.company = company;
            obj.new_company = newcompany;
            obj.department = department;
            obj.transfer_details = transferdetails;
            obj.reallocate_leaves = reallocateleaves;
            obj.create_new_employee_id = createnewemployeeid;
            obj.new_employee_id = newemployeeid;
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

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string transfer_date
        {
            get { return data.transfer_date; }
            set { data.transfer_date = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string new_company
        {
            get { return data.new_company; }
            set { data.new_company = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string transfer_details
        {
            get { return data.transfer_details; }
            set { data.transfer_details = value; }
        }

        public long reallocate_leaves
        {
            get { return data.reallocate_leaves; }
            set { data.reallocate_leaves = value; }
        }

        public long create_new_employee_id
        {
            get { return data.create_new_employee_id; }
            set { data.create_new_employee_id = value; }
        }

        public string new_employee_id
        {
            get { return data.new_employee_id; }
            set { data.new_employee_id = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}