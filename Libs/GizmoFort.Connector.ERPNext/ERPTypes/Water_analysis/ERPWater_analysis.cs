using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Water_analysis
{
    public class ERPWater_analysis : ERPNextObjectBase
    {
        public ERPWater_analysis() : this(new ERPObject(DocType.Water_analysis)) { }
        public ERPWater_analysis(ERPObject obj) : base(obj) { }

        public static ERPWater_analysis Create(string location, string collectiondatetime, string laboratorytestingdatetime, string resultdatetime, string typeofsample, string container, string origin, string collectiontemperature, string storagetemperature, string appearance, string personresponsible, string wateranalysiscriteria)

        {
            ERPWater_analysis obj = new ERPWater_analysis();
            obj.location = location;
            obj.collection_datetime = collectiondatetime;
            obj.laboratory_testing_datetime = laboratorytestingdatetime;
            obj.result_datetime = resultdatetime;
            obj.type_of_sample = typeofsample;
            obj.container = container;
            obj.origin = origin;
            obj.collection_temperature = collectiontemperature;
            obj.storage_temperature = storagetemperature;
            obj.appearance = appearance;
            obj.person_responsible = personresponsible;
            obj.water_analysis_criteria = wateranalysiscriteria;
            return obj;
        }

        public string location
        {
            get { return data.location; }
            set
            {
                data.location = value;
                data.name = value;
            }

        }

        public string collection_datetime
        {
            get { return data.collection_datetime; }
            set { data.collection_datetime = value; }
        }

        public string laboratory_testing_datetime
        {
            get { return data.laboratory_testing_datetime; }
            set { data.laboratory_testing_datetime = value; }
        }

        public string result_datetime
        {
            get { return data.result_datetime; }
            set { data.result_datetime = value; }
        }

        public string type_of_sample
        {
            get { return data.type_of_sample; }
            set { data.type_of_sample = value; }
        }

        public string container
        {
            get { return data.container; }
            set { data.container = value; }
        }

        public string origin
        {
            get { return data.origin; }
            set { data.origin = value; }
        }

        public string collection_temperature
        {
            get { return data.collection_temperature; }
            set { data.collection_temperature = value; }
        }

        public string storage_temperature
        {
            get { return data.storage_temperature; }
            set { data.storage_temperature = value; }
        }

        public string appearance
        {
            get { return data.appearance; }
            set { data.appearance = value; }
        }

        public string person_responsible
        {
            get { return data.person_responsible; }
            set { data.person_responsible = value; }
        }

        public string water_analysis_criteria
        {
            get { return data.water_analysis_criteria; }
            set { data.water_analysis_criteria = value; }
        }


    }

    //Enums go here

}