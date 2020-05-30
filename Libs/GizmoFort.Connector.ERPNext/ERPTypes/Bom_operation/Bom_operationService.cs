using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bom_operation
{
    public class Bom_operationService : SubServiceBase<ERPBom_operation>
    {
        public Bom_operationService(ERPNextClient client)
            : base(DocType.Bom_operation, client) { }

        protected override ERPBom_operation fromERPObject(ERPObject obj)
        {
            return new ERPBom_operation(obj);
        }
    }
}