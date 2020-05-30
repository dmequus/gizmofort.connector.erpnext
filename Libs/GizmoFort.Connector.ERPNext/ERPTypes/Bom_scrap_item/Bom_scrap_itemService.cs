using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bom_scrap_item
{
    public class Bom_scrap_itemService : SubServiceBase<ERPBom_scrap_item>
    {
        public Bom_scrap_itemService(ERPNextClient client)
            : base(DocType.Bom_scrap_item, client) { }

        protected override ERPBom_scrap_item fromERPObject(ERPObject obj)
        {
            return new ERPBom_scrap_item(obj);
        }
    }
}