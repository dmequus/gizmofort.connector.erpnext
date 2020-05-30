using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Salary_component_account
{
    public class ERPSalary_component_account : ERPNextObjectBase
    {
        public ERPSalary_component_account() : this(new ERPObject(DocType.Salary_component_account)) { }
        public ERPSalary_component_account(ERPObject obj) : base(obj) { }

        public static ERPSalary_component_account Create(string company, string defaultaccount)

        {
            ERPSalary_component_account obj = new ERPSalary_component_account();
            obj.company = company;
            obj.default_account = defaultaccount;
            return obj;
        }

        public string company
        {
            get { return data.company; }
            set
            {
                data.company = value;
                data.name = value;
            }

        }

        public string default_account
        {
            get { return data.default_account; }
            set { data.default_account = value; }
        }


    }

    //Enums go here

}