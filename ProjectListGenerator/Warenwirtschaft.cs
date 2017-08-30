using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace ProjectListGenerator
{
    class Warenwirtschaft
    {
        private DBConnector db;
        private Int32 id;
        private string name;

        public Warenwirtschaft()
        {
            this.db = new DBConnector();
            this.db.Connect("copago1");
        }
        public Warenwirtschaft(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public ObservableCollection<Warenwirtschaft> GetAll()
        {
            ObservableCollection < Warenwirtschaft > returnCollection = new ObservableCollection<Warenwirtschaft>();

            using (SqlDataReader reader = db.Query("select * from WarenwirtschaftSet"))
            {
                while (reader.Read())
                {
                    Console.WriteLine("DEBUG: {0} {1}", reader.GetInt32(0), reader.GetString(1));
                    returnCollection.Add(new Warenwirtschaft(reader.GetInt32(0), reader.GetString(1)));
                }
            }

            return returnCollection;
        }
    }

    class WarenwirtschaftSet
    {

    }
}
