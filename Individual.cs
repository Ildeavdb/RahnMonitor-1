using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RahnMonitor
{
    public class Individual //Gives the Individual Properties
    {
        private string _iNDIVIDUAL_Id;
        private string _tITLE;
        private string _fIRST_NAME;
        private string _sECOND_NAME;
        private string _tHIRD_NAME;
        private string _fOURTH_NAME;
        private string _fullName;
        private string _gENDER;
        private string _iDNUMBER;
        private string _pASSPORT;
        private string _dESIGNATION;
        private string _listedON;
        private string _nATIONALITY;
        private string _rEFERENCE_NUMBER;
        private string _sORT_KEY;
        private string _sORT_KEY_LAST_MOD;
        private string _sUBMITTED_BY;
        private string _uN_LIST_TYPE;
        private string _cOMMENTS;
        private float _vERSIONNUM;
        private string _nAME_ORIGINAL_SCRIPT;
        private string _dateInserted;
        private string _applicationStatus;
        private string _tYPE_OF_DATE;
        private string _nOTE;
        private string _fROM_YEAR;
        private string _tO_YEAR;
        private string _yEAR;
        private string _dATE;
        private string _bIRTHPLACE_CITY;
        private string _bIRTHPLACE_STATE_PROVINCE;
        private string _bIRTHPLACE_NOTE;
        private string _bIRTHPLACE_COUNTRY;
        private string _pLACEOFBIRTH;
        private string _sTREET;
        private string _cITY;
        private string _zIP_CODE;
        private string _sTATE_PROVINCE;
        private string _cOUNTRY;
        private string _nOTE1;
        private string _dATE_OF_ISSUE;
        private string _cITY_OF_ISSUE;
        private string _cOUNTRY_OF_ISSUE;
        private string _nOTE2;
        private string _dATE_OF_BIRTH;
        private string _cITY_OF_BIRTH;
        private string _cOUNTRY_OF_BIRTH;
        private string _nOTE3;

        //This is the Get and Set methods that allow to get and set the Data.
        public string INDIVIDUAL_Id { get => _iNDIVIDUAL_Id; set => _iNDIVIDUAL_Id = value; }
        public string TITLE { get => _tITLE; set => _tITLE = value; }
        public string FIRST_NAME { get => _fIRST_NAME; set => _fIRST_NAME = value; }
        public string SECOND_NAME { get => _sECOND_NAME; set => _sECOND_NAME = value; }
        public string THIRD_NAME { get => _tHIRD_NAME; set => _tHIRD_NAME = value; }
        public string FOURTH_NAME { get => _fOURTH_NAME; set => _fOURTH_NAME = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public string GENDER { get => _gENDER; set => _gENDER = value; }
        public string IDNUMBER { get => _iDNUMBER; set => _iDNUMBER = value; }
        public string PASSPORT { get => _pASSPORT; set => _pASSPORT = value; }
        public string DESIGNATION { get => _dESIGNATION; set => _dESIGNATION = value; }
        public string ListedON { get => _listedON; set => _listedON = value; }
        public string NATIONALITY { get => _nATIONALITY; set => _nATIONALITY = value; }
        public string REFERENCE_NUMBER { get => _rEFERENCE_NUMBER; set => _rEFERENCE_NUMBER = value; }
        public string SORT_KEY { get => _sORT_KEY; set => _sORT_KEY = value; }
        public string SORT_KEY_LAST_MOD { get => _sORT_KEY_LAST_MOD; set => _sORT_KEY_LAST_MOD = value; }
        public string SUBMITTED_BY { get => _sUBMITTED_BY; set => _sUBMITTED_BY = value; }
        public string UN_LIST_TYPE { get => _uN_LIST_TYPE; set => _uN_LIST_TYPE = value; }
        public string COMMENTS { get => _cOMMENTS; set => _cOMMENTS = value; }
        public float VERSIONNUM { get => _vERSIONNUM; set => _vERSIONNUM = value; }
        public string NAME_ORIGINAL_SCRIPT { get => _nAME_ORIGINAL_SCRIPT; set => _nAME_ORIGINAL_SCRIPT = value; }
        public string DateInserted { get => _dateInserted; set => _dateInserted = value; }
        public string ApplicationStatus { get => _applicationStatus; set => _applicationStatus = value; }
        public string TYPE_OF_DATE { get => _tYPE_OF_DATE; set => _tYPE_OF_DATE = value; }
        public string NOTE { get => _nOTE; set => _nOTE = value; }
        public string FROM_YEAR { get => _fROM_YEAR; set => _fROM_YEAR = value; }
        public string TO_YEAR { get => _tO_YEAR; set => _tO_YEAR = value; }
        public string YEAR { get => _yEAR; set => _yEAR = value; }
        public string DATE { get => _dATE; set => _dATE = value; }
        public string BIRTHPLACE_CITY { get => _bIRTHPLACE_CITY; set => _bIRTHPLACE_CITY = value; }
        public string BIRTHPLACE_STATE_PROVINCE { get => _bIRTHPLACE_STATE_PROVINCE; set => _bIRTHPLACE_STATE_PROVINCE = value; }
        public string BIRTHPLACE_NOTE { get => _bIRTHPLACE_NOTE; set => _bIRTHPLACE_NOTE = value; }
        public string BIRTHPLACE_COUNTRY { get => _bIRTHPLACE_COUNTRY; set => _bIRTHPLACE_COUNTRY = value; }
        public string PLACEOFBIRTH { get => _pLACEOFBIRTH; set => _pLACEOFBIRTH = value; }
        public string STREET { get => _sTREET; set => _sTREET = value; }
        public string CITY { get => _cITY; set => _cITY = value; }
        public string ZIP_CODE { get => _zIP_CODE; set => _zIP_CODE = value; }
        public string STATE_PROVINCE { get => _sTATE_PROVINCE; set => _sTATE_PROVINCE = value; }
        public string COUNTRY { get => _cOUNTRY; set => _cOUNTRY = value; }
        public string NOTE1 { get => _nOTE1; set => _nOTE1 = value; }
        public string DATE_OF_ISSUE { get => _dATE_OF_ISSUE; set => _dATE_OF_ISSUE = value; }
        public string CITY_OF_ISSUE { get => _cITY_OF_ISSUE; set => _cITY_OF_ISSUE = value; }
        public string COUNTRY_OF_ISSUE { get => _cOUNTRY_OF_ISSUE; set => _cOUNTRY_OF_ISSUE = value; }
        public string NOTE2 { get => _nOTE2; set => _nOTE2 = value; }
        public string DATE_OF_BIRTH { get => _dATE_OF_BIRTH; set => _dATE_OF_BIRTH = value; }
        public string CITY_OF_BIRTH { get => _cITY_OF_BIRTH; set => _cITY_OF_BIRTH = value; }
        public string COUNTRY_OF_BIRTH { get => _cOUNTRY_OF_BIRTH; set => _cOUNTRY_OF_BIRTH = value; }
        public string NOTE3 { get => _nOTE3; set => _nOTE3 = value; }



        public Individual(string iNDIVIDUAL_Id, string tITLE, string fIRST_NAME, string sECOND_NAME,
            string tHIRD_NAME, string fOURTH_NAME, string fullName, string gENDER, string iDNUMBER, 
            string pASSPORT, string dESIGNATION, string listedON, string nATIONALITY, string rEFERENCE_NUMBER,
            string sORT_KEY, string sORT_KEY_LAST_MOD, string sUBMITTED_BY, string uN_LIST_TYPE, string cOMMENTS,
            float vERSIONNUM, string nAME_ORIGINAL_SCRIPT, string dateInserted, string applicationStatus,string tYPE_OF_DATE,
            string nOTE, string fROM_YEAR, string tO_YEAR, string yEAR, string dATE, string bIRTHPLACE_CITY,
            string bIRTHPLACE_STATE_PROVINCE, string bIRTHPLACE_NOTE, string bIRTHPLACE_COUNTRY, string pLACEOFBIRTH, string sTREET,
            string cITY, string zIP_CODE, string sTATE_PROVINCE, string cOUNTRY, string nOTE1, string dATE_OF_ISSUE, string cITY_OF_ISSUE,
            string cOUNTRY_OF_ISSUE,string nOTE2, string dATE_OF_BIRTH, string cITY_OF_BIRTH, string cOUNTRY_OF_BIRTH, string nOTE3)
        {
            INDIVIDUAL_Id = iNDIVIDUAL_Id;
            TITLE = tITLE;
            FIRST_NAME = fIRST_NAME;
            SECOND_NAME = sECOND_NAME;
            THIRD_NAME = tHIRD_NAME;
            FOURTH_NAME = fOURTH_NAME;
            FullName = fullName;
            GENDER = gENDER;
            IDNUMBER = iDNUMBER;
            PASSPORT = pASSPORT;
            DESIGNATION = dESIGNATION;
            ListedON = listedON;
            NATIONALITY = nATIONALITY;
            REFERENCE_NUMBER = rEFERENCE_NUMBER;
            SORT_KEY = sORT_KEY;
            SORT_KEY_LAST_MOD = sORT_KEY_LAST_MOD;
            SUBMITTED_BY = sUBMITTED_BY;
            UN_LIST_TYPE = uN_LIST_TYPE;
            COMMENTS = cOMMENTS;
            VERSIONNUM = vERSIONNUM;
            NAME_ORIGINAL_SCRIPT = nAME_ORIGINAL_SCRIPT;
            DateInserted = dateInserted;
            ApplicationStatus = applicationStatus;
            TYPE_OF_DATE = tYPE_OF_DATE;
            NOTE = nOTE;
            FROM_YEAR = fROM_YEAR;
            TO_YEAR = tO_YEAR;
            YEAR = yEAR;
            DATE = dATE;
            BIRTHPLACE_CITY = bIRTHPLACE_CITY;
            BIRTHPLACE_STATE_PROVINCE = bIRTHPLACE_STATE_PROVINCE;
            BIRTHPLACE_NOTE = bIRTHPLACE_NOTE;
            BIRTHPLACE_COUNTRY = bIRTHPLACE_COUNTRY;
            PLACEOFBIRTH = pLACEOFBIRTH;
            STREET = sTREET;
            CITY = cITY;
            ZIP_CODE = zIP_CODE;
            STATE_PROVINCE = sTATE_PROVINCE;
            COUNTRY = cOUNTRY;
            NOTE1 = nOTE1;
            DATE_OF_ISSUE = dATE_OF_ISSUE;
            CITY_OF_ISSUE = cITY_OF_ISSUE;
            COUNTRY_OF_ISSUE = cOUNTRY_OF_ISSUE;
            DATE_OF_BIRTH = dATE_OF_BIRTH;
            CITY_OF_BIRTH = cITY_OF_BIRTH;
            COUNTRY_OF_BIRTH = cOUNTRY_OF_BIRTH;
            NOTE3 = nOTE3;

        }

        public Individual() //Represents A default Individual
        {

        }

        public List<Individual> PopulateIndividual() //Represents a Summary of available data in the rahnMatchTextBox
        {
            List<Individual> client = new List<Individual>();
            DataSet rawData = new DataHandler().ReadData("Individual");
            foreach (DataRow item in rawData.Tables["Individual"].Rows)
            {
                client.Add(new Individual(
                    item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(),
                    item[4].ToString(), item[5].ToString(), item[6].ToString(), item[7].ToString(),
                    item[8].ToString(), item[9].ToString(), item[10].ToString(), item[11].ToString(),
                    item[12].ToString(), item[13].ToString(), item[14].ToString(), item[15].ToString(),
                    item[16].ToString(), item[17].ToString(), item[18].ToString(), float.Parse(item[19].ToString()),
                    item[20].ToString(), item[21].ToString(), item[22].ToString(), item[23].ToString(),
                    item[24].ToString(), item[25].ToString(), item[26].ToString(), item[27].ToString(),
                    item[28].ToString(), item[29].ToString(), item[30].ToString(), item[31].ToString(),
                    item[32].ToString(), item[33].ToString(), item[34].ToString(), item[35].ToString(),
                    item[36].ToString(), item[37].ToString(), item[38].ToString(), item[39].ToString(), 
                    item[40].ToString(), item[41].ToString(), item[42].ToString(), item[43].ToString(), 
                    item[44].ToString(), item[45].ToString(),
                    item[46].ToString(), item[47].ToString()));

            }
            return client;
        }
    }
}

