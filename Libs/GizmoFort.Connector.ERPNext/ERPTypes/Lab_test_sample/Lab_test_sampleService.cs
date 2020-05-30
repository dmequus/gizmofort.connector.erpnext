using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Lab_test_sample
{
    public class Lab_test_sampleService : SubServiceBase<ERPLab_test_sample>
    {
        public Lab_test_sampleService(ERPNextClient client)
            : base(DocType.Lab_test_sample, client) { }

        protected override ERPLab_test_sample fromERPObject(ERPObject obj)
        {
            return new ERPLab_test_sample(obj);
        }
    }
}