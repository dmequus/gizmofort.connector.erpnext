using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_variant_settings
{
    public class ERPItem_variant_settings : ERPNextObjectBase
    {
        public ERPItem_variant_settings() : this(new ERPObject(DocType.Item_variant_settings)) { }
        public ERPItem_variant_settings(ERPObject obj) : base(obj) { }

        public static ERPItem_variant_settings Create(long donotupdatevariants, long allowrenameattributevalue, string fields)

        {
            ERPItem_variant_settings obj = new ERPItem_variant_settings();
            obj.do_not_update_variants = donotupdatevariants;
            obj.allow_rename_attribute_value = allowrenameattributevalue;
            obj.fields = fields;
            return obj;
        }

        public long do_not_update_variants
        {
            get { return data.do_not_update_variants; }
            set { data.do_not_update_variants = value; }
        }

        public long allow_rename_attribute_value
        {
            get { return data.allow_rename_attribute_value; }
            set { data.allow_rename_attribute_value = value; }
        }

        public string fields
        {
            get { return data.fields; }
            set { data.fields = value; }
        }


    }

    //Enums go here

}