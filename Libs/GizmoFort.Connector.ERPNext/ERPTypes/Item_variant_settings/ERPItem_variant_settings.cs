using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_variant_settings
{
    public class ERPItem_variant_settings : ERPNextObjectBase
    {
        public ERPItem_variant_settings() : this(new ERPObject(DocType.Item_variant_settings)) { }
        public ERPItem_variant_settings(ERPObject obj) : base(obj) { }

        public static ERPItem_variant_settings Create(int donotupdatevariants, int allowrenameattributevalue, string fields)

        {
            ERPItem_variant_settings obj = new ERPItem_variant_settings();
            obj.do_not_update_variants = donotupdatevariants;
            obj.allow_rename_attribute_value = allowrenameattributevalue;
            obj.fields = fields;
            return obj;
        }

        private int _do_not_update_variants = 0;
        public int do_not_update_variants
        {
            get { return data._do_not_update_variants; }
            set { data._do_not_update_variants = value; }
        }

        private int _allow_rename_attribute_value = 0;
        public int allow_rename_attribute_value
        {
            get { return data._allow_rename_attribute_value; }
            set { data._allow_rename_attribute_value = value; }
        }

        public string fields
        {
            get { return data.fields; }
            set { data.fields = value; }
        }


    }

    //Enums go here

}