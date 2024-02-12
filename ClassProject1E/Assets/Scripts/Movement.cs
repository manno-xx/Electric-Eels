using UnityEngine;

/// <summary>
/// Basic movement.
/// </summary>
public class Movement : MonoBehaviour
{
    // SerializeField makes the variable appear in the inspector
    // Range(low, high) generates a slider with those values as limits
    [SerializeField, Range(1, 6)] private float Speed = 1;

    /// <summary>
    /// In update the GameObject is moved.
    /// Movement is pretty crude (but works)
    /// Later we'll have a look at movement in physics based systems
    /// </summary>
    void Update()
    {
        // read input
        // create a Vector3 using the input
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        
        // apply to the gameobject
        transform.Translate(movement * Time.deltaTime * Speed);
    }
}
