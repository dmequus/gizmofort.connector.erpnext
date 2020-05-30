using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Clinical_procedure
{
    public class Clinical_procedureService : SubServiceBase<ERPClinical_procedure>
    {
        public Clinical_procedureService(ERPNextClient client)
            : base(DocType.Clinical_procedure, client) { }

        protected override ERPClinical_procedure fromERPObject(ERPObject obj)
        {
            return new ERPClinical_procedure(obj);
        }
    }
}