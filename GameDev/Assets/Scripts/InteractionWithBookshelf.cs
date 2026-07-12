using UnityEngine;

public class InteractWithBookshelf : MonoBehaviour, Interactable
{

    public static bool hasReadNotes = false;
    [SerializeField] private NoteUI noteUI;

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

    public void setCanInteract(bool value)
    {
        hasReadNotes = value;   
    }
}