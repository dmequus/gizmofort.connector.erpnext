using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Fiscal_year_company
{
    public class Fiscal_year_companyService : SubServiceBase<ERPFiscal_year_company>
    {
        public Fiscal_year_companyService(ERPNextClient client)
            : base(DocType.Fiscal_year_company, client) { }

        protected override ERPFiscal_year_company fromERPObject(ERPObject obj)
        {
            return new ERPFiscal_year_company(obj);
        }
    }
}