using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SIngleton.Pattern.Models
{
    public class Singleton
    {
        private static Singleton? Instance;
        private readonly static object _lock = new object();
        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if(Instance == null)
            {
                lock(_lock)
                {
                    if (Instance is null)
                        Instance = new Singleton();
                }
            }
            return Instance;
        }
    }
}
