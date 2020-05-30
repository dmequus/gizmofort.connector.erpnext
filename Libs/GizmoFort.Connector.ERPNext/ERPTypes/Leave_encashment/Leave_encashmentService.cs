using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_encashment
{
    public class Leave_encashmentService : SubServiceBase<ERPLeave_encashment>
    {
        public Leave_encashmentService(ERPNextClient client)
            : base(DocType.Leave_encashment, client) { }

        protected override ERPLeave_encashment fromERPObject(ERPObject obj)
        {
            return new ERPLeave_encashment(obj);
        }
    }
}