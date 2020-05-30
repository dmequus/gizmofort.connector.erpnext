using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Communication_medium
{
    public class ERPCommunication_medium : ERPNextObjectBase
    {
        public ERPCommunication_medium() : this(new ERPObject(DocType.Communication_medium)) { }
        public ERPCommunication_medium(ERPObject obj) : base(obj) { }

        public static ERPCommunication_medium Create(Communicationmediumtype communicationmediumtype)

        {
            ERPCommunication_medium obj = new ERPCommunication_medium();
            obj.communication_medium_type = communicationmediumtype;
            return obj;
        }

        public Communicationmediumtype communication_medium_type
        {
            get { return parseEnum<Communicationmediumtype>(data.communication_medium_type); }
            set { data.communication_medium_type = value.ToString(); }
        }

        public string catch_all
        {
            get { return data.catch_all; }
            set { data.catch_all = value; }
        }

        public string provider
        {
            get { return data.provider; }
            set { data.provider = value; }
        }

        public long disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        public string timeslots
        {
            get { return data.timeslots; }
            set { data.timeslots = value; }
        }


    }

    //Enums go here
    public enum Communicationmediumtype
    {
        [Description("Voice")]
        Voice,
        [Description("Email")]
        Email,
        [Description("Chat")]
        Chat,
    }


}