using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Academic_term
{
    public class Academic_termService : SubServiceBase<ERPAcademic_term>
    {
        public Academic_termService(ERPNextClient client)
            : base(DocType.Academic_term, client) { }

        protected override ERPAcademic_term fromERPObject(ERPObject obj)
        {
            return new ERPAcademic_term(obj);
        }
    }
}