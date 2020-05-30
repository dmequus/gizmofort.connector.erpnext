using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Industry_type
{
    public class Industry_typeService : SubServiceBase<ERPIndustry_type>
    {
        public Industry_typeService(ERPNextClient client)
            : base(DocType.Industry_type, client) { }

        protected override ERPIndustry_type fromERPObject(ERPObject obj)
        {
            return new ERPIndustry_type(obj);
        }
    }
}