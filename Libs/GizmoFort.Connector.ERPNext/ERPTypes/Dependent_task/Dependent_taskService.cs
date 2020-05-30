using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Dependent_task
{
    public class Dependent_taskService : SubServiceBase<ERPDependent_task>
    {
        public Dependent_taskService(ERPNextClient client)
            : base(DocType.Dependent_task, client) { }

        protected override ERPDependent_task fromERPObject(ERPObject obj)
        {
            return new ERPDependent_task(obj);
        }
    }
}