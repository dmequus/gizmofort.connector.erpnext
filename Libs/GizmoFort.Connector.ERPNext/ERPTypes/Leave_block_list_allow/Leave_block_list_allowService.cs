using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_block_list_allow
{
    public class Leave_block_list_allowService : SubServiceBase<ERPLeave_block_list_allow>
    {
        public Leave_block_list_allowService(ERPNextClient client)
            : base(DocType.Leave_block_list_allow, client) { }

        protected override ERPLeave_block_list_allow fromERPObject(ERPObject obj)
        {
            return new ERPLeave_block_list_allow(obj);
        }
    }
}