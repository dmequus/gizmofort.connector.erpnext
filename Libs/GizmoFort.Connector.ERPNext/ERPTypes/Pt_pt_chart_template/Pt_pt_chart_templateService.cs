using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pt_pt_chart_template
{
    public class Pt_pt_chart_templateService : SubServiceBase<ERPPt_pt_chart_template>
    {
        public Pt_pt_chart_templateService(ERPNextClient client)
            : base(DocType.Pt_pt_chart_template, client) { }

        protected override ERPPt_pt_chart_template fromERPObject(ERPObject obj)
        {
            return new ERPPt_pt_chart_template(obj);
        }
    }
}