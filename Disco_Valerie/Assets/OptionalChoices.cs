using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OptionalChoices : MonoBehaviour
{
    DIalogueManager dialogueManager;
    DialogueLine dialogueLine;
    public TextMeshProUGUI dialogueText;
   
    public void SetUp(DIalogueManager _dialogueManager, DialogueLine _dialogueLine, string _dialogueText) 
    { 
        dialogueManager = _dialogueManager;
        dialogueLine = _dialogueLine;   
        dialogueText.text = _dialogueText;
    }

    public void SelectOption() 
    {
        dialogueManager.UpdateDialogue(dialogueLine);
    }
}
