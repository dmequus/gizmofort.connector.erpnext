using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_policy
{
    public class ERPLeave_policy : ERPNextObjectBase
    {
        public ERPLeave_policy() : this(new ERPObject(DocType.Leave_policy)) { }
        public ERPLeave_policy(ERPObject obj) : base(obj) { }

        public static ERPLeave_policy Create(string leavepolicydetails, string amendedfrom)

        {
            ERPLeave_policy obj = new ERPLeave_policy();
            obj.leave_policy_details = leavepolicydetails;
            obj.amended_from = amendedfrom;
            return obj;
        }

        public string leave_policy_details
        {
            get { return data.leave_policy_details; }
            set
            {
                data.leave_policy_details = value;
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