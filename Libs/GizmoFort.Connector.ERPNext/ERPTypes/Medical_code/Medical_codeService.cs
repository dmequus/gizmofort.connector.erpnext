using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Medical_code
{
    public class Medical_codeService : SubServiceBase<ERPMedical_code>
    {
        public Medical_codeService(ERPNextClient client)
            : base(DocType.Medical_code, client) { }

        protected override ERPMedical_code fromERPObject(ERPObject obj)
        {
            return new ERPMedical_code(obj);
        }
    }
}