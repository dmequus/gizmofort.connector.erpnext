using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_block_list_date
{
    public class ERPLeave_block_list_date : ERPNextObjectBase
    {
        public ERPLeave_block_list_date() : this(new ERPObject(DocType.Leave_block_list_date)) { }
        public ERPLeave_block_list_date(ERPObject obj) : base(obj) { }

        public static ERPLeave_block_list_date Create(string blockdate, string reason)

        {
            ERPLeave_block_list_date obj = new ERPLeave_block_list_date();
            obj.block_date = blockdate;
            obj.reason = reason;
            return obj;
        }

        public string block_date
        {
            get { return data.block_date; }
            set
            {
                data.block_date = value;
                data.name = value;
            }

        }

        public string reason
        {
            get { return data.reason; }
            set { data.reason = value; }
        }


    }

    //Enums go here

}