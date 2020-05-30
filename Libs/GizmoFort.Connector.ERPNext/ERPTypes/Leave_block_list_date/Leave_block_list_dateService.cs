using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_block_list_date
{
    public class Leave_block_list_dateService : SubServiceBase<ERPLeave_block_list_date>
    {
        public Leave_block_list_dateService(ERPNextClient client)
            : base(DocType.Leave_block_list_date, client) { }

        protected override ERPLeave_block_list_date fromERPObject(ERPObject obj)
        {
            return new ERPLeave_block_list_date(obj);
        }
    }
}