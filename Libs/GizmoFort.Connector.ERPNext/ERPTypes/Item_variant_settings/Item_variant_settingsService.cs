using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_variant_settings
{
    public class Item_variant_settingsService : SubServiceBase<ERPItem_variant_settings>
    {
        public Item_variant_settingsService(ERPNextClient client)
            : base(DocType.Item_variant_settings, client) { }

        protected override ERPItem_variant_settings fromERPObject(ERPObject obj)
        {
            return new ERPItem_variant_settings(obj);
        }
    }
}