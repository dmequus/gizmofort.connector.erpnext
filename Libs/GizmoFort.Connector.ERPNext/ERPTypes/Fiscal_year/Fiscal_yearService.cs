using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Fiscal_year
{
    public class Fiscal_yearService : SubServiceBase<ERPFiscal_year>
    {
        public Fiscal_yearService(ERPNextClient client)
            : base(DocType.Fiscal_year, client) { }

        protected override ERPFiscal_year fromERPObject(ERPObject obj)
        {
            return new ERPFiscal_year(obj);
        }
    }
}