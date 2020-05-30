using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Therapy_plan_detail
{
    public class Therapy_plan_detailService : SubServiceBase<ERPTherapy_plan_detail>
    {
        public Therapy_plan_detailService(ERPNextClient client)
            : base(DocType.Therapy_plan_detail, client) { }

        protected override ERPTherapy_plan_detail fromERPObject(ERPObject obj)
        {
            return new ERPTherapy_plan_detail(obj);
        }
    }
}