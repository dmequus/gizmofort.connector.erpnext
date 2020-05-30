using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Contract_fulfilment_checklist
{
    public class Contract_fulfilment_checklistService : SubServiceBase<ERPContract_fulfilment_checklist>
    {
        public Contract_fulfilment_checklistService(ERPNextClient client)
            : base(DocType.Contract_fulfilment_checklist, client) { }

        protected override ERPContract_fulfilment_checklist fromERPObject(ERPObject obj)
        {
            return new ERPContract_fulfilment_checklist(obj);
        }
    }
}