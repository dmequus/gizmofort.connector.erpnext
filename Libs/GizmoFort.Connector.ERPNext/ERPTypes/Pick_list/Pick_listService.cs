using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pick_list
{
    public class Pick_listService : SubServiceBase<ERPPick_list>
    {
        public Pick_listService(ERPNextClient client)
            : base(DocType.Pick_list, client) { }

        protected override ERPPick_list fromERPObject(ERPObject obj)
        {
            return new ERPPick_list(obj);
        }
    }
}