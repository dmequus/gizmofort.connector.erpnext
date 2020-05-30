using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Fertilizer_content
{
    public class ERPFertilizer_content : ERPNextObjectBase
    {
        public ERPFertilizer_content() : this(new ERPObject(DocType.Fertilizer_content)) { }
        public ERPFertilizer_content(ERPObject obj) : base(obj) { }

        public static ERPFertilizer_content Create(string title, string value)

        {
            ERPFertilizer_content obj = new ERPFertilizer_content();
            obj.title = title;
            obj.value = value;
            return obj;
        }

        public string title
        {
            get { return data.title; }
            set
            {
                data.title = value;
                data.name = value;
            }

        }

        public string value
        {
            get { return data.value; }
            set { data.value = value; }
        }


    }

    //Enums go here

}