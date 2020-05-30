using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Print_heading
{
    public class Print_headingService : SubServiceBase<ERPPrint_heading>
    {
        public Print_headingService(ERPNextClient client)
            : base(DocType.Print_heading, client) { }

        protected override ERPPrint_heading fromERPObject(ERPObject obj)
        {
            return new ERPPrint_heading(obj);
        }
    }
}