using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Antibiotic
{
    public class AntibioticService : SubServiceBase<ERPAntibiotic>
    {
        public AntibioticService(ERPNextClient client)
            : base(DocType.Antibiotic, client) { }

        protected override ERPAntibiotic fromERPObject(ERPObject obj)
        {
            return new ERPAntibiotic(obj);
        }
    }
}