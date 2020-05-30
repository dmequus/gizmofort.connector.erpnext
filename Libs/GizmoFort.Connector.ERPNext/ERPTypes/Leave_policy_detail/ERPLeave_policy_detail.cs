using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_policy_detail
{
    public class ERPLeave_policy_detail : ERPNextObjectBase
    {
        public ERPLeave_policy_detail() : this(new ERPObject(DocType.Leave_policy_detail)) { }
        public ERPLeave_policy_detail(ERPObject obj) : base(obj) { }

        public static ERPLeave_policy_detail Create(string leavetype, double annualallocation)

        {
            ERPLeave_policy_detail obj = new ERPLeave_policy_detail();
            obj.leave_type = leavetype;
            obj.annual_allocation = annualallocation;
            return obj;
        }

        public string leave_type
        {
            get { return data.leave_type; }
            set
            {
                data.leave_type = value;
                data.name = value;
            }

        }

        public double annual_allocation
        {
            get { return data.annual_allocation; }
            set { data.annual_allocation = value; }
        }


    }

    //Enums go here

}