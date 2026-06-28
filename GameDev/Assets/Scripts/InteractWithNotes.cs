using UnityEngine;

public class InteractWithNotes : MonoBehaviour, Interactable
{
    public static bool hasReadNotes = true;

    [TextArea]
    public string noteText;

    public bool CanInteract()
    {
        return hasReadNotes;
    }
    public void Interact()
    {
        Debug.Log(" Interact wurde aufgerufen auf: " + gameObject.name);
        NoteUI.Instance.ShowNote(noteText);
        hasReadNotes = true;
        InteractWithBookshelf.hasReadNotes = true;
    }
}


