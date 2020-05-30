using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Installation_note_item
{
    public class Installation_note_itemService : SubServiceBase<ERPInstallation_note_item>
    {
        public Installation_note_itemService(ERPNextClient client)
            : base(DocType.Installation_note_item, client) { }

        protected override ERPInstallation_note_item fromERPObject(ERPObject obj)
        {
            return new ERPInstallation_note_item(obj);
        }
    }
}