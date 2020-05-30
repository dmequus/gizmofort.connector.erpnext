using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Lab_test_groups
{
    public class Lab_test_groupsService : SubServiceBase<ERPLab_test_groups>
    {
        public Lab_test_groupsService(ERPNextClient client)
            : base(DocType.Lab_test_groups, client) { }

        protected override ERPLab_test_groups fromERPObject(ERPObject obj)
        {
            return new ERPLab_test_groups(obj);
        }
    }
}