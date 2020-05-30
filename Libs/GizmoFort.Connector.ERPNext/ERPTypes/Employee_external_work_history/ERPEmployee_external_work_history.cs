using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_external_work_history
{
    public class ERPEmployee_external_work_history : ERPNextObjectBase
    {
        public ERPEmployee_external_work_history() : this(new ERPObject(DocType.Employee_external_work_history)) { }
        public ERPEmployee_external_work_history(ERPObject obj) : base(obj) { }

        public static ERPEmployee_external_work_history Create(string companyname, string designation, double salary, string address, string contact, string totalexperience)

        {
            ERPEmployee_external_work_history obj = new ERPEmployee_external_work_history();
            obj.company_name = companyname;
            obj.designation = designation;
            obj.salary = salary;
            obj.address = address;
            obj.contact = contact;
            obj.total_experience = totalexperience;
            return obj;
        }

        public string company_name
        {
            get { return data.company_name; }
            set
            {
                data.company_name = value;
                data.name = value;
            }

        }

        public string designation
        {
            get { return data.designation; }
            set { data.designation = value; }
        }

        private double _salary = 0.0;
        public double salary
        {
            get { return data._salary; }
            set { data._salary = value; }
        }

        public string address
        {
            get { return data.address; }
            set { data.address = value; }
        }

        public string contact
        {
            get { return data.contact; }
            set { data.contact = value; }
        }

        public string total_experience
        {
            get { return data.total_experience; }
            set { data.total_experience = value; }
        }


    }

    //Enums go here

}