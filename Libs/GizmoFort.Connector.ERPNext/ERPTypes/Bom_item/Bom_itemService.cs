using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bom_item
{
    public class Bom_itemService : SubServiceBase<ERPBom_item>
    {
        public Bom_itemService(ERPNextClient client)
            : base(DocType.Bom_item, client) { }

        protected override ERPBom_item fromERPObject(ERPObject obj)
        {
            return new ERPBom_item(obj);
        }
    }
}