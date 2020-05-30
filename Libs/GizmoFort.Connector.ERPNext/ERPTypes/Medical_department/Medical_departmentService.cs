using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Medical_department
{
    public class Medical_departmentService : SubServiceBase<ERPMedical_department>
    {
        public Medical_departmentService(ERPNextClient client)
            : base(DocType.Medical_department, client) { }

        protected override ERPMedical_department fromERPObject(ERPObject obj)
        {
            return new ERPMedical_department(obj);
        }
    }
}