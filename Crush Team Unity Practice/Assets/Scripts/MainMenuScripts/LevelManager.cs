using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
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
        Debug.Log("Level One Selected");
        source.PlayOneShot(clip);
        SceneManager.LoadScene("SampleScene");
    }
}