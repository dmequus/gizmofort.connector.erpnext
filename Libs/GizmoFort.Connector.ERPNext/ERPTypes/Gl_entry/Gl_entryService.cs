using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Gl_entry
{
    public class Gl_entryService : SubServiceBase<ERPGl_entry>
    {
        public Gl_entryService(ERPNextClient client)
            : base(DocType.Gl_entry, client) { }

        protected override ERPGl_entry fromERPObject(ERPObject obj)
        {
            return new ERPGl_entry(obj);
        }
    }
}