using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Healthcare_service_unit_type
{
    public class Healthcare_service_unit_typeService : SubServiceBase<ERPHealthcare_service_unit_type>
    {
        public Healthcare_service_unit_typeService(ERPNextClient client)
            : base(DocType.Healthcare_service_unit_type, client) { }

        protected override ERPHealthcare_service_unit_type fromERPObject(ERPObject obj)
        {
            return new ERPHealthcare_service_unit_type(obj);
        }
    }
}