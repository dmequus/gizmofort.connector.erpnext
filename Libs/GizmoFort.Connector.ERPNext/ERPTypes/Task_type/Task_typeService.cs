using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Task_type
{
    public class Task_typeService : SubServiceBase<ERPTask_type>
    {
        public Task_typeService(ERPNextClient client)
            : base(DocType.Task_type, client) { }

        protected override ERPTask_type fromERPObject(ERPObject obj)
        {
            return new ERPTask_type(obj);
        }
    }
}