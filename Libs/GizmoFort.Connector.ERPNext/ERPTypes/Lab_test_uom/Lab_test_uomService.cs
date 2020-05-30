using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Lab_test_uom
{
    public class Lab_test_uomService : SubServiceBase<ERPLab_test_uom>
    {
        public Lab_test_uomService(ERPNextClient client)
            : base(DocType.Lab_test_uom, client) { }

        protected override ERPLab_test_uom fromERPObject(ERPObject obj)
        {
            return new ERPLab_test_uom(obj);
        }
    }
}