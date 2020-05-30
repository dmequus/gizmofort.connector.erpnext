using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_period
{
    public class Leave_periodService : SubServiceBase<ERPLeave_period>
    {
        public Leave_periodService(ERPNextClient client)
            : base(DocType.Leave_period, client) { }

        protected override ERPLeave_period fromERPObject(ERPObject obj)
        {
            return new ERPLeave_period(obj);
        }
    }
}