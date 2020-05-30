using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Project_template
{
    public class Project_templateService : SubServiceBase<ERPProject_template>
    {
        public Project_templateService(ERPNextClient client)
            : base(DocType.Project_template, client) { }

        protected override ERPProject_template fromERPObject(ERPObject obj)
        {
            return new ERPProject_template(obj);
        }
    }
}