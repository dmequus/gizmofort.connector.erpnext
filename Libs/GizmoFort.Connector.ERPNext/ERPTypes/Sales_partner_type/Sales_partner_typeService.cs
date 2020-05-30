using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_partner_type
{
    public class Sales_partner_typeService : SubServiceBase<ERPSales_partner_type>
    {
        public Sales_partner_typeService(ERPNextClient client)
            : base(DocType.Sales_partner_type, client) { }

        protected override ERPSales_partner_type fromERPObject(ERPObject obj)
        {
            return new ERPSales_partner_type(obj);
        }
    }
}