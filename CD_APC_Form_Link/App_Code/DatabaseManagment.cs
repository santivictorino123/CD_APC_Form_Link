using Dexon.module00;
using Dexon.module03.LogonProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CD_APC_Form_Link.App_Code
{
    public class DatabaseManagment
    {
        public static Logon LogonObject;

        public bool loginOk = false;

        public string errorMessage;

        public DatabaseManagment()
        {
            var loginOk = false;
            if (LogonObject == null)
            {
                LogonObject = GetLogonObject("Admin", "Adm1n", ".", out loginOk, out errorMessage);
            }
        }

        /// <summary>Get logon object, for the given user and password.</summary>
        /// <param name="user">The user id.</param>
        /// <param name="pass">The user password.</param>
        /// <param name="sessId">A string representing the session id. (core)</param>
        /// <param name="loginOk">An out boolean if the login was successfull.</param>
        /// <param name="errorMsg">An out string for the error message if the login fails.</param>
        /// <returns>An object Logon if the login was sucessfull, null otherwise.</returns>
        internal static Logon GetLogonObject(
            string user, string pass, string sessId, out bool loginOk, out string errorMsg)
        {
            var logon = new Logon();
            logon_errors err_code;
            string token;
            loginOk = logon.log_in(user, pass, sessId, out err_code, out token);
            errorMsg = err_code.ToString();

            return logon;
        }
    }
}