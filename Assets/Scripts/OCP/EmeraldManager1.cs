using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minecraft.InventorySystem
{
    public class EmeraldManager1 : MonoBehaviour, ICurrencyManager
    {
        public int myemerald = 0;
        public bool infinite = false;
        public TMPro.TMP_Text emeraldText;


        public int GetCurrentCurrency()
        {
            return myemerald;
        }

        public void UpdateCurrency(int amount)
        {
            myemerald += amount;
            EmeraldUpdate();
        }

        // Other methods for EmeraldManager
        private void EmeraldUpdate()
        {
            // Your implementation here
            emeraldText.text = myemerald.ToString();
        }

        private void InfiniteEmerald()
        {
            if (infinite == true)
            {
                if (myemerald <= 3)
                {
                    myemerald = 64;
                }
            }
        }
    }
}

