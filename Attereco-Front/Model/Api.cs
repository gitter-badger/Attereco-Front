﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attereco_Front.Model
{
    public static class Api
    {
        /// <summary>
        /// ベースとなるURL
        /// </summary>
        private const String baseUrl = "";

        /// <summary>
        /// APIのPostを叩く
        /// </summary>
        /// <param name="rooting"></param>
        /// <param name="json">IDMを含んだJson</param>
        /// <returns>ユーザー情報のjson</returns>
        public static String Post(String rooting, String json)
        {
            try
            {
                String url = baseUrl + rooting;
                Log.WriteLog(json);
            }
            catch (System.Runtime.Remoting.RemotingTimeoutException ex)
            {
                Log.WriteLog("TimeOutException", ex);
                return null;
            }
            catch (NullReferenceException ex)
            {
                Log.WriteLog("NullReferenceException", ex);
                return null;
            }
            return "";
        }

        /// <summary>
        /// APIのGetを叩く
        /// </summary>
        /// <param name="rooting"></param>
        /// <returns>ログインユーザー一覧？</returns>
        public static String Get(String rooting)
        {
            try
            {
                String url = baseUrl + rooting;
                //TODO
            }
            catch (System.Runtime.Remoting.RemotingTimeoutException ex)
            {
                Log.WriteLog("TimeOutException", ex);
                return null;
            }
            catch (NullReferenceException ex)
            {
                Log.WriteLog("NullReferenceException", ex);
                return null;
            }
            return "";
        }
    }
}
