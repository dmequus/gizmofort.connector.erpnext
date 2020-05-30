using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.El_salvador_standard
{
    public class El_salvador_standardService : SubServiceBase<ERPEl_salvador_standard>
    {
        public El_salvador_standardService(ERPNextClient client)
            : base(DocType.El_salvador_standard, client) { }

        protected override ERPEl_salvador_standard fromERPObject(ERPObject obj)
        {
            return new ERPEl_salvador_standard(obj);
        }
    }
}