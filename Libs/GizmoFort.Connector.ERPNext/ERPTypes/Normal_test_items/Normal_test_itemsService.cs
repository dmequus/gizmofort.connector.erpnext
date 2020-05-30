using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Normal_test_items
{
    public class Normal_test_itemsService : SubServiceBase<ERPNormal_test_items>
    {
        public Normal_test_itemsService(ERPNextClient client)
            : base(DocType.Normal_test_items, client) { }

        protected override ERPNormal_test_items fromERPObject(ERPObject obj)
        {
            return new ERPNormal_test_items(obj);
        }
    }
}