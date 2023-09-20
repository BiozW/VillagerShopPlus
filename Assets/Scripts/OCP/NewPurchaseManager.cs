using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minecraft.InventorySystem
{
    public abstract class NewPurchaseManager : MonoBehaviour
    {
        protected ICurrencyManager currencyManager;
        public int cost = 0;

        public void Purchase()
        {
            if (currencyManager.GetCurrentCurrency() >= cost)
            {
                currencyManager.UpdateCurrency(-cost);
                OnPurchase();
            }
        }

        protected abstract void OnPurchase();
    }
}

