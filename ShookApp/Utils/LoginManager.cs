using MongoDB.Bson.Serialization;
using RestSharp;
using ShookModel.Models;
using System;

namespace ShookApp.Utils
{
    /// <summary>
    /// This class handles the login action.
    /// </summary>
    class LoginManager
    {
        /// <summary>
        /// Checks if the username and password are valid.
        /// </summary>
        /// <param name="username">Username of the user who wants to log in.</param>
        /// <param name="password">Password of the user who wants to log in.</param>
        /// <returns>True if the credentials are valid.</returns>
        public bool CheckPassword(string username, string password)
        {
            var client = new ShookDebugHttpClient("https://IpToShookREST/login?username=" + username + "&password=" + password);
            var request = new RestRequest(Method.POST);
            
            IRestResponse response = client.Execute(request);

            LoginPackage loginPackage;

            try
            {
                loginPackage = BsonSerializer.Deserialize<LoginPackage>(response.Content);
            }
            catch(Exception)
            {
                //TODO: Exception handling (EndOfDocument)
                throw new Exception();
            }

            return VerificateLoginPackage(loginPackage);
        }

        /// <summary>
        /// Checks actually if the credentials are valid.
        /// </summary>
        /// <param name="loginPackage">The received <see cref="LoginPackage"/>.</param>
        /// <returns>True if success of the <see cref="LoginPackage"/> is true.</returns>
        private bool VerificateLoginPackage(LoginPackage loginPackage)
        {
            if(loginPackage.Success)
            {
                SaveLoginPackage(loginPackage);

                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Saves the <see cref="LoginPackage"/> and the apiKey to the <see cref="Statics"/> class.
        /// </summary>
        /// <param name="_loginPackage">The received <see cref="LoginPackage"/> with the valid user credentials.</param>
        private void SaveLoginPackage(LoginPackage _loginPackage)
        {
            Statics.loginPackage = _loginPackage;
            Statics.apiKey = _loginPackage.ApiKey;
        }
    }
}
