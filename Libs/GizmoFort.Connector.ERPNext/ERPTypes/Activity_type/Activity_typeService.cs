using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Activity_type
{
    public class Activity_typeService : SubServiceBase<ERPActivity_type>
    {
        public Activity_typeService(ERPNextClient client)
            : base(DocType.Activity_type, client) { }

        protected override ERPActivity_type fromERPObject(ERPObject obj)
        {
            return new ERPActivity_type(obj);
        }
    }
}