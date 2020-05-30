using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Therapy_type
{
    public class Therapy_typeService : SubServiceBase<ERPTherapy_type>
    {
        public Therapy_typeService(ERPNextClient client)
            : base(DocType.Therapy_type, client) { }

        protected override ERPTherapy_type fromERPObject(ERPObject obj)
        {
            return new ERPTherapy_type(obj);
        }
    }
}