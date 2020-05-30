using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_type
{
    public class Leave_typeService : SubServiceBase<ERPLeave_type>
    {
        public Leave_typeService(ERPNextClient client)
            : base(DocType.Leave_type, client) { }

        protected override ERPLeave_type fromERPObject(ERPObject obj)
        {
            return new ERPLeave_type(obj);
        }
    }
}