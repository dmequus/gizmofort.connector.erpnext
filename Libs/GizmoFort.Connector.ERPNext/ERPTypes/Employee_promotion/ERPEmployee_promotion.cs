using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_promotion
{
    public class ERPEmployee_promotion : ERPNextObjectBase
    {
        public ERPEmployee_promotion() : this(new ERPObject(DocType.Employee_promotion)) { }
        public ERPEmployee_promotion(ERPObject obj) : base(obj) { }

        public static ERPEmployee_promotion Create(string employeename, string employee, string department, string promotiondate, string company, string promotiondetails, string amendedfrom)

        {
            ERPEmployee_promotion obj = new ERPEmployee_promotion();
            obj.employee_name = employeename;
            obj.employee = employee;
            obj.department = department;
            obj.promotion_date = promotiondate;
            obj.company = company;
            obj.promotion_details = promotiondetails;
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

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string promotion_date
        {
            get { return data.promotion_date; }
            set { data.promotion_date = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string promotion_details
        {
            get { return data.promotion_details; }
            set { data.promotion_details = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}