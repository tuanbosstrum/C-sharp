using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
        }
        private string SERVERNAME;
        private string DATABASE;
        private string USERNAME;
        private string PASSWORD;
        private static string DATABASE_LINK;

        public void getDatabaseLink()
        {
            XmlDocument xmlR = XML.Instance.XMLReader(@"config.xml");
            XmlElement xmlElement = xmlR.DocumentElement;
            try
            {
                this.SERVERNAME = xmlElement.SelectSingleNode("servername").InnerXml;
                this.DATABASE = xmlElement.SelectSingleNode("database").InnerXml;
                this.USERNAME = xmlElement.SelectSingleNode("username").InnerXml;
                this.PASSWORD = xmlElement.SelectSingleNode("password").InnerXml;
                DATABASE_LINK = @"Data Source=" + SERVERNAME + ";Initial Catalog=" + DATABASE + ";Persist Security Info=True;User ID=" + USERNAME + ";Password=" + PASSWORD + "";
            }
            catch
            {

            }

        }
        public SqlConnection ConnectDB(string servername, string database, string username, string password)
        {
            string DATABASE_LINK_TEST = @"Data Source=" + servername + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password + "";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(DATABASE_LINK_TEST);
                conn.Open();
                if (conn.State != ConnectionState.Closed)
                {
                    Console.WriteLine("Connected");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Không thể kết nối" + e.StackTrace);
            }
            return conn;
        }
        public SqlConnection Connect()
        {
            if (DATABASE_LINK == null)
            {
                getDatabaseLink();
            }
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(DATABASE_LINK);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("Connected");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Không thể kết nối" + e.StackTrace);
            }
            return conn;
        }
    }
}
public class XML
{

    private static XML instance;

    public static XML Instance
    {
        get
        {
            if (instance == null)
                instance = new XML();
            return instance;
        }
    }

    public XmlDocument XMLReader(string filename)
    {
        XmlDocument xmlR = new XmlDocument();
        try
        {
            xmlR.Load(filename);
        }
        catch (Exception)
        {

        }
        return xmlR;
    }
    public bool SaveXML(string servername, string database, string username, string password)
    {
        try
        {
            string filename = @"config.xml";
            XmlDocument xmlR = XMLReader(filename);
            XmlElement xmlEle = xmlR.DocumentElement;
            xmlEle.SelectSingleNode("servername").InnerXml = servername;
            xmlEle.SelectSingleNode("database").InnerXml = database;
            xmlEle.SelectSingleNode("username").InnerXml = username;
            xmlEle.SelectSingleNode("password").InnerXml = password;
            xmlR.Save(filename);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
