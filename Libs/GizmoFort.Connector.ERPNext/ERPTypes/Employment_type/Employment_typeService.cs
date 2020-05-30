using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employment_type
{
    public class Employment_typeService : SubServiceBase<ERPEmployment_type>
    {
        public Employment_typeService(ERPNextClient client)
            : base(DocType.Employment_type, client) { }

        protected override ERPEmployment_type fromERPObject(ERPObject obj)
        {
            return new ERPEmployment_type(obj);
        }
    }
}