using UnityEngine;

/// <summary>
/// Object bounces up into the air when you interact with it.
/// <seealso cref="IInteractible"/>
/// </summary>
public class InteractBounce : MonoBehaviour, IInteractible
{
    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Interact()
    {
        rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }
}
