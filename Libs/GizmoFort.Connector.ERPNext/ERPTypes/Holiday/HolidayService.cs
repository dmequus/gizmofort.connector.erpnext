using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Holiday
{
    public class HolidayService : SubServiceBase<ERPHoliday>
    {
        public HolidayService(ERPNextClient client)
            : base(DocType.Holiday, client) { }

        protected override ERPHoliday fromERPObject(ERPObject obj)
        {
            return new ERPHoliday(obj);
        }
    }
}