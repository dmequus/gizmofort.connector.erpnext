using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Cheque_print_template
{
    public class Cheque_print_templateService : SubServiceBase<ERPCheque_print_template>
    {
        public Cheque_print_templateService(ERPNextClient client)
            : base(DocType.Cheque_print_template, client) { }

        protected override ERPCheque_print_template fromERPObject(ERPObject obj)
        {
            return new ERPCheque_print_template(obj);
        }
    }
}