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
}
