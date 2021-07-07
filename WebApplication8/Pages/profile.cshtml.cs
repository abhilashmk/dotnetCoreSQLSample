using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication8.Pages
{
    public class profileModel : PageModel
    {
        public double totalTime;
        public void OnGet()
        {
            DateTime startTime = new DateTime();
            startTime = DateTime.Now;

            for(int i=0;i<2000000000;i++)
            {
                ;
            }

            totalTime = DateTime.Now.Subtract(startTime).TotalMilliseconds;
            Console.WriteLine("Total time taken to execute for Loop:" + totalTime + " Milliseconds");

        }
    }
}
