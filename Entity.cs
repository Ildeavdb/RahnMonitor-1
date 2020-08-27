using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace RahnMonitor
{   
    public class Entity 
    {
        //Gives the Individual Properties Entity
        private string _eNTITY_Id;
        private string _fIRST_NAME;
        private string _rEFERENCE_NUMBER;
        private string _listedON;
        private string _sORT_KEY;
        private string _sORT_KEY_LAST_MOD;
        private string _sUBMITTEDON;
        private string _uN_LIST_TYPE;
        private float _vERSIONNUM;
        private string _nAME_ORIGINAL_SCRIPT;
        private string _iSDeleted;
        private string _applicationStatus;
        private string _dateInserted;
        private string _cOMMENTS;
        private string _nOTE;
        private string _sTREET;
        private string _cITY;
        private string _zIP_CODE;
        private string _sTATE_PROVINCE;
        private string _cOUNTRY;
        private string _address;

        //This is the Get and Set methods that allow to get and set the Data.
        public string ENTITY_ID { get => _eNTITY_Id; set => _eNTITY_Id = value; }
        public string FIRST_NAME { get => _fIRST_NAME; set => _fIRST_NAME = value; }
        public string REFERENCE_NUMBER { get => _rEFERENCE_NUMBER; set => _rEFERENCE_NUMBER = value; }
        public string ListedON { get => _listedON; set => _listedON = value; }
        public string SORT_KEY { get => _sORT_KEY; set => _sORT_KEY = value; }
        public string SORT_KEY_LAST_MOD { get => _sORT_KEY_LAST_MOD; set => _sORT_KEY_LAST_MOD = value; }
        public string SUBMITTEDON { get => _sUBMITTEDON; set => _sUBMITTEDON = value; }
        public string UN_LIST_TYPE { get => _uN_LIST_TYPE; set => _uN_LIST_TYPE = value; }
        public float VERSIONNUM { get => _vERSIONNUM; set => _vERSIONNUM = value; }
        public string NAME_ORIGINAL_SCRIPT { get => _nAME_ORIGINAL_SCRIPT; set => _nAME_ORIGINAL_SCRIPT = value; }
        public string ISDeleted { get => _iSDeleted; set => _iSDeleted = value; }
        public string ApplicationStatus { get => _applicationStatus; set => _applicationStatus = value; }
        public string DateInserted { get => _dateInserted; set => _dateInserted = value; }
        public string COMMENTS { get => _cOMMENTS; set => _cOMMENTS = value; }
        public string NOTE { get => _nOTE; set => _nOTE = value; }
        public string STREET { get => _sTREET; set => _sTREET = value; }
        public string CITY { get => _cITY; set => _cITY = value; }
        public string ZIP_CODE { get => _zIP_CODE; set => _zIP_CODE = value; }
        public string STATE_PROVINCE { get => _sTATE_PROVINCE; set => _sTATE_PROVINCE = value; }
        public string COUNTRY { get => _cOUNTRY; set => _cOUNTRY = value; }
        public string Address { get => _address; set => _address = value; }

        // Creates an Entity with all available data
        public Entity(string eNTITY_Id, string fIRST_NAME, string rEFERENCE_NUMBER, string listedON,
            string sORT_KEY, string sORT_KEY_LAST_MOD, string sUBMITTEDON, string uN_LIST_TYPE,
            float vERSIONNUM, string nAME_ORIGINAL_SCRIPT, string iSDeleted, string applicationStatus,
            string dateInserted, string cOMMENTS, string nOTE, string sTREET, string cITY, string zIP_CODE,
            string sTATE_PROVINCE, string cOUNTRY, string address)
        {
            ENTITY_ID = eNTITY_Id;
            FIRST_NAME = fIRST_NAME;
            REFERENCE_NUMBER = rEFERENCE_NUMBER;
            ListedON = listedON;
            SORT_KEY = sORT_KEY;
            SORT_KEY_LAST_MOD = sORT_KEY_LAST_MOD;
            VERSIONNUM = vERSIONNUM;
            NAME_ORIGINAL_SCRIPT = nAME_ORIGINAL_SCRIPT;
            ISDeleted = iSDeleted;
            ApplicationStatus = applicationStatus;
            DateInserted = dateInserted;
            COMMENTS = cOMMENTS;
            NOTE = nOTE;
            STREET = sTREET;
            CITY = cITY;
            ZIP_CODE = zIP_CODE;
            STATE_PROVINCE = sTATE_PROVINCE;
            COUNTRY = cOUNTRY;
            Address = address;
        }

        public Entity() //Create a default Entity
        {

        }

        public List<Entity> PopulateEntity() //Creates a List and populates a Summary of Entity data in the rahnMatchTextBox
        {
            List<Entity> client = new List<Entity>();
            DataSet rawData = new DataHandler().ReadData("Entity");
            foreach (DataRow item in rawData.Tables["Entity"].Rows)
            {
                client.Add(new Entity(item[0].ToString(), item[1].ToString(),
                    item[2].ToString(), item[3].ToString(), item[4].ToString(),
                    item[5].ToString(), item[6].ToString(), item[7].ToString(),
                    float.Parse(item[8].ToString()), item[9].ToString(),
                    item[10].ToString(), item[11].ToString(), item[12].ToString(),
                    item[13].ToString(), item[14].ToString(), item[15].ToString(), item[16].ToString(),
                    item[17].ToString(), item[18].ToString(),
                    item[19].ToString(), item[20].ToString()));
            }
            return client;
        }

    }
}
