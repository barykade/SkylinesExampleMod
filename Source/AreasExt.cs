using ICities;
using UnityEngine;

namespace AllTilesOptionNamespace
{
    public class AreasExt : IAreasExtension 
    {
        public void OnCreated(IAreas areas){

        }

        public void OnReleased(){

        }

        public bool OnCanUnlockArea(int x, int z, bool originalResult){
            return true;
        }

        public int OnGetAreaPrice(uint ore, uint oil, uint forest, uint fertility, uint water, bool road, bool train, bool ship, bool plane, float landFlatness, int originalPrice){
            return originalPrice;
        }

        public void OnUnlockArea(int x, int z){

        }
    }
}
