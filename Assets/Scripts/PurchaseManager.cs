using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Minecraft.InventorySystem
{
    public class PurchaseManager : MonoBehaviour
    {
        public EmeraldManager emeraldManager;
        public int emeraldcost = 0;
        
        public void Purchase()
        {
            if (emeraldManager.myemerald >= emeraldcost)
            {
                emeraldManager.myemerald -= this.emeraldcost;
                emeraldManager.EmeraldUpdate();
            }
        }
    }
}

