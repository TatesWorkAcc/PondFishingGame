using UnityEngine;
using UnityEngine.EventSystems;
public class InventorySlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        InventoryItem inventoryItem = dropped.GetComponent<InventoryItem>();

        if(transform.childCount != 0)
        {           
            GameObject current = transform.GetChild(0).gameObject;
            InventoryItem currentItem = current.GetComponent<InventoryItem>();

            currentItem.transform.SetParent(inventoryItem.parentAfterDrag);
        }
        inventoryItem.parentAfterDrag = transform;
    }
}
