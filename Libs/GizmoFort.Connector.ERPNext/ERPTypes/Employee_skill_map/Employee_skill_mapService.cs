using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_skill_map
{
    public class Employee_skill_mapService : SubServiceBase<ERPEmployee_skill_map>
    {
        public Employee_skill_mapService(ERPNextClient client)
            : base(DocType.Employee_skill_map, client) { }

        protected override ERPEmployee_skill_map fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_skill_map(obj);
        }
    }
}