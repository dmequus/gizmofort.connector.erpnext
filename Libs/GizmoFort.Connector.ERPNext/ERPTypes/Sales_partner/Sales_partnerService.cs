using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_partner
{
    public class Sales_partnerService : SubServiceBase<ERPSales_partner>
    {
        public Sales_partnerService(ERPNextClient client)
            : base(DocType.Sales_partner, client) { }

        protected override ERPSales_partner fromERPObject(ERPObject obj)
        {
            return new ERPSales_partner(obj);
        }
    }
}