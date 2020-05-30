using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Healthcare_service_unit
{
    public class Healthcare_service_unitService : SubServiceBase<ERPHealthcare_service_unit>
    {
        public Healthcare_service_unitService(ERPNextClient client)
            : base(DocType.Healthcare_service_unit, client) { }

        protected override ERPHealthcare_service_unit fromERPObject(ERPObject obj)
        {
            return new ERPHealthcare_service_unit(obj);
        }
    }
}