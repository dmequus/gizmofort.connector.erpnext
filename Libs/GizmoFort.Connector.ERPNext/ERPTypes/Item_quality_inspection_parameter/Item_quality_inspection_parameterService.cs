using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_quality_inspection_parameter
{
    public class Item_quality_inspection_parameterService : SubServiceBase<ERPItem_quality_inspection_parameter>
    {
        public Item_quality_inspection_parameterService(ERPNextClient client)
            : base(DocType.Item_quality_inspection_parameter, client) { }

        protected override ERPItem_quality_inspection_parameter fromERPObject(ERPObject obj)
        {
            return new ERPItem_quality_inspection_parameter(obj);
        }
    }
}