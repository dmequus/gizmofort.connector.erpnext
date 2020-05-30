using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Uom
{
    public class UomService : SubServiceBase<ERPUom>
    {
        public UomService(ERPNextClient client)
            : base(DocType.Uom, client) { }

        protected override ERPUom fromERPObject(ERPObject obj)
        {
            return new ERPUom(obj);
        }
    }
}