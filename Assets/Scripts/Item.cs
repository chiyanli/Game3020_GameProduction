using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public int ID;
    public string Name;

    [Header("SFX")]
    public AudioClip pickupSfx;
    [Range(0f, 1f)] public float sfxVolume = 1f;

    public virtual void UseItem()
    {
        Debug.Log("Using item " + Name);
    }

    public virtual void PickUp()
    {
        if (pickupSfx != null)
        {
            var cam = Camera.main != null ? Camera.main.transform.position : transform.position;
            AudioSource.PlayClipAtPoint(pickupSfx, cam, sfxVolume);
        }

        Sprite itemIcon = GetComponent<Image>().sprite;
        if (ItemPickupUIController.Instance != null)
        {
            ItemPickupUIController.Instance.ShowItemPickup(Name, itemIcon);
        }
    }
}
