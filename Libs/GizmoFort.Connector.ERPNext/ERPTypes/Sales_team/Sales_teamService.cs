using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_team
{
    public class Sales_teamService : SubServiceBase<ERPSales_team>
    {
        public Sales_teamService(ERPNextClient client)
            : base(DocType.Sales_team, client) { }

        protected override ERPSales_team fromERPObject(ERPObject obj)
        {
            return new ERPSales_team(obj);
        }
    }
}