using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.At_austria_chart_template
{
    public class At_austria_chart_templateService : SubServiceBase<ERPAt_austria_chart_template>
    {
        public At_austria_chart_templateService(ERPNextClient client)
            : base(DocType.At_austria_chart_template, client) { }

        protected override ERPAt_austria_chart_template fromERPObject(ERPObject obj)
        {
            return new ERPAt_austria_chart_template(obj);
        }
    }
}