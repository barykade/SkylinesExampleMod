using ICities;
using UnityEngine;

namespace AllTilesOptionNamespace
{
    public class AllTilesOptionMain: IUserMod
    {
        public string Name {
            get { return "All Tiles Purchase Option"; }
        }

        public string Description {
            get { return "When purchasing a new tile, the tile does not have to be adjacent to another to be purchased"; }
        }
    }
}
