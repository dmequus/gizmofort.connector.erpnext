using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Job_offer
{
    public class Job_offerService : SubServiceBase<ERPJob_offer>
    {
        public Job_offerService(ERPNextClient client)
            : base(DocType.Job_offer, client) { }

        protected override ERPJob_offer fromERPObject(ERPObject obj)
        {
            return new ERPJob_offer(obj);
        }
    }
}