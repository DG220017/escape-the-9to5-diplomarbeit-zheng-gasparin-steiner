using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;


public class NoteUI : MonoBehaviour
{
    public static NoteUI Instance;
    PlayerInput playerInput;

    [SerializeField] private GameObject notePanel;
    [SerializeField] private TextMeshProUGUI noteText;
    InputAction close;

    private void Awake()
    {
        playerInput = this.GetComponent<PlayerInput>();
        Instance = this;
        close = this.playerInput.actions.FindAction("Close");
        notePanel.SetActive(false);
    }

    public void ShowNote(string text)
    {
        notePanel.SetActive(true);
        noteText.text = text;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void HideNote()
    {
        notePanel.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (notePanel.activeSelf && close.IsPressed())
        {
            HideNote();
        }
    }
}