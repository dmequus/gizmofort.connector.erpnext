using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Lost_reason_detail
{
    public class ERPLost_reason_detail : ERPNextObjectBase
    {
        public ERPLost_reason_detail() : this(new ERPObject(DocType.Lost_reason_detail)) { }
        public ERPLost_reason_detail(ERPObject obj) : base(obj) { }

        public static ERPLost_reason_detail Create(string lostreason)

        {
            ERPLost_reason_detail obj = new ERPLost_reason_detail();
            obj.lost_reason = lostreason;
            return obj;
        }

        public string lost_reason
        {
            get { return data.lost_reason; }
            set
            {
                data.lost_reason = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}