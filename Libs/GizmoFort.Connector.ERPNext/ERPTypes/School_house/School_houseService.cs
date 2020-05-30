using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.School_house
{
    public class School_houseService : SubServiceBase<ERPSchool_house>
    {
        public School_houseService(ERPNextClient client)
            : base(DocType.School_house, client) { }

        protected override ERPSchool_house fromERPObject(ERPObject obj)
        {
            return new ERPSchool_house(obj);
        }
    }
}