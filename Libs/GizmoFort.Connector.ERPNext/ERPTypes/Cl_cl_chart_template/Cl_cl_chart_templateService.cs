using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Cl_cl_chart_template
{
    public class Cl_cl_chart_templateService : SubServiceBase<ERPCl_cl_chart_template>
    {
        public Cl_cl_chart_templateService(ERPNextClient client)
            : base(DocType.Cl_cl_chart_template, client) { }

        protected override ERPCl_cl_chart_template fromERPObject(ERPObject obj)
        {
            return new ERPCl_cl_chart_template(obj);
        }
    }
}