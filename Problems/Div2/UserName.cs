using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Div1
{
    class UserName
    {
        public String newMember(String[] existingNames, String newName)
        {
            if (!existingNames.Contains(newName))
            {
                return newName;
            }
            else
            {
                // name exists, try parse first

                Match match = Regex.Match(newName, @"([a-zA-Z]*)(\d*)", RegexOptions.IgnoreCase);

                if (match.Success)
                {
                    //Console.WriteLine(match.Groups.Count);
                    //Console.WriteLine("Key1 = " + match.Groups[1].Value);
                    //Console.WriteLine("Key2 = " + match.Groups[2].Value);

                    int start = 0;

                    if (!String.IsNullOrEmpty(match.Groups[2].Value))
                    {
                        start = Int32.Parse(match.Groups[2].Value);
                    }

                    do
                    {
                        start++;

                        string key = match.Groups[1].Value + start;
                        if (!existingNames.Contains(key))
                        {
                            return key;
                        }
                    } while (start < 50);
                }
                else
                {
                    throw new ArgumentException("Invalid newName " + newName);
                }
            }

            return String.Empty;
        }
    }
}
