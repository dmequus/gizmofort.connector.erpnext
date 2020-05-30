using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Landed_cost_taxes_and_charges
{
    public class Landed_cost_taxes_and_chargesService : SubServiceBase<ERPLanded_cost_taxes_and_charges>
    {
        public Landed_cost_taxes_and_chargesService(ERPNextClient client)
            : base(DocType.Landed_cost_taxes_and_charges, client) { }

        protected override ERPLanded_cost_taxes_and_charges fromERPObject(ERPObject obj)
        {
            return new ERPLanded_cost_taxes_and_charges(obj);
        }
    }
}