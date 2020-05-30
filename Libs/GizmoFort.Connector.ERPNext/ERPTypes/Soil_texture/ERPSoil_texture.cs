using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Soil_texture
{
    public class ERPSoil_texture : ERPNextObjectBase
    {
        public ERPSoil_texture() : this(new ERPObject(DocType.Soil_texture)) { }
        public ERPSoil_texture(ERPObject obj) : base(obj) { }

        public static ERPSoil_texture Create(string location, string collectiondatetime, string laboratorytestingdatetime, string resultdatetime, Soiltype soiltype, double claycomposition, double sandcomposition, double siltcomposition, string ternaryplot, string soiltexturecriteria)

        {
            ERPSoil_texture obj = new ERPSoil_texture();
            obj.location = location;
            obj.collection_datetime = collectiondatetime;
            obj.laboratory_testing_datetime = laboratorytestingdatetime;
            obj.result_datetime = resultdatetime;
            obj.soil_type = soiltype;
            obj.clay_composition = claycomposition;
            obj.sand_composition = sandcomposition;
            obj.silt_composition = siltcomposition;
            obj.ternary_plot = ternaryplot;
            obj.soil_texture_criteria = soiltexturecriteria;
            return obj;
        }

        public string location
        {
            get { return data.location; }
            set
            {
                data.location = value;
                data.name = value;
            }

        }

        public string collection_datetime
        {
            get { return data.collection_datetime; }
            set { data.collection_datetime = value; }
        }

        public string laboratory_testing_datetime
        {
            get { return data.laboratory_testing_datetime; }
            set { data.laboratory_testing_datetime = value; }
        }

        public string result_datetime
        {
            get { return data.result_datetime; }
            set { data.result_datetime = value; }
        }

        public Soiltype soil_type
        {
            get { return parseEnum<Soiltype>(data.soil_type); }
            set { data.soil_type = value.ToString(); }
        }

        private double _clay_composition = 0.0;
        public double clay_composition
        {
            get { return data._clay_composition; }
            set { data._clay_composition = value; }
        }

        private double _sand_composition = 0.0;
        public double sand_composition
        {
            get { return data._sand_composition; }
            set { data._sand_composition = value; }
        }

        private double _silt_composition = 0.0;
        public double silt_composition
        {
            get { return data._silt_composition; }
            set { data._silt_composition = value; }
        }

        public string ternary_plot
        {
            get { return data.ternary_plot; }
            set { data.ternary_plot = value; }
        }

        public string soil_texture_criteria
        {
            get { return data.soil_texture_criteria; }
            set { data.soil_texture_criteria = value; }
        }


    }

    //Enums go here
    public enum Soiltype
    {
        [Description("Select")]
        Select,
        [Description("Sand")]
        Sand,
        [Description("Loamy Sand")]
        LoamySand,
        [Description("Sandy Loam")]
        SandyLoam,
        [Description("Loam")]
        Loam,
        [Description("Silt Loam")]
        SiltLoam,
        [Description("Silt")]
        Silt,
        [Description("Sandy Clay Loam")]
        SandyClayLoam,
        [Description("Clay Loam")]
        ClayLoam,
        [Description("Silty Clay Loam")]
        SiltyClayLoam,
        [Description("Sandy Clay")]
        SandyClay,
        [Description("Silty Clay")]
        SiltyClay,
        [Description("Clay")]
        Clay,
    }


}