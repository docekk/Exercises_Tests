using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Pirates
    {
        public string CannonsReady(Dictionary<string, string> gunners)
        {
            bool ready = true;
            for (int i = 0; i < gunners.Count(); i++)
            {
                if (gunners.Values.Skip(i).First() == "nay")
                {
                    ready = false;
                    break;
                }
            }
            if (ready == false)
            {
                return "Shiver me timbers!";
            }
            else return "Fire!";
        }
    }
}
