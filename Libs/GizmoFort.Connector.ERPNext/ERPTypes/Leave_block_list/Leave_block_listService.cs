using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_block_list
{
    public class Leave_block_listService : SubServiceBase<ERPLeave_block_list>
    {
        public Leave_block_listService(ERPNextClient client)
            : base(DocType.Leave_block_list, client) { }

        protected override ERPLeave_block_list fromERPObject(ERPObject obj)
        {
            return new ERPLeave_block_list(obj);
        }
    }
}