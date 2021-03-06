﻿using Codeplex.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attereco_Front.Model.Dummy
{
    /// <summary>
    /// Apiが実装されるまでDummyのデータを返すモデル
    /// </summary>
    public static class DummyApi
    {
        /// <summary>
        /// PostのDummy
        /// </summary>
        /// <param name="json">IDを含んだjson</param>
        /// <returns>氏名，プロジェクト，学年，日付を含んだJson</returns>
        public static DynamicJson DummyPost(DynamicJson json)
        {
            DynamicJson data = json;
            try
            {
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
            return data;
        }

        /// <summary>
        /// GetのDummy
        /// </summary>
        /// <param name="json">IDを含んだjson</param>
        /// <returns>氏名，プロジェクト，学年，日付を含んだJson</returns>
        public static DynamicJson DummyGet()
        {
            DynamicJson data = new DynamicJson();
            try
            {
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
            return data;
        }
    }

}
