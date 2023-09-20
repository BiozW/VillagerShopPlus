using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

namespace Minecraft.InventorySystem
{
    public interface IUIItem
    {
        void SetData(NewUIItem_Data data);
    }

    public class NewUIItem : MonoBehaviour, IUIItem, IPointerEnterHandler, IPointerExitHandler
    {
        public GameObject ItemIcon;
        [SerializeField] TMP_Text costText;
        [SerializeField] TMP_Text countText;
        [SerializeField] Image pointerImage;
        public NewPurchaseManager newpurchase;
        [SerializeField] TextMeshProUGUI descriptionShow;

        public string description_text;

        public void SetData(NewUIItem_Data data)
        {
            descriptionShow.text = data.itemData.description;
            description_text = data.itemData.description;
            newpurchase.emeraldcost = data.itemData.cost;
            costText.text = "" + data.itemData.cost;
            countText.text = data.itemData.count == 1 ? "" : data.itemData.count.ToString();
            ItemIcon.GetComponent<Image>().sprite = data.itemData.icon;
            pointerImage.gameObject.SetActive(data.isSelected);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            descriptionShow.text = description_text;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            descriptionShow.text = "";
        }
    }

    // Create a DTO class that holds information of the item and also tells if the item is selected.
    public class NewUIItem_Data
    {
        public ItemData itemData;
        public bool isSelected;

        public NewUIItem_Data(ItemData itemData, bool isSelected)
        {
            this.itemData = itemData;
            this.isSelected = isSelected;
        }
    }
}

