using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minecraft.InventorySystem
{
    public interface ICurrencyManager
    {
        int GetCurrentCurrency();
        void UpdateCurrency(int amount);
    }
}

