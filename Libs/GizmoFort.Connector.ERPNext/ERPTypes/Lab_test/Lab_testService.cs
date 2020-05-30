using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Lab_test
{
    public class Lab_testService : SubServiceBase<ERPLab_test>
    {
        public Lab_testService(ERPNextClient client)
            : base(DocType.Lab_test, client) { }

        protected override ERPLab_test fromERPObject(ERPObject obj)
        {
            return new ERPLab_test(obj);
        }
    }
}