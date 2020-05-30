using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_inspection_template
{
    public class ERPQuality_inspection_template : ERPNextObjectBase
    {
        public ERPQuality_inspection_template() : this(new ERPObject(DocType.Quality_inspection_template)) { }
        public ERPQuality_inspection_template(ERPObject obj) : base(obj) { }

        public static ERPQuality_inspection_template Create(string qualityinspectiontemplatename, string itemqualityinspectionparameter)

        {
            ERPQuality_inspection_template obj = new ERPQuality_inspection_template();
            obj.quality_inspection_template_name = qualityinspectiontemplatename;
            obj.item_quality_inspection_parameter = itemqualityinspectionparameter;
            return obj;
        }

        public string quality_inspection_template_name
        {
            get { return data.quality_inspection_template_name; }
            set
            {
                data.quality_inspection_template_name = value;
                data.name = value;
            }

        }

        public string item_quality_inspection_parameter
        {
            get { return data.item_quality_inspection_parameter; }
            set { data.item_quality_inspection_parameter = value; }
        }


    }

    //Enums go here

}