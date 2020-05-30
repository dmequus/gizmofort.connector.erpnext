using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Opportunity_type
{
    public class ERPOpportunity_type : ERPNextObjectBase
    {
        public ERPOpportunity_type() : this(new ERPObject(DocType.Opportunity_type)) { }
        public ERPOpportunity_type(ERPObject obj) : base(obj) { }

        public static ERPOpportunity_type Create(string description)

        {
            ERPOpportunity_type obj = new ERPOpportunity_type();
            obj.description = description;
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