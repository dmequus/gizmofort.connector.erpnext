using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Loyalty_point_entry_redemption
{
    public class Loyalty_point_entry_redemptionService : SubServiceBase<ERPLoyalty_point_entry_redemption>
    {
        public Loyalty_point_entry_redemptionService(ERPNextClient client)
            : base(DocType.Loyalty_point_entry_redemption, client) { }

        protected override ERPLoyalty_point_entry_redemption fromERPObject(ERPObject obj)
        {
            return new ERPLoyalty_point_entry_redemption(obj);
        }
    }
}