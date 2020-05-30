using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_value_adjustment
{
    public class Asset_value_adjustmentService : SubServiceBase<ERPAsset_value_adjustment>
    {
        public Asset_value_adjustmentService(ERPNextClient client)
            : base(DocType.Asset_value_adjustment, client) { }

        protected override ERPAsset_value_adjustment fromERPObject(ERPObject obj)
        {
            return new ERPAsset_value_adjustment(obj);
        }
    }
}