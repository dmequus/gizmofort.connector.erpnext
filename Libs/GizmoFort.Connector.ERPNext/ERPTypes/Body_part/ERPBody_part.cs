using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Body_part
{
    public class ERPBody_part : ERPNextObjectBase
    {
        public ERPBody_part() : this(new ERPObject(DocType.Body_part)) { }
        public ERPBody_part(ERPObject obj) : base(obj) { }

        public static ERPBody_part Create(string bodypart)

        {
            ERPBody_part obj = new ERPBody_part();
            obj.body_part = bodypart;
            return obj;
        }

        public string body_part
        {
            get { return data.body_part; }
            set
            {
                data.body_part = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}