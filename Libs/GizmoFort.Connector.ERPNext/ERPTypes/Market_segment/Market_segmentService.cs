using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Market_segment
{
    public class Market_segmentService : SubServiceBase<ERPMarket_segment>
    {
        public Market_segmentService(ERPNextClient client)
            : base(DocType.Market_segment, client) { }

        protected override ERPMarket_segment fromERPObject(ERPObject obj)
        {
            return new ERPMarket_segment(obj);
        }
    }
}