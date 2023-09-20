/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minecraft.InventorySystem
{
    public interface IPurchasable
    {
        void Purchase();
    }

    public class NewEmeraldManager : MonoBehaviour
    {
        public int myemerald = 0;

        public void EmeraldUpdate()
        {
            // Update emerald UI here
        }
    }

    public class NewPurchaseManager : MonoBehaviour, IPurchasable
    {
        public NewEmeraldManager emeraldManager;
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
}*/


