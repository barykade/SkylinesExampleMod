using ICities;
using UnityEngine;

namespace ExampleNamespace
{

    public class ExampleModMain: IUserMod
    {

        public string Name 
        {
            get { return "Example Mod"; }
        }

        public string Description 
        {
            get { return "This is an example mod"; }
			
        }
    }

    // Inherit interfaces and implement your mod logic here
    // You can use as many files and subfolders as you wish to organise your code, as long
    // as it remains located under the Source folder.
}
