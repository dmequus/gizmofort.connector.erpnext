using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Medical_code_standard
{
    public class Medical_code_standardService : SubServiceBase<ERPMedical_code_standard>
    {
        public Medical_code_standardService(ERPNextClient client)
            : base(DocType.Medical_code_standard, client) { }

        protected override ERPMedical_code_standard fromERPObject(ERPObject obj)
        {
            return new ERPMedical_code_standard(obj);
        }
    }
}