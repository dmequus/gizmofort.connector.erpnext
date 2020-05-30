using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_finance_book
{
    public class ERPAsset_finance_book : ERPNextObjectBase
    {
        public ERPAsset_finance_book() : this(new ERPObject(DocType.Asset_finance_book)) { }
        public ERPAsset_finance_book(ERPObject obj) : base(obj) { }

        public static ERPAsset_finance_book Create(string financebook, Depreciationmethod depreciationmethod, int totalnumberofdepreciations, int frequencyofdepreciation, string depreciationstartdate, double expectedvalueafterusefullife, double valueafterdepreciation, double rateofdepreciation)

        {
            ERPAsset_finance_book obj = new ERPAsset_finance_book();
            obj.finance_book = financebook;
            obj.depreciation_method = depreciationmethod;
            obj.total_number_of_depreciations = totalnumberofdepreciations;
            obj.frequency_of_depreciation = frequencyofdepreciation;
            obj.depreciation_start_date = depreciationstartdate;
            obj.expected_value_after_useful_life = expectedvalueafterusefullife;
            obj.value_after_depreciation = valueafterdepreciation;
            obj.rate_of_depreciation = rateofdepreciation;
            return obj;
        }

        public string finance_book
        {
            get { return data.finance_book; }
            set
            {
                data.finance_book = value;
                data.name = value;
            }

        }

        public Depreciationmethod depreciation_method
        {
            get { return parseEnum<Depreciationmethod>(data.depreciation_method); }
            set { data.depreciation_method = value.ToString(); }
        }

        private int _total_number_of_depreciations = 0;
        public int total_number_of_depreciations
        {
            get { return data._total_number_of_depreciations; }
            set { data._total_number_of_depreciations = value; }
        }

        private int _frequency_of_depreciation = 0;
        public int frequency_of_depreciation
        {
            get { return data._frequency_of_depreciation; }
            set { data._frequency_of_depreciation = value; }
        }

        public string depreciation_start_date
        {
            get { return data.depreciation_start_date; }
            set { data.depreciation_start_date = value; }
        }

        private double _expected_value_after_useful_life = 0.0;
        public double expected_value_after_useful_life
        {
            get { return data._expected_value_after_useful_life; }
            set { data._expected_value_after_useful_life = value; }
        }

        private double _value_after_depreciation = 0.0;
        public double value_after_depreciation
        {
            get { return data._value_after_depreciation; }
            set { data._value_after_depreciation = value; }
        }

        private double _rate_of_depreciation = 0.0;
        public double rate_of_depreciation
        {
            get { return data._rate_of_depreciation; }
            set { data._rate_of_depreciation = value; }
        }


    }

    //Enums go here
    public enum Depreciationmethod
    {
        [Description("Straight Line")]
        StraightLine,
        [Description("Double Declining Balance")]
        DoubleDecliningBalance,
        [Description("Written Down Value")]
        WrittenDownValue,
        [Description("Manual")]
        Manual,
    }


}