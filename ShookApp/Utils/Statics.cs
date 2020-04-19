using ShookModel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShookApp.Utils
{
    /// <summary>
    /// This class holds some static variables which are used during runtime.
    /// </summary>
    class Statics
    {
        /// <summary>
        /// The valid <see cref="LoginPackage"/> which is comming from
        /// the <see cref="LoginManager"/>.
        /// </summary>
        public static LoginPackage loginPackage;

        /// <summary>
        /// The API key for ShookREST which is comming from
        /// the <see cref="LoginManager"/>.
        /// </summary>
        public static string apiKey;

        /// <summary>
        /// Method to delete the static variables for example when the user wants to logout.
        /// </summary>
        public static void DeleteAllStatics()
        {
            loginPackage = new EmptyLoginPackage();
            apiKey = "";
        }
    }
}
