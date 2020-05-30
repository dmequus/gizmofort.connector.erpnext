using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Dosage_form
{
    public class Dosage_formService : SubServiceBase<ERPDosage_form>
    {
        public Dosage_formService(ERPNextClient client)
            : base(DocType.Dosage_form, client) { }

        protected override ERPDosage_form fromERPObject(ERPObject obj)
        {
            return new ERPDosage_form(obj);
        }
    }
}