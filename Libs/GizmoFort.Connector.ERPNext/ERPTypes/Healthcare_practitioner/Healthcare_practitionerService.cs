using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Healthcare_practitioner
{
    public class Healthcare_practitionerService : SubServiceBase<ERPHealthcare_practitioner>
    {
        public Healthcare_practitionerService(ERPNextClient client)
            : base(DocType.Healthcare_practitioner, client) { }

        protected override ERPHealthcare_practitioner fromERPObject(ERPObject obj)
        {
            return new ERPHealthcare_practitioner(obj);
        }
    }
}