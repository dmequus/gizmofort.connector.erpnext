using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Detected_disease
{
    public class Detected_diseaseService : SubServiceBase<ERPDetected_disease>
    {
        public Detected_diseaseService(ERPNextClient client)
            : base(DocType.Detected_disease, client) { }

        protected override ERPDetected_disease fromERPObject(ERPObject obj)
        {
            return new ERPDetected_disease(obj);
        }
    }
}