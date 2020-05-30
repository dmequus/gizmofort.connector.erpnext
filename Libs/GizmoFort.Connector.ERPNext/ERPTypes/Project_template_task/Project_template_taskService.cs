using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Project_template_task
{
    public class Project_template_taskService : SubServiceBase<ERPProject_template_task>
    {
        public Project_template_taskService(ERPNextClient client)
            : base(DocType.Project_template_task, client) { }

        protected override ERPProject_template_task fromERPObject(ERPObject obj)
        {
            return new ERPProject_template_task(obj);
        }
    }
}