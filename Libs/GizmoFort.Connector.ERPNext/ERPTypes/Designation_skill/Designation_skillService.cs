using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Designation_skill
{
    public class Designation_skillService : SubServiceBase<ERPDesignation_skill>
    {
        public Designation_skillService(ERPNextClient client)
            : base(DocType.Designation_skill, client) { }

        protected override ERPDesignation_skill fromERPObject(ERPObject obj)
        {
            return new ERPDesignation_skill(obj);
        }
    }
}