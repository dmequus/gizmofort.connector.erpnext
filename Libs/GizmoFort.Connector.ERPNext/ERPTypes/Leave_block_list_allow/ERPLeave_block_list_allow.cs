using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_block_list_allow
{
    public class ERPLeave_block_list_allow : ERPNextObjectBase
    {
        public ERPLeave_block_list_allow() : this(new ERPObject(DocType.Leave_block_list_allow)) { }
        public ERPLeave_block_list_allow(ERPObject obj) : base(obj) { }

        public static ERPLeave_block_list_allow Create(string allowuser)

        {
            ERPLeave_block_list_allow obj = new ERPLeave_block_list_allow();
            obj.allow_user = allowuser;
            return obj;
        }

        public string allow_user
        {
            get { return data.allow_user; }
            set
            {
                data.allow_user = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}