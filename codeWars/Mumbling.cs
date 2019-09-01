using System;
using System.Collections.Generic;
using System.Linq;

namespace codeWars
{
    
    //accum("abcd") -> "A-Bb-Ccc-Dddd"
    
    public class Mumbling
    {
        
        public static String Accum(string s)
        {
            var normalList = s.ToList();
            var mumblingList = "";

            for ( int i =0; i<normalList.Count; i++)
            {
                if ( i > 0)
                {
                    mumblingList += '-';
                }
                
                
                for (int j = 1; j<=i+1 ; j++ )
                {

                    if (j==1)
                    {
                        mumblingList += Char.ToUpper(normalList[i]);

                    }
                    else
                    {
                        mumblingList +=Char.ToLower(normalList[i]) ;
                    }

                }

            }

            return mumblingList.ToString();

        }
        
    }
}


