using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Academic_year
{
    public class Academic_yearService : SubServiceBase<ERPAcademic_year>
    {
        public Academic_yearService(ERPNextClient client)
            : base(DocType.Academic_year, client) { }

        protected override ERPAcademic_year fromERPObject(ERPObject obj)
        {
            return new ERPAcademic_year(obj);
        }
    }
}