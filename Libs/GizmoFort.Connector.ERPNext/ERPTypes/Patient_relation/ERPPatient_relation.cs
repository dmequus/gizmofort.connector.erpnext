using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_relation
{
    public class ERPPatient_relation : ERPNextObjectBase
    {
        public ERPPatient_relation() : this(new ERPObject(DocType.Patient_relation)) { }
        public ERPPatient_relation(ERPObject obj) : base(obj) { }

        public static ERPPatient_relation Create(string patient)

        {
            ERPPatient_relation obj = new ERPPatient_relation();
            obj.patient = patient;
            return obj;
        }

        public string patient
        {
            get { return data.patient; }
            set
            {
                data.patient = value;
                data.name = value;
            }

        }

        public Relation relation
        {
            get { return parseEnum<Relation>(data.relation); }
            set { data.relation = value.ToString(); }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here
    public enum Relation
    {
        [Description("Father")]
        Father,
        [Description("Mother")]
        Mother,
        [Description("Spouse")]
        Spouse,
        [Description("Siblings")]
        Siblings,
        [Description("Family")]
        Family,
        [Description("Other")]
        Other,
    }


}