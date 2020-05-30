using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sensitivity_test_items
{
    public class Sensitivity_test_itemsService : SubServiceBase<ERPSensitivity_test_items>
    {
        public Sensitivity_test_itemsService(ERPNextClient client)
            : base(DocType.Sensitivity_test_items, client) { }

        protected override ERPSensitivity_test_items fromERPObject(ERPObject obj)
        {
            return new ERPSensitivity_test_items(obj);
        }
    }
}