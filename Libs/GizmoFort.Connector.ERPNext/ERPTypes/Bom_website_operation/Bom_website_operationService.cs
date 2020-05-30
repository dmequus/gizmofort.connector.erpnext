using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bom_website_operation
{
    public class Bom_website_operationService : SubServiceBase<ERPBom_website_operation>
    {
        public Bom_website_operationService(ERPNextClient client)
            : base(DocType.Bom_website_operation, client) { }

        protected override ERPBom_website_operation fromERPObject(ERPObject obj)
        {
            return new ERPBom_website_operation(obj);
        }
    }
}