using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingHackerRank
{
    class Ransome
    {

        public static bool canMakeNote(string magazine, string note)
        {
            Dictionary<string, int> dict_m = new Dictionary<string, int>();
            

            string[] magazine_r = magazine.Split(' ');
            string[] note_r = note.Split(' ');
            //Console.WriteLine("Magazine "+string.Join(",",magazine_r));
            //Console.WriteLine("Note " + string.Join(",", note_r));
            // save the magazin
            foreach (var word in magazine_r) {

                if (dict_m.ContainsKey(word))
                {

                    dict_m[word]++;
                }
                else {

                    dict_m.Add(word,1);
                }
            }
            
            foreach (var word in note_r)
            {
                if (dict_m.ContainsKey(word)) {
                    dict_m[word]--;
                    if (dict_m[word] < 0)
                        return false;
                }
                else
                {

                    return false;

                }
            }

            return true;
        }

    }
}
