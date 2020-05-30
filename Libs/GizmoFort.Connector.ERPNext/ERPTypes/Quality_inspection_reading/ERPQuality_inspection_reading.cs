using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_inspection_reading
{
    public class ERPQuality_inspection_reading : ERPNextObjectBase
    {
        public ERPQuality_inspection_reading() : this(new ERPObject(DocType.Quality_inspection_reading)) { }
        public ERPQuality_inspection_reading(ERPObject obj) : base(obj) { }

        public static ERPQuality_inspection_reading Create(string specification)

        {
            ERPQuality_inspection_reading obj = new ERPQuality_inspection_reading();
            obj.specification = specification;
            return obj;
        }

        public string specification
        {
            get { return data.specification; }
            set
            {
                data.specification = value;
                data.name = value;
            }

        }

        public string value
        {
            get { return data.value; }
            set { data.value = value; }
        }

        public string reading_1
        {
            get { return data.reading_1; }
            set { data.reading_1 = value; }
        }

        public string reading_2
        {
            get { return data.reading_2; }
            set { data.reading_2 = value; }
        }

        public string reading_3
        {
            get { return data.reading_3; }
            set { data.reading_3 = value; }
        }

        public string reading_4
        {
            get { return data.reading_4; }
            set { data.reading_4 = value; }
        }

        public string reading_5
        {
            get { return data.reading_5; }
            set { data.reading_5 = value; }
        }

        public string reading_6
        {
            get { return data.reading_6; }
            set { data.reading_6 = value; }
        }

        public string reading_7
        {
            get { return data.reading_7; }
            set { data.reading_7 = value; }
        }

        public string reading_8
        {
            get { return data.reading_8; }
            set { data.reading_8 = value; }
        }

        public string reading_9
        {
            get { return data.reading_9; }
            set { data.reading_9 = value; }
        }

        public string reading_10
        {
            get { return data.reading_10; }
            set { data.reading_10 = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Accepted")]
        Accepted,
        [Description("Rejected")]
        Rejected,
    }


}