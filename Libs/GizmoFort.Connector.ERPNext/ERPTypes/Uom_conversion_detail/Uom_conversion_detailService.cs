using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Uom_conversion_detail
{
    public class Uom_conversion_detailService : SubServiceBase<ERPUom_conversion_detail>
    {
        public Uom_conversion_detailService(ERPNextClient client)
            : base(DocType.Uom_conversion_detail, client) { }

        protected override ERPUom_conversion_detail fromERPObject(ERPObject obj)
        {
            return new ERPUom_conversion_detail(obj);
        }
    }
}