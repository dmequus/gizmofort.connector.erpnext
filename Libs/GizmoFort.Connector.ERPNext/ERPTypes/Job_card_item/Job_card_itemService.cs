using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Job_card_item
{
    public class Job_card_itemService : SubServiceBase<ERPJob_card_item>
    {
        public Job_card_itemService(ERPNextClient client)
            : base(DocType.Job_card_item, client) { }

        protected override ERPJob_card_item fromERPObject(ERPObject obj)
        {
            return new ERPJob_card_item(obj);
        }
    }
}