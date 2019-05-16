using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLookup
{
    class LookupResult
    {
        protected readonly int RESULT_OFFSET;

        public LookupResult(string rawResult)
        {
            RESULT_OFFSET = 29;
            ParseRawResult(rawResult);
        }

        public string UserName { get; protected set; }
        public string FullName { get; protected set; }

        private void ParseRawResult(string rawResult)
        {
            List<string> resultList = new List<string>(rawResult.Split('\n'));
            Console.WriteLine(resultList[0]);
            Console.WriteLine(resultList.Count);
        }
    }
}
