using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Job_card
{
    public class Job_cardService : SubServiceBase<ERPJob_card>
    {
        public Job_cardService(ERPNextClient client)
            : base(DocType.Job_card, client) { }

        protected override ERPJob_card fromERPObject(ERPObject obj)
        {
            return new ERPJob_card(obj);
        }
    }
}