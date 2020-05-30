using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Designation
{
    public class ERPDesignation : ERPNextObjectBase
    {
        public ERPDesignation() : this(new ERPObject(DocType.Designation)) { }
        public ERPDesignation(ERPObject obj) : base(obj) { }

        public static ERPDesignation Create(string designationname, string description, string skills)

        {
            ERPDesignation obj = new ERPDesignation();
            obj.designation_name = designationname;
            obj.description = description;
            obj.skills = skills;
            return obj;
        }

        public string designation_name
        {
            get { return data.designation_name; }
            set
            {
                data.designation_name = value;
                data.name = value;
            }

        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string skills
        {
            get { return data.skills; }
            set { data.skills = value; }
        }


    }

    //Enums go here

}