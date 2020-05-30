using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Holiday_list
{
    public class Holiday_listService : SubServiceBase<ERPHoliday_list>
    {
        public Holiday_listService(ERPNextClient client)
            : base(DocType.Holiday_list, client) { }

        protected override ERPHoliday_list fromERPObject(ERPObject obj)
        {
            return new ERPHoliday_list(obj);
        }
    }
}