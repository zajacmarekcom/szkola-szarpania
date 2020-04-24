using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App_M22_L3_3
{
    class MyAsyncClass
    {
        public async Task<int> WorkAsync(int i)
        {
            return await Task.Run<int>(() => 3 * i + 67);
        }

        public async Task OtherAsync()
        {
            var task = new Task(Work);
            task.Start();

            await task;
        }

        private void Work()
        {
            // Do
        }
    }
}
