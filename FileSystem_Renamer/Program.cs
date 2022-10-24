using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folder_Renamer
{
    class Program
    {
        static void Main(string[] args)
        {
            var parent = new System.IO.DirectoryInfo(@"Parent_Folder\To_Rename_Content");

            foreach (var child in parent.GetDirectories())
            {
                var newName = child.FullName.Replace("StringToReplace", "NewString");

                if (newName == child.FullName)
                {
                    continue;
                }
                child.MoveTo(newName);
            }
        }
    }
}
