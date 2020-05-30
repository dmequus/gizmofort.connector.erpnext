using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Lab_test_template
{
    public class Lab_test_templateService : SubServiceBase<ERPLab_test_template>
    {
        public Lab_test_templateService(ERPNextClient client)
            : base(DocType.Lab_test_template, client) { }

        protected override ERPLab_test_template fromERPObject(ERPObject obj)
        {
            return new ERPLab_test_template(obj);
        }
    }
}