using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quotation_lost_reason
{
    public class ERPQuotation_lost_reason : ERPNextObjectBase
    {
        public ERPQuotation_lost_reason() : this(new ERPObject(DocType.Quotation_lost_reason)) { }
        public ERPQuotation_lost_reason(ERPObject obj) : base(obj) { }

        public static ERPQuotation_lost_reason Create(string orderlostreason)

        {
            ERPQuotation_lost_reason obj = new ERPQuotation_lost_reason();
            obj.order_lost_reason = orderlostreason;
            return obj;
        }

        public string order_lost_reason
        {
            get { return data.order_lost_reason; }
            set
            {
                data.order_lost_reason = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}