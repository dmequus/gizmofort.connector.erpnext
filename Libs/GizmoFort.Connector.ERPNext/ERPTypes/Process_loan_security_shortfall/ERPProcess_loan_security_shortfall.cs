using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Process_loan_security_shortfall
{
    public class ERPProcess_loan_security_shortfall : ERPNextObjectBase
    {
        public ERPProcess_loan_security_shortfall() : this(new ERPObject(DocType.Process_loan_security_shortfall)) { }
        public ERPProcess_loan_security_shortfall(ERPObject obj) : base(obj) { }

        public static ERPProcess_loan_security_shortfall Create(string updatetime)

        {
            ERPProcess_loan_security_shortfall obj = new ERPProcess_loan_security_shortfall();
            obj.update_time = updatetime;
            return obj;
        }

        public string update_time
        {
            get { return data.update_time; }
            set
            {
                data.update_time = value;
                data.name = value;
            }

        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}