using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Ve_ve_chart_template_amd
{
    public class Ve_ve_chart_template_amdService : SubServiceBase<ERPVe_ve_chart_template_amd>
    {
        public Ve_ve_chart_template_amdService(ERPNextClient client)
            : base(DocType.Ve_ve_chart_template_amd, client) { }

        protected override ERPVe_ve_chart_template_amd fromERPObject(ERPObject obj)
        {
            return new ERPVe_ve_chart_template_amd(obj);
        }
    }
}