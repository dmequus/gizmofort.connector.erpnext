using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pl_pl_chart_template
{
    public class Pl_pl_chart_templateService : SubServiceBase<ERPPl_pl_chart_template>
    {
        public Pl_pl_chart_templateService(ERPNextClient client)
            : base(DocType.Pl_pl_chart_template, client) { }

        protected override ERPPl_pl_chart_template fromERPObject(ERPObject obj)
        {
            return new ERPPl_pl_chart_template(obj);
        }
    }
}