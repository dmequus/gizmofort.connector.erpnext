using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.De_kontenplan_SKR04
{
    public class De_kontenplan_SKR04Service : SubServiceBase<ERPDe_kontenplan_SKR04>
    {
        public De_kontenplan_SKR04Service(ERPNextClient client)
            : base(DocType.De_kontenplan_SKR04, client) { }

        protected override ERPDe_kontenplan_SKR04 fromERPObject(ERPObject obj)
        {
            return new ERPDe_kontenplan_SKR04(obj);
        }
    }
}