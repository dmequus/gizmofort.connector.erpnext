using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Ca_plan_comptable_pour_les_provinces_francophones
{
    public class Ca_plan_comptable_pour_les_provinces_francophonesService : SubServiceBase<ERPCa_plan_comptable_pour_les_provinces_francophones>
    {
        public Ca_plan_comptable_pour_les_provinces_francophonesService(ERPNextClient client)
            : base(DocType.Ca_plan_comptable_pour_les_provinces_francophones, client) { }

        protected override ERPCa_plan_comptable_pour_les_provinces_francophones fromERPObject(ERPObject obj)
        {
            return new ERPCa_plan_comptable_pour_les_provinces_francophones(obj);
        }
    }
}