using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Uom_conversion_factor
{
    public class Uom_conversion_factorService : SubServiceBase<ERPUom_conversion_factor>
    {
        public Uom_conversion_factorService(ERPNextClient client)
            : base(DocType.Uom_conversion_factor, client) { }

        protected override ERPUom_conversion_factor fromERPObject(ERPObject obj)
        {
            return new ERPUom_conversion_factor(obj);
        }
    }
}