using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware
{
    public class CLmapTB_A2_WS2
    {

        private String rq_sql;
        private int id;
        private String nom;
        private String prenom;
        public int MyProperty { get; set; }

        public int ID {get{return this.id;}set{this.id = value;}}
        public string Nom { get { return nom; } set { nom = value; } }
        public string Prenom { get { return prenom; } set { prenom = value; } }

        public string selectAll()
        {
            this.rq_sql = "SELECT * FROM [DB_A2_WS2].[dbo].[TB_A2_WS2]";
            return rq_sql;
        }

        public string selectByName()
        {
            this.rq_sql = String.Format("SELECT * FROM [DB_A2_WS2].[dbo].[TB_A2_WS2] WHERE nom = '{0}'", this.nom);
            return rq_sql;
        }

        public string selectByName(String nom)
        {
            this.rq_sql = String.Format("SELECT * FROM [DB_A2_WS2].[dbo].[TB_A2_WS2] WHERE nom = '{0}'", nom);
            return rq_sql;
        }

        public string delete()
        {
            this.rq_sql = String.Format("DELETE FROM [DB_A2_WS2].[dbo].[TB_A2_WS2] WHERE id = {0};", this.id);
            return rq_sql;
        }

        public string delete(int id)
        {
            this.rq_sql = String.Format("DELETE FROM [DB_A2_WS2].[dbo].[TB_A2_WS2] WHERE id = {0};", id);
            return rq_sql;
        }

        public string insert()
        {
            this.rq_sql = String.Format("INSERT INTO [DB_A2_WS2].[dbo].[TB_A2_WS2] ([id], [nom], [prenom]) VALUES ('{0}', '{1}', '{2}');", this.id, this.nom, this.prenom);
            return rq_sql;
        }

        public string insert(int id, String nom, String prenom)
        {
            this.rq_sql = String.Format("INSERT INTO [DB_A2_WS2].[dbo].[TB_A2_WS2] ([id], [nom], [prenom]) VALUES ('{0}', '{1}', '{2}');", id, nom, prenom);
            return rq_sql;
        }

        public string update()
        {
            this.rq_sql = String.Format("UPDATE [DB_A2_WS2].[dbo].[TB_A2_WS2] SET [nom] = '{0}', '{1}' WHERE '{2}');",  this.nom, this.prenom, this.id);
            return rq_sql;
        }
        public string update(int id, String nom, String prenom)
        {
            this.rq_sql = String.Format("UPDATE [DB_A2_WS2].[dbo].[TB_A2_WS2] SET [nom] = '{0}', '{1}' WHERE '{2}');", nom, prenom, id);
            return rq_sql;
        }

    }

}
