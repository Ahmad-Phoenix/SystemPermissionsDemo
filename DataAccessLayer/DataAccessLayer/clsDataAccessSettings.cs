using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsDataAccessSettings
    {
        /// <summary>
        /// Connection String for Microsoft SQL Server.
        /// </summary>
        /// <note>
        /// [GITHUB NOTE]: 
        /// BEFORE RUNNING THE APPLICATION: You must restore the database 'SystemPermissions' 
        /// using the backup file (.bak) located in the project's 'DataBase_Sql' folder.
        /// Ensure your local SQL Server instance is running and configuration matches.
        /// </note>
        public static string ConnectionString = "Server=.;Database=SystemPermissions;User Id=sa;Password=123456;";
    }
}

