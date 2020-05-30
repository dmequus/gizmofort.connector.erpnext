using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Skill
{
    public class SkillService : SubServiceBase<ERPSkill>
    {
        public SkillService(ERPNextClient client)
            : base(DocType.Skill, client) { }

        protected override ERPSkill fromERPObject(ERPObject obj)
        {
            return new ERPSkill(obj);
        }
    }
}