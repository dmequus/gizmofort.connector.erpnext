using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.De_kontenplan_SKR04_with_account_number
{
    public class De_kontenplan_SKR04_with_account_numberService : SubServiceBase<ERPDe_kontenplan_SKR04_with_account_number>
    {
        public De_kontenplan_SKR04_with_account_numberService(ERPNextClient client)
            : base(DocType.De_kontenplan_SKR04_with_account_number, client) { }

        protected override ERPDe_kontenplan_SKR04_with_account_number fromERPObject(ERPObject obj)
        {
            return new ERPDe_kontenplan_SKR04_with_account_number(obj);
        }
    }
}