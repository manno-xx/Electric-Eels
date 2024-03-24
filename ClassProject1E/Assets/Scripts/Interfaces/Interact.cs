using UnityEngine;

/// <summary>
/// Checks of the game object nearby (close, hit by raycast) is an interactible
/// If so: Interact!
/// <seealso cref="IInteractible"/>
/// </summary>
public class Interact : MonoBehaviour
{
    [SerializeField] private LayerMask myMask;
    
    void Update()
    {
        // if the e key is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            // define a ray from where the cam is at into its looking direction
            Ray ray = new Ray(transform.position, transform.forward);
            
            // if it hits _anything at all_
            if (Physics.Raycast(ray, out RaycastHit hitInfo, 4, myMask))
            {
                // if _what_ it has hit, is an interactible
                if (hitInfo.transform.TryGetComponent<IInteractible>(out IInteractible interactible))
                {
                    //   THEN: interact with it
                    interactible.Interact();
                }
            }
        }
    }
}
