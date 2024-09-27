using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    public class Solution {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            foreach (var str in strs)
            {
                char[] charArray = str.ToCharArray();
                Array.Sort(charArray);
                string key = new string(charArray);

                if (!dic.ContainsKey(key))
                {
                    dic.Add(key,new List<string>());
                }
                dic[key].Add(str);
                
            }

            return dic.Values.ToList<IList<string>>();
        }
    }
}