using CAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware
{
    public class CLprocessus
    {
        private DataSet oDs;
        private CLmapTB_A2_WS2 oMap;
        private CAO oCad;
        private String rq_sql;

        public CLprocessus()
        {
            this.oCad = new CAO();
            this.oMap = new CLmapTB_A2_WS2();
        }

        public DataSet afficher(string dataTableName)
        {
            this.oDs.Clear();
            this.rq_sql = this.oMap.selectAll();
            this.oDs = this.oCad.getRows(this.rq_sql, dataTableName);
            return this.oDs;
        }

        public DataSet rechercherNom(string dataTableName, string nom)
        {
            this.oDs.Clear();
            this.rq_sql = this.oMap.selectByName(nom);
            this.oDs = this.oCad.getRows(this.rq_sql, dataTableName);
            return this.oDs;
        }

        public void deleteById(int ID)
        {
            this.oMap.ID = ID;
            this.rq_sql = this.oMap.delete();
            this.oCad.actionRows(this.rq_sql);
        }

        public void insert_update(int id, string nom, string prenom, char methode)
        {
            this.oDs.Clear();
            this.oMap.ID = id;
            this.oMap.Nom = nom;
            this.oMap.Prenom = prenom;

            switch (methode)
            {
                case 'i':
                    this.rq_sql = this.oMap.insert();
                    this.oCad.actionRows(rq_sql);
                    break;
                case 'u':
                    this.rq_sql = this.oMap.update();
                    this.oCad.actionRows(rq_sql);
                    break;
                default:
                    break;
            }
        }

    }
}
