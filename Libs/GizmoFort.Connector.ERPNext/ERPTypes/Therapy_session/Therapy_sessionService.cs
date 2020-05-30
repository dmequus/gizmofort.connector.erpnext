using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Therapy_session
{
    public class Therapy_sessionService : SubServiceBase<ERPTherapy_session>
    {
        public Therapy_sessionService(ERPNextClient client)
            : base(DocType.Therapy_session, client) { }

        protected override ERPTherapy_session fromERPObject(ERPObject obj)
        {
            return new ERPTherapy_session(obj);
        }
    }
}