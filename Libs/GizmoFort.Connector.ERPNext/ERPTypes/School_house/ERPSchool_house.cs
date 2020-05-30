using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.School_house
{
    public class ERPSchool_house : ERPNextObjectBase
    {
        public ERPSchool_house() : this(new ERPObject(DocType.School_house)) { }
        public ERPSchool_house(ERPObject obj) : base(obj) { }

        public static ERPSchool_house Create(string housename)

        {
            ERPSchool_house obj = new ERPSchool_house();
            obj.house_name = housename;
            return obj;
        }

        public string house_name
        {
            get { return data.house_name; }
            set
            {
                data.house_name = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}