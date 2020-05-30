using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Fertilizer
{
    public class ERPFertilizer : ERPNextObjectBase
    {
        public ERPFertilizer() : this(new ERPObject(DocType.Fertilizer)) { }
        public ERPFertilizer(ERPObject obj) : base(obj) { }

        public static ERPFertilizer Create(string fertilizername, string item, string density, string fertilizercontents)

        {
            ERPFertilizer obj = new ERPFertilizer();
            obj.fertilizer_name = fertilizername;
            obj.item = item;
            obj.density = density;
            obj.fertilizer_contents = fertilizercontents;
            return obj;
        }

        public string fertilizer_name
        {
            get { return data.fertilizer_name; }
            set
            {
                data.fertilizer_name = value;
                data.name = value;
            }

        }

        public string item
        {
            get { return data.item; }
            set { data.item = value; }
        }

        public string density
        {
            get { return data.density; }
            set { data.density = value; }
        }

        public string fertilizer_contents
        {
            get { return data.fertilizer_contents; }
            set { data.fertilizer_contents = value; }
        }


    }

    //Enums go here

}