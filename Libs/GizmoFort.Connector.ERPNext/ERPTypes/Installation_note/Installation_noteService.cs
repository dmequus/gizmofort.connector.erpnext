using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Installation_note
{
    public class Installation_noteService : SubServiceBase<ERPInstallation_note>
    {
        public Installation_noteService(ERPNextClient client)
            : base(DocType.Installation_note, client) { }

        protected override ERPInstallation_note fromERPObject(ERPObject obj)
        {
            return new ERPInstallation_note(obj);
        }
    }
}