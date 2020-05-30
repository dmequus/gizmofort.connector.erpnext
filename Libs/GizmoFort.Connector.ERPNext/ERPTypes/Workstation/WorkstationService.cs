using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Workstation
{
    public class WorkstationService : SubServiceBase<ERPWorkstation>
    {
        public WorkstationService(ERPNextClient client)
            : base(DocType.Workstation, client) { }

        protected override ERPWorkstation fromERPObject(ERPObject obj)
        {
            return new ERPWorkstation(obj);
        }
    }
}