using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Territory
{
    public class TerritoryService : SubServiceBase<ERPTerritory>
    {
        public TerritoryService(ERPNextClient client)
            : base(DocType.Territory, client) { }

        protected override ERPTerritory fromERPObject(ERPObject obj)
        {
            return new ERPTerritory(obj);
        }
    }
}