using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Task
{
    public class TaskService : SubServiceBase<ERPTask>
    {
        public TaskService(ERPNextClient client)
            : base(DocType.Task, client) { }

        protected override ERPTask fromERPObject(ERPObject obj)
        {
            return new ERPTask(obj);
        }
    }
}