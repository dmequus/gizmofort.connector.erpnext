using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Normal_test_template
{
    public class Normal_test_templateService : SubServiceBase<ERPNormal_test_template>
    {
        public Normal_test_templateService(ERPNextClient client)
            : base(DocType.Normal_test_template, client) { }

        protected override ERPNormal_test_template fromERPObject(ERPObject obj)
        {
            return new ERPNormal_test_template(obj);
        }
    }
}