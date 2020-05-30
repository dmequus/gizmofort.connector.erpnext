using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Communication_medium
{
    public class Communication_mediumService : SubServiceBase<ERPCommunication_medium>
    {
        public Communication_mediumService(ERPNextClient client)
            : base(DocType.Communication_medium, client) { }

        protected override ERPCommunication_medium fromERPObject(ERPObject obj)
        {
            return new ERPCommunication_medium(obj);
        }
    }
}