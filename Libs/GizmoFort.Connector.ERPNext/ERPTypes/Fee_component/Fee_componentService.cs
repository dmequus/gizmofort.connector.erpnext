using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Fee_component
{
    public class Fee_componentService : SubServiceBase<ERPFee_component>
    {
        public Fee_componentService(ERPNextClient client)
            : base(DocType.Fee_component, client) { }

        protected override ERPFee_component fromERPObject(ERPObject obj)
        {
            return new ERPFee_component(obj);
        }
    }
}