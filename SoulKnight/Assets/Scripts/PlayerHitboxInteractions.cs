using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitboxInteractions : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Item itemProperty = col.gameObject.GetComponent<Item>();
        if (itemProperty != null)
        {
            print(itemProperty.itemType());
        }
    }
}
