using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Object disappears when you interact with it
/// </summary>
public class InteractDestroy : MonoBehaviour, IInteractible
{
    public void Interact()
    {
        Destroy(gameObject);
    }
}
