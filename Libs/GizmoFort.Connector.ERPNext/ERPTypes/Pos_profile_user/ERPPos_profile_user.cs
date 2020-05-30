using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Pos_profile_user
{
    public class ERPPos_profile_user : ERPNextObjectBase
    {
        public ERPPos_profile_user() : this(new ERPObject(DocType.Pos_profile_user)) { }
        public ERPPos_profile_user(ERPObject obj) : base(obj) { }

        public static ERPPos_profile_user Create()

        {
            ERPPos_profile_user obj = new ERPPos_profile_user();
            return obj;
        }

        private int _keyDELdefault = 0;
        public int keyDELdefault
        {
            get { return data._keyDELdefault; }
            set { data._keyDELdefault = value; }
        }

        public string user
        {
            get { return data.user; }
            set { data.user = value; }
        }


    }

    //Enums go here

}