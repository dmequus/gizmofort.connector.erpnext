using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Issue_type
{
    public class ERPIssue_type : ERPNextObjectBase
    {
        public ERPIssue_type() : this(new ERPObject(DocType.Issue_type)) { }
        public ERPIssue_type(ERPObject obj) : base(obj) { }

        public static ERPIssue_type Create()

        {
            ERPIssue_type obj = new ERPIssue_type();
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