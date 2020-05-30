using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Soil_analysis
{
    public class ERPSoil_analysis : ERPNextObjectBase
    {
        public ERPSoil_analysis() : this(new ERPObject(DocType.Soil_analysis)) { }
        public ERPSoil_analysis(ERPObject obj) : base(obj) { }

        public static ERPSoil_analysis Create(string location, string collectiondatetime, string laboratorytestingdatetime, string resultdatetime, string caperk, string capermg, string mgperk, string camgperk, string caperkcamg, string invoicenumber, string soilanalysiscriteria)

        {
            ERPSoil_analysis obj = new ERPSoil_analysis();
            obj.location = location;
            obj.collection_datetime = collectiondatetime;
            obj.laboratory_testing_datetime = laboratorytestingdatetime;
            obj.result_datetime = resultdatetime;
            obj.ca_per_k = caperk;
            obj.ca_per_mg = capermg;
            obj.mg_per_k = mgperk;
            obj.ca_mg_per_k = camgperk;
            obj.ca_per_k_ca_mg = caperkcamg;
            obj.invoice_number = invoicenumber;
            obj.soil_analysis_criteria = soilanalysiscriteria;
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

        public string ca_per_k
        {
            get { return data.ca_per_k; }
            set { data.ca_per_k = value; }
        }

        public string ca_per_mg
        {
            get { return data.ca_per_mg; }
            set { data.ca_per_mg = value; }
        }

        public string mg_per_k
        {
            get { return data.mg_per_k; }
            set { data.mg_per_k = value; }
        }

        public string ca_mg_per_k
        {
            get { return data.ca_mg_per_k; }
            set { data.ca_mg_per_k = value; }
        }

        public string ca_per_k_ca_mg
        {
            get { return data.ca_per_k_ca_mg; }
            set { data.ca_per_k_ca_mg = value; }
        }

        public string invoice_number
        {
            get { return data.invoice_number; }
            set { data.invoice_number = value; }
        }

        public string soil_analysis_criteria
        {
            get { return data.soil_analysis_criteria; }
            set { data.soil_analysis_criteria = value; }
        }


    }

    //Enums go here

}