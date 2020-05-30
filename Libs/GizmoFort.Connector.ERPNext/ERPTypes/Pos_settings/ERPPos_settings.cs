using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Pos_settings
{
    public class ERPPos_settings : ERPNextObjectBase
    {
        public ERPPos_settings() : this(new ERPObject(DocType.Pos_settings)) { }
        public ERPPos_settings(ERPObject obj) : base(obj) { }

        public static ERPPos_settings Create()

        {
            ERPPos_settings obj = new ERPPos_settings();
            return obj;
        }

        private int _use_pos_in_offline_mode = 0;
        public int use_pos_in_offline_mode
        {
            get { return data._use_pos_in_offline_mode; }
            set { data._use_pos_in_offline_mode = value; }
        }

        public string fields
        {
            get { return data.fields; }
            set { data.fields = value; }
        }


    }

    //Enums go here

}