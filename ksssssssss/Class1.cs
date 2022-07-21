using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ksssssssss
{
    class Class1
    {
        private int _index;
        private  string[] _Random_Array;
        private string[] Array_Changement;
        private Control[] Array_Control;
        private int var_=0;
        private int[] Array_index_control;
        public int var
        {
            get
            {
                return var_;

            }
            set
            {
                var_ = value;
            }
        }
        public Control[] ArrayControl
        {
            get
            {
                return Array_Control;

            }
            set
            {
                Array_Control = value;           }
        }
        public int[] Arrayindexcontrol
        {
            get {
                return Array_index_control;
            }
            set {
                Array_index_control = value;
            }
        }
        public int index 
        {
            get
            {
                return _index;
            }
            set
            {
                 _index = value;
             
            }

        }
        
        public string[] Array_changement
        {
            get
            {
                return Array_Changement;
            }
            set
            {
                Array_Changement = value;
            }
        }
        public  string[] Random_Array
        {
            get
            {
                return _Random_Array;
            }
            set
            {
                _Random_Array = value;
            }
        }
        public int Verification(int a,string b,string[] c)
        {
            
            
            if (b.Equals(c[a]))
            {
                
                
                return 1;

            }
            else 
            {
                return 0;
            
            }
            

        }

        
        
    }
    public static class Rndf
    {
        
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber( int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next( max);
            }
        }
    }
}
