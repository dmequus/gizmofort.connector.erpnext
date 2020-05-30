using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Vital_signs
{
    public class Vital_signsService : SubServiceBase<ERPVital_signs>
    {
        public Vital_signsService(ERPNextClient client)
            : base(DocType.Vital_signs, client) { }

        protected override ERPVital_signs fromERPObject(ERPObject obj)
        {
            return new ERPVital_signs(obj);
        }
    }
}