using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Crop
{
    public class ERPCrop : ERPNextObjectBase
    {
        public ERPCrop() : this(new ERPObject(DocType.Crop)) { }
        public ERPCrop(ERPObject obj) : base(obj) { }

        public static ERPCrop Create(string title, string cropname, string scientificname, string agriculturetask, int period, double cropspacing, string cropspacinguom, double rowspacing, string rowspacinguom, Type type, string category, string targetwarehouse, string plantinguom, string plantingarea, string yielduom, string materialsrequired, string produce, string byproducts)

        {
            ERPCrop obj = new ERPCrop();
            obj.title = title;
            obj.crop_name = cropname;
            obj.scientific_name = scientificname;
            obj.agriculture_task = agriculturetask;
            obj.period = period;
            obj.crop_spacing = cropspacing;
            obj.crop_spacing_uom = cropspacinguom;
            obj.row_spacing = rowspacing;
            obj.row_spacing_uom = rowspacinguom;
            obj.type = type;
            obj.category = category;
            obj.target_warehouse = targetwarehouse;
            obj.planting_uom = plantinguom;
            obj.planting_area = plantingarea;
            obj.yield_uom = yielduom;
            obj.materials_required = materialsrequired;
            obj.produce = produce;
            obj.byproducts = byproducts;
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

        public string crop_name
        {
            get { return data.crop_name; }
            set { data.crop_name = value; }
        }

        public string scientific_name
        {
            get { return data.scientific_name; }
            set { data.scientific_name = value; }
        }

        public string agriculture_task
        {
            get { return data.agriculture_task; }
            set { data.agriculture_task = value; }
        }

        private int _period = 0;
        public int period
        {
            get { return data._period; }
            set { data._period = value; }
        }

        private double _crop_spacing = 0.0;
        public double crop_spacing
        {
            get { return data._crop_spacing; }
            set { data._crop_spacing = value; }
        }

        public string crop_spacing_uom
        {
            get { return data.crop_spacing_uom; }
            set { data.crop_spacing_uom = value; }
        }

        private double _row_spacing = 0.0;
        public double row_spacing
        {
            get { return data._row_spacing; }
            set { data._row_spacing = value; }
        }

        public string row_spacing_uom
        {
            get { return data.row_spacing_uom; }
            set { data.row_spacing_uom = value; }
        }

        public Type type
        {
            get { return parseEnum<Type>(data.type); }
            set { data.type = value.ToString(); }
        }

        public string category
        {
            get { return data.category; }
            set { data.category = value; }
        }

        public string target_warehouse
        {
            get { return data.target_warehouse; }
            set { data.target_warehouse = value; }
        }

        public string planting_uom
        {
            get { return data.planting_uom; }
            set { data.planting_uom = value; }
        }

        public string planting_area
        {
            get { return data.planting_area; }
            set { data.planting_area = value; }
        }

        public string yield_uom
        {
            get { return data.yield_uom; }
            set { data.yield_uom = value; }
        }

        public string materials_required
        {
            get { return data.materials_required; }
            set { data.materials_required = value; }
        }

        public string produce
        {
            get { return data.produce; }
            set { data.produce = value; }
        }

        public string byproducts
        {
            get { return data.byproducts; }
            set { data.byproducts = value; }
        }


    }

    //Enums go here
    public enum Type
    {
        [Description("Annual")]
        Annual,
        [Description("Perennial")]
        Perennial,
        [Description("Biennial")]
        Biennial,
    }


}