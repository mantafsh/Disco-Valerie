using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interact : MonoBehaviour
{
    public UnityEvent OnInteract;

    private void Start()
    {
        Interaction();
    }

    private void Update()
    {
        
    }

    private void Interaction() 
    { 
        OnInteract.Invoke();
    }
}
