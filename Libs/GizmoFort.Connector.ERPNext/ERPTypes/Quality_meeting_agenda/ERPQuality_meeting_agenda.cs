using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_meeting_agenda
{
    public class ERPQuality_meeting_agenda : ERPNextObjectBase
    {
        public ERPQuality_meeting_agenda() : this(new ERPObject(DocType.Quality_meeting_agenda)) { }
        public ERPQuality_meeting_agenda(ERPObject obj) : base(obj) { }

        public static ERPQuality_meeting_agenda Create()

        {
            ERPQuality_meeting_agenda obj = new ERPQuality_meeting_agenda();
            return obj;
        }

        public string agenda
        {
            get { return data.agenda; }
            set
            {
                data.agenda = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}