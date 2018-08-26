using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.VisualBasic;

namespace DapperDemo
{

    public class PersonService
    {
        private IDbConnection _conn;
        public IDbConnection Conn
        {
            get { return new SqlConnection(SQLHelper.ConnString); }
            set { this._conn = value; }
        }
        public List<string> ProvinceList = new List<string>();

        IPTools.International.IpHeavyweightSearcher searcher = new IPTools.International.IpHeavyweightSearcher();

        public List<Person> GetAllPersons()
        {
            List<Person> retList = new List<Person>();
            using (Conn)
            {
                string sql = "SELECT * FROM Person";
                retList = Conn.Query<Person>(sql).ToList();
            }
            retList.ForEach(item =>
            {
                string prov = searcher.Search(item.IpAddress).Province;

                item.Province = prov;
                item.Age = GetAgeByBirthdate(item.Birthday);

                if (prov != null && !ProvinceList.Contains(prov))
                    ProvinceList.Add(item.Province);
            });
            return retList;
        }
        public List<Person> GetPersonById(string id)
        {
            using (Conn)
            {
                string sql = "SELECT * FROM Person WHERE Id=@Id";
                return Conn.Query<Person>(sql, new { @Id = id }).ToList();
            }
        }
        public List<Person> GetPersonByLastName(string lastName)
        {
            using (Conn)
            {
                string sql = "SELECT * FROM Person WHERE LastName=@LastName";
                return Conn.Query<Person>(sql, new { @LastName = lastName }).ToList();
            }
        }
        public List<Person> GetPersonByProvince(string province)
        {
            var pList = GetAllPersons();
            pList.RemoveAll(item => item.Province != province);
            return pList;
        }
        public bool DeletePersonById(string id)
        {
            using (Conn)
            {
                string sql = "DELETE FROM Person WHERE Id=@Id";
                return Conn.Execute(sql, new { @Id = id }) > 0;
            };
        }
        public int GetAgeByBirthdate(DateTime startDT)
        {
            int year = (int)DateAndTime.DateDiff(DateInterval.Year, startDT, DateTime.Now);
            return year;
        }
    }
}

