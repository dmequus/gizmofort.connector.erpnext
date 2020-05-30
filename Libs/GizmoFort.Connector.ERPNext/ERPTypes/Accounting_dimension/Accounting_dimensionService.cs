using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounting_dimension
{
    public class Accounting_dimensionService : SubServiceBase<ERPAccounting_dimension>
    {
        public Accounting_dimensionService(ERPNextClient client)
            : base(DocType.Accounting_dimension, client) { }

        protected override ERPAccounting_dimension fromERPObject(ERPObject obj)
        {
            return new ERPAccounting_dimension(obj);
        }
    }
}