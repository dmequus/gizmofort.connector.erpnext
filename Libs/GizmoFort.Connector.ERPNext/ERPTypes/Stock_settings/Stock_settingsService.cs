using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock_settings
{
    public class Stock_settingsService : SubServiceBase<ERPStock_settings>
    {
        public Stock_settingsService(ERPNextClient client)
            : base(DocType.Stock_settings, client) { }

        protected override ERPStock_settings fromERPObject(ERPObject obj)
        {
            return new ERPStock_settings(obj);
        }
    }
}