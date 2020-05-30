using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bom
{
    public class BomService : SubServiceBase<ERPBom>
    {
        public BomService(ERPNextClient client)
            : base(DocType.Bom, client) { }

        protected override ERPBom fromERPObject(ERPObject obj)
        {
            return new ERPBom(obj);
        }
    }
}