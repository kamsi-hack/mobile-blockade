using UnityEngine;

public class LootItem : MonoBehaviour
{
    public string itemName;

    void OnTriggerEnter(Collider other)
    {
        Inventory inv = other.GetComponent<Inventory>();

        if (inv != null)
        {
            inv.AddItem(itemName);
            Destroy(gameObject);
        }
    }
}
