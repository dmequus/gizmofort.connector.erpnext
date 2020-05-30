using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Special_test_items
{
    public class Special_test_itemsService : SubServiceBase<ERPSpecial_test_items>
    {
        public Special_test_itemsService(ERPNextClient client)
            : base(DocType.Special_test_items, client) { }

        protected override ERPSpecial_test_items fromERPObject(ERPObject obj)
        {
            return new ERPSpecial_test_items(obj);
        }
    }
}