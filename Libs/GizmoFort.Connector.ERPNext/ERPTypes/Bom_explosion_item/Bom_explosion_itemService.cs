using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bom_explosion_item
{
    public class Bom_explosion_itemService : SubServiceBase<ERPBom_explosion_item>
    {
        public Bom_explosion_itemService(ERPNextClient client)
            : base(DocType.Bom_explosion_item, client) { }

        protected override ERPBom_explosion_item fromERPObject(ERPObject obj)
        {
            return new ERPBom_explosion_item(obj);
        }
    }
}