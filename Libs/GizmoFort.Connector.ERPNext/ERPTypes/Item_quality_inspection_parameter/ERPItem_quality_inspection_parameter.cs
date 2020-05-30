using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_quality_inspection_parameter
{
    public class ERPItem_quality_inspection_parameter : ERPNextObjectBase
    {
        public ERPItem_quality_inspection_parameter() : this(new ERPObject(DocType.Item_quality_inspection_parameter)) { }
        public ERPItem_quality_inspection_parameter(ERPObject obj) : base(obj) { }

        public static ERPItem_quality_inspection_parameter Create(string specification, string value)

        {
            ERPItem_quality_inspection_parameter obj = new ERPItem_quality_inspection_parameter();
            obj.specification = specification;
            obj.value = value;
            return obj;
        }

        public string specification
        {
            get { return data.specification; }
            set
            {
                data.specification = value;
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