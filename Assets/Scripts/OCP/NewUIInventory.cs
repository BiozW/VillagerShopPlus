using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Minecraft.InventorySystem
{
    public class NewUIInventory : MonoBehaviour
    {
        [Header("Category")]
        [SerializeField] TMP_Text categoryText;

        [Header("Current Item")]
        [SerializeField] Image currentItemIconImage;

        [Header("Item List")]
        [SerializeField] NewUIItem itemUIPrefab;
        [SerializeField] List<IUIItem> itemUIList = new List<IUIItem>();

        void Start()
        {
            itemUIPrefab.gameObject.SetActive(false);
        }

        public void SetCategory(CategoryInfo info)
        {
            categoryText.text = info.name;
        }

        public void SetItemList(NewUIItem_Data[] uiDatas)
        {
            // Clear and destroy created UIs first, before creating new ones.
            ClearAllItemUIs();
            foreach (var uiItemData in uiDatas)
            {
                // When creating a new UI, ALWAYS put it inside Canvas and pass false for 'worldPositionStays'.
                // This is because all UIs are always in Screen Space, not World Space.
                var newItemUI = Instantiate(itemUIPrefab, itemUIPrefab.transform.parent, false);

                // Don't forget to enable it because the original UIItem was disabled from Start().
                newItemUI.gameObject.SetActive(true);
                itemUIList.Add(newItemUI);
                newItemUI.SetData(uiItemData);
            }
        }

        // Destroy all created IUIItem and then clear the list.
        public void ClearAllItemUIs()
        {
            foreach (IUIItem uiItem in itemUIList)
                Destroy((MonoBehaviour)uiItem);

            itemUIList.Clear();
        }
    }

    [Serializable]
    public class CategoryInfo
    {
        public string name;
        public Sprite icon;
    }
}
