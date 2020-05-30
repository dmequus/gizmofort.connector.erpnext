using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Target_detail
{
    public class Target_detailService : SubServiceBase<ERPTarget_detail>
    {
        public Target_detailService(ERPNextClient client)
            : base(DocType.Target_detail, client) { }

        protected override ERPTarget_detail fromERPObject(ERPObject obj)
        {
            return new ERPTarget_detail(obj);
        }
    }
}