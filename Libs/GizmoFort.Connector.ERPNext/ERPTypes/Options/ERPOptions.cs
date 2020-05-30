using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Options
{
    public class ERPOptions : ERPNextObjectBase
    {
        public ERPOptions() : this(new ERPObject(DocType.Options)) { }
        public ERPOptions(ERPObject obj) : base(obj) { }

        public static ERPOptions Create(string option, long iscorrect)

        {
            ERPOptions obj = new ERPOptions();
            obj.option = option;
            obj.is_correct = iscorrect;
            return obj;
        }

        public string option
        {
            get { return data.option; }
            set
            {
                data.option = value;
                data.name = value;
            }

        }

        public long is_correct
        {
            get { return data.is_correct; }
            set { data.is_correct = value; }
        }


    }

    //Enums go here

}