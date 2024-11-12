using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndustrialExecButton : MonoBehaviour
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
            openFromInteraction.GetInteractEvent.HasInteracted += PressIndustrialExecButton;
        }
    }

    private void OnDisable()
    {
        if (openFromInteraction)
        {
            openFromInteraction.GetInteractEvent.HasInteracted -= PressIndustrialExecButton;
        }
    }

    public void PressIndustrialExecButton()
    {
        Debug.Log("Pressed Button");
        source.PlayOneShot(clip);
    }
}