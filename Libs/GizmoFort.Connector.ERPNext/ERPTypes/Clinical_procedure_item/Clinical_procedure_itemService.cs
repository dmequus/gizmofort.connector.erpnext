using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Clinical_procedure_item
{
    public class Clinical_procedure_itemService : SubServiceBase<ERPClinical_procedure_item>
    {
        public Clinical_procedure_itemService(ERPNextClient client)
            : base(DocType.Clinical_procedure_item, client) { }

        protected override ERPClinical_procedure_item fromERPObject(ERPObject obj)
        {
            return new ERPClinical_procedure_item(obj);
        }
    }
}