using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPocket.Utility
{
    public class DbConnection
    {
        /// <summary>
        /// To get route for save data base
        /// </summary>
        /// <param name="vpDataBaseName">Data base name</param>
        /// <returns>Route, type string</returns>
        public static string GetRoute(string vpDataBaseName)
        {
            string vlRouteDataBase = string.Empty;

            // Verified what platform is Android, IOS
            if (DeviceInfo.Platform == DevicePlatform.Android)
            {
                vlRouteDataBase = FileSystem.AppDataDirectory;
                vlRouteDataBase = Path.Combine(vlRouteDataBase, vpDataBaseName);
            }
            else if (DeviceInfo.Platform == DevicePlatform.iOS)
            {
                vlRouteDataBase = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                vlRouteDataBase = Path.Combine(vlRouteDataBase, "..", "Library", vpDataBaseName);
            }

            return vlRouteDataBase;
        }
    }
}
