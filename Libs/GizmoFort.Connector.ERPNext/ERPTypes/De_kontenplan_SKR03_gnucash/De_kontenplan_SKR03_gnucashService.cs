using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.De_kontenplan_SKR03_gnucash
{
    public class De_kontenplan_SKR03_gnucashService : SubServiceBase<ERPDe_kontenplan_SKR03_gnucash>
    {
        public De_kontenplan_SKR03_gnucashService(ERPNextClient client)
            : base(DocType.De_kontenplan_SKR03_gnucash, client) { }

        protected override ERPDe_kontenplan_SKR03_gnucash fromERPObject(ERPObject obj)
        {
            return new ERPDe_kontenplan_SKR03_gnucash(obj);
        }
    }
}