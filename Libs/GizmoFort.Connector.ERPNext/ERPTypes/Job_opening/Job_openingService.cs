using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Job_opening
{
    public class Job_openingService : SubServiceBase<ERPJob_opening>
    {
        public Job_openingService(ERPNextClient client)
            : base(DocType.Job_opening, client) { }

        protected override ERPJob_opening fromERPObject(ERPObject obj)
        {
            return new ERPJob_opening(obj);
        }
    }
}