using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Agriculture_analysis_criteria
{
    public class ERPAgriculture_analysis_criteria : ERPNextObjectBase
    {
        public ERPAgriculture_analysis_criteria() : this(new ERPObject(DocType.Agriculture_analysis_criteria)) { }
        public ERPAgriculture_analysis_criteria(ERPObject obj) : base(obj) { }

        public static ERPAgriculture_analysis_criteria Create(string title, long standard, Linkeddoctype linkeddoctype)

        {
            ERPAgriculture_analysis_criteria obj = new ERPAgriculture_analysis_criteria();
            obj.title = title;
            obj.standard = standard;
            obj.linked_doctype = linkeddoctype;
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

        public long standard
        {
            get { return data.standard; }
            set { data.standard = value; }
        }

        public Linkeddoctype linked_doctype
        {
            get { return parseEnum<Linkeddoctype>(data.linked_doctype); }
            set { data.linked_doctype = value.ToString(); }
        }


    }

    //Enums go here
    public enum Linkeddoctype
    {
        [Description("Water Analysis")]
        WaterAnalysis,
        [Description("Soil Analysis")]
        SoilAnalysis,
        [Description("Plant Analysis")]
        PlantAnalysis,
        [Description("Fertilizer")]
        Fertilizer,
        [Description("Soil Texture")]
        SoilTexture,
        [Description("Weather")]
        Weather,
    }


}