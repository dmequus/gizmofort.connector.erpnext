using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Program
{
    public class ERPProgram : ERPNextObjectBase
    {
        public ERPProgram() : this(new ERPObject(DocType.Program)) { }
        public ERPProgram(ERPObject obj) : base(obj) { }

        public static ERPProgram Create(string programname)

        {
            ERPProgram obj = new ERPProgram();
            obj.program_name = programname;
            return obj;
        }

        public string program_name
        {
            get { return data.program_name; }
            set
            {
                data.program_name = value;
                data.name = value;
            }

        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string program_abbreviation
        {
            get { return data.program_abbreviation; }
            set { data.program_abbreviation = value; }
        }

        public string courses
        {
            get { return data.courses; }
            set { data.courses = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string intro_video
        {
            get { return data.intro_video; }
            set { data.intro_video = value; }
        }

        public string hero_image
        {
            get { return data.hero_image; }
            set { data.hero_image = value; }
        }

        public long is_published
        {
            get { return data.is_published; }
            set { data.is_published = value; }
        }

        public long is_featured
        {
            get { return data.is_featured; }
            set { data.is_featured = value; }
        }

        public long allow_self_enroll
        {
            get { return data.allow_self_enroll; }
            set { data.allow_self_enroll = value; }
        }


    }

    //Enums go here

}