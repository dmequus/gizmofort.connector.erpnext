using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounting_dimension_detail
{
    public class Accounting_dimension_detailService : SubServiceBase<ERPAccounting_dimension_detail>
    {
        public Accounting_dimension_detailService(ERPNextClient client)
            : base(DocType.Accounting_dimension_detail, client) { }

        protected override ERPAccounting_dimension_detail fromERPObject(ERPObject obj)
        {
            return new ERPAccounting_dimension_detail(obj);
        }
    }
}