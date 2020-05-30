using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Disease
{
    public class ERPDisease : ERPNextObjectBase
    {
        public ERPDisease() : this(new ERPObject(DocType.Disease)) { }
        public ERPDisease(ERPObject obj) : base(obj) { }

        public static ERPDisease Create(string commonname, string scientificname, string treatmenttask, int treatmentperiod, string description)

        {
            ERPDisease obj = new ERPDisease();
            obj.common_name = commonname;
            obj.scientific_name = scientificname;
            obj.treatment_task = treatmenttask;
            obj.treatment_period = treatmentperiod;
            obj.description = description;
            return obj;
        }

        public string common_name
        {
            get { return data.common_name; }
            set
            {
                data.common_name = value;
                data.name = value;
            }

        }

        public string scientific_name
        {
            get { return data.scientific_name; }
            set { data.scientific_name = value; }
        }

        public string treatment_task
        {
            get { return data.treatment_task; }
            set { data.treatment_task = value; }
        }

        private int _treatment_period = 0;
        public int treatment_period
        {
            get { return data._treatment_period; }
            set { data._treatment_period = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here

}