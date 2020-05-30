using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Company
{
    public class CompanyService : SubServiceBase<ERPCompany>
    {
        public CompanyService(ERPNextClient client)
            : base(DocType.Company, client) { }

        protected override ERPCompany fromERPObject(ERPObject obj)
        {
            return new ERPCompany(obj);
        }
    }
}