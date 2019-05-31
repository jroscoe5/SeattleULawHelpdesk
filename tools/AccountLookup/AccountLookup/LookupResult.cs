using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLookup
{
    class LookupResult
    {
        protected readonly int RESULT_OFFSET = 29;

        public LookupResult(string rawResult)
        {
            RawResult = rawResult;
            ParseRawResult(rawResult);
        }

        public string UserName { get; protected set; }
        public string FullName { get; protected set; }
        public string ID { get; protected set; }
        public string AccountStatus { get; protected set; }
        public string RawResult { get; protected set; }

        public bool LookupSuccess { get; protected set; }
        public string LookupMessage { get; protected set; }

        protected virtual void ParseRawResult(string rawResult)
        {
            List<string> resultList = new List<string>(rawResult.Split('\n'));

            if (resultList.Count < 5) // Lookup was unsuccessful
            {
                LookupSuccess = false;
                LookupMessage = "Failed to find a user with that username";
                return;
            }

            UserName = resultList[0].Substring(RESULT_OFFSET).TrimEnd(' ', '\n', '\r');
            FullName = resultList[1].Substring(RESULT_OFFSET).TrimEnd(' ', '\n', '\r');
            ID = resultList[2].Substring(RESULT_OFFSET).TrimEnd(' ', '\n', '\r');
            AccountStatus = resultList[5].Substring(RESULT_OFFSET).TrimEnd(' ', '\n', '\r');


            Console.WriteLine(AccountStatus);
        }
    }
}
