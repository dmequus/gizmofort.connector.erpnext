using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Project_type
{
    public class Project_typeService : SubServiceBase<ERPProject_type>
    {
        public Project_typeService(ERPNextClient client)
            : base(DocType.Project_type, client) { }

        protected override ERPProject_type fromERPObject(ERPObject obj)
        {
            return new ERPProject_type(obj);
        }
    }
}