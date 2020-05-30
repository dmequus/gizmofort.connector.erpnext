using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Clinical_procedure_template
{
    public class Clinical_procedure_templateService : SubServiceBase<ERPClinical_procedure_template>
    {
        public Clinical_procedure_templateService(ERPNextClient client)
            : base(DocType.Clinical_procedure_template, client) { }

        protected override ERPClinical_procedure_template fromERPObject(ERPObject obj)
        {
            return new ERPClinical_procedure_template(obj);
        }
    }
}