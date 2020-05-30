using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Dosage_strength
{
    public class Dosage_strengthService : SubServiceBase<ERPDosage_strength>
    {
        public Dosage_strengthService(ERPNextClient client)
            : base(DocType.Dosage_strength, client) { }

        protected override ERPDosage_strength fromERPObject(ERPObject obj)
        {
            return new ERPDosage_strength(obj);
        }
    }
}