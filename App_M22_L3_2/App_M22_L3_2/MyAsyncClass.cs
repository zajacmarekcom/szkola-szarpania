using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace App_M22_L3_2
{
    class MyAsyncClass
    {
        public async Task<int> GetLinesCount(string path)
        {
            var lines = await File.ReadAllLinesAsync(path);

            return lines.Length;
        }
    }
}
