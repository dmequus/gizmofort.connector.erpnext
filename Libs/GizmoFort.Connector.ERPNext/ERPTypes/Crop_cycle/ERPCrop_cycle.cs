using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Crop_cycle
{
    public class ERPCrop_cycle : ERPNextObjectBase
    {
        public ERPCrop_cycle() : this(new ERPObject(DocType.Crop_cycle)) { }
        public ERPCrop_cycle(ERPObject obj) : base(obj) { }

        public static ERPCrop_cycle Create(string title, string crop, string linkedlocation, string project, string startdate, string enddate, long iso8601standard, Cycletype cycletype, double cropspacing, string cropspacinguom, double rowspacing, string rowspacinguom, string detecteddisease, string soiltexture, string soilanalysis, string plantanalysis)

        {
            ERPCrop_cycle obj = new ERPCrop_cycle();
            obj.title = title;
            obj.crop = crop;
            obj.linked_location = linkedlocation;
            obj.project = project;
            obj.start_date = startdate;
            obj.end_date = enddate;
            obj.iso_8601_standard = iso8601standard;
            obj.cycle_type = cycletype;
            obj.crop_spacing = cropspacing;
            obj.crop_spacing_uom = cropspacinguom;
            obj.row_spacing = rowspacing;
            obj.row_spacing_uom = rowspacinguom;
            obj.detected_disease = detecteddisease;
            obj.soil_texture = soiltexture;
            obj.soil_analysis = soilanalysis;
            obj.plant_analysis = plantanalysis;
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

        public string crop
        {
            get { return data.crop; }
            set { data.crop = value; }
        }

        public string linked_location
        {
            get { return data.linked_location; }
            set { data.linked_location = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public string start_date
        {
            get { return data.start_date; }
            set { data.start_date = value; }
        }

        public string end_date
        {
            get { return data.end_date; }
            set { data.end_date = value; }
        }

        public long iso_8601_standard
        {
            get { return data.iso_8601_standard; }
            set { data.iso_8601_standard = value; }
        }

        public Cycletype cycle_type
        {
            get { return parseEnum<Cycletype>(data.cycle_type); }
            set { data.cycle_type = value.ToString(); }
        }

        public double crop_spacing
        {
            get { return data.crop_spacing; }
            set { data.crop_spacing = value; }
        }

        public string crop_spacing_uom
        {
            get { return data.crop_spacing_uom; }
            set { data.crop_spacing_uom = value; }
        }

        public double row_spacing
        {
            get { return data.row_spacing; }
            set { data.row_spacing = value; }
        }

        public string row_spacing_uom
        {
            get { return data.row_spacing_uom; }
            set { data.row_spacing_uom = value; }
        }

        public string detected_disease
        {
            get { return data.detected_disease; }
            set { data.detected_disease = value; }
        }

        public string soil_texture
        {
            get { return data.soil_texture; }
            set { data.soil_texture = value; }
        }

        public string soil_analysis
        {
            get { return data.soil_analysis; }
            set { data.soil_analysis = value; }
        }

        public string plant_analysis
        {
            get { return data.plant_analysis; }
            set { data.plant_analysis = value; }
        }


    }

    //Enums go here
    public enum Cycletype
    {
        [Description("Yearly")]
        Yearly,
        [Description("Less than a year")]
        Lessthanayear,
    }


}