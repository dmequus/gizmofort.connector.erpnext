using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Linked_soil_texture
{
    public class ERPLinked_soil_texture : ERPNextObjectBase
    {
        public ERPLinked_soil_texture() : this(new ERPObject(DocType.Linked_soil_texture)) { }
        public ERPLinked_soil_texture(ERPObject obj) : base(obj) { }

        public static ERPLinked_soil_texture Create(string soiltexture)

        {
            ERPLinked_soil_texture obj = new ERPLinked_soil_texture();
            obj.soil_texture = soiltexture;
            return obj;
        }

        public string soil_texture
        {
            get { return data.soil_texture; }
            set
            {
                data.soil_texture = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}