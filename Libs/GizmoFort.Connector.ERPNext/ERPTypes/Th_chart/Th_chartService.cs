using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Th_chart
{
    public class Th_chartService : SubServiceBase<ERPTh_chart>
    {
        public Th_chartService(ERPNextClient client)
            : base(DocType.Th_chart, client) { }

        protected override ERPTh_chart fromERPObject(ERPObject obj)
        {
            return new ERPTh_chart(obj);
        }
    }
}