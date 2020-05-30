using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Special_test_template
{
    public class Special_test_templateService : SubServiceBase<ERPSpecial_test_template>
    {
        public Special_test_templateService(ERPNextClient client)
            : base(DocType.Special_test_template, client) { }

        protected override ERPSpecial_test_template fromERPObject(ERPObject obj)
        {
            return new ERPSpecial_test_template(obj);
        }
    }
}