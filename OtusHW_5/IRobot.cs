using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHW_5
{
    public interface IRobot
    {
        public string GetInfo();
        public List<string> GetComponents();
        public string GetRobotType()
        {
            return "I am simple robot";
        }

    }
}
