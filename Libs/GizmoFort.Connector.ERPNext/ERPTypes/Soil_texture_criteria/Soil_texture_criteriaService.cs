using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Soil_texture_criteria
{
    public class Soil_texture_criteriaService : SubServiceBase<ERPSoil_texture_criteria>
    {
        public Soil_texture_criteriaService(ERPNextClient client)
            : base(DocType.Soil_texture_criteria, client) { }

        protected override ERPSoil_texture_criteria fromERPObject(ERPObject obj)
        {
            return new ERPSoil_texture_criteria(obj);
        }
    }
}