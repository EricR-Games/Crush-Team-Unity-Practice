using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrap : MonoBehaviour
{
    //Item Variables

    //Chest Open Animations

    public Interact openFromInteraction;

    public AudioSource source;
    public AudioClip clip;
    private void OnEnable()
    {
        if (openFromInteraction)
        {
            openFromInteraction.GetInteractEvent.HasInteracted += OpenChest;
        }
    }

    private void OnDisable()
    {
        if (openFromInteraction)
        {
            openFromInteraction.GetInteractEvent.HasInteracted -= OpenChest;
        }
    }

    public void OpenChest()
    {
        Debug.Log("Opened Chest");
        source.PlayOneShot(clip);
    }
}