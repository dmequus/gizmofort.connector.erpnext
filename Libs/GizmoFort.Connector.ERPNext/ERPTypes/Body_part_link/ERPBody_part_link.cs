using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Body_part_link
{
    public class ERPBody_part_link : ERPNextObjectBase
    {
        public ERPBody_part_link() : this(new ERPObject(DocType.Body_part_link)) { }
        public ERPBody_part_link(ERPObject obj) : base(obj) { }

        public static ERPBody_part_link Create(string bodypart)

        {
            ERPBody_part_link obj = new ERPBody_part_link();
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