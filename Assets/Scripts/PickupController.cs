using UnityEngine;
using static UnityEditor.Progress;

public class PickupController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            TryPickupItem();
        }
    }

    void TryPickupItem()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1f))
        {
            Item item = hit.collider.GetComponent<Item>();
            if (item != null)
            {
                item.PickUp();
                AddToInventory(item);
              
            }
        }
    }

    void AddToInventory(Item item)
    {
       
        InventoryManager.instance.AddItem(item);
    }
}
