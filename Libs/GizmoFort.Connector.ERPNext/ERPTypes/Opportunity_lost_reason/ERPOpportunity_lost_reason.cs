using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Opportunity_lost_reason
{
    public class ERPOpportunity_lost_reason : ERPNextObjectBase
    {
        public ERPOpportunity_lost_reason() : this(new ERPObject(DocType.Opportunity_lost_reason)) { }
        public ERPOpportunity_lost_reason(ERPObject obj) : base(obj) { }

        public static ERPOpportunity_lost_reason Create(string lostreason)

        {
            ERPOpportunity_lost_reason obj = new ERPOpportunity_lost_reason();
            obj.lost_reason = lostreason;
            return obj;
        }

        public string lost_reason
        {
            get { return data.lost_reason; }
            set
            {
                data.lost_reason = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}