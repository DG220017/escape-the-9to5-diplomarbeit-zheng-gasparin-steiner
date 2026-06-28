using UnityEngine;

public class InteractWithBookshelf : MonoBehaviour, Interactable
{

    public static bool hasReadNotes = false;

    public bool CanInteract()
    {
        return hasReadNotes;
    }

    public void Interact()
    {
        if (hasReadNotes)
        {
            Debug.Log(" Interact wurde aufgerufen auf: " + gameObject.name);
        }
    }
}