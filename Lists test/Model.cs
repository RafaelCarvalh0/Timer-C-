using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_test
{
    public class Model
    {
        public int id;
        public string name;
        public string description;
        public string force;
        public string defense;
        public string guard;
        public string magic;
        public string stamina;
        public List<Enemy> enemy;
    }

    public class Enemy
    {
        public string life;
        public string habilities;
        public string conjure;
        public string power;
    }

}
