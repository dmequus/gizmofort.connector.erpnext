using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Issue_priority
{
    public class ERPIssue_priority : ERPNextObjectBase
    {
        public ERPIssue_priority() : this(new ERPObject(DocType.Issue_priority)) { }
        public ERPIssue_priority(ERPObject obj) : base(obj) { }

        public static ERPIssue_priority Create()

        {
            ERPIssue_priority obj = new ERPIssue_priority();
            return obj;
        }

        public string description
        {
            get { return data.description; }
            set
            {
                data.description = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}