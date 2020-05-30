using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Therapy_plan
{
    public class Therapy_planService : SubServiceBase<ERPTherapy_plan>
    {
        public Therapy_planService(ERPNextClient client)
            : base(DocType.Therapy_plan, client) { }

        protected override ERPTherapy_plan fromERPObject(ERPObject obj)
        {
            return new ERPTherapy_plan(obj);
        }
    }
}