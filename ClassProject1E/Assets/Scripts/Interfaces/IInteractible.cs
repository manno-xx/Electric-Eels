
/// <summary>
/// Interact interface
/// Any class that implements this interface _must_ implement the function Interact()
/// This means that other scripts can rely on that function being there to call 
/// </summary>
public interface IInteractible
{
    /// <summary>
    /// Interact with this object.
    /// Implementer is responsible for whet actually happens when interacting
    /// </summary>
    void Interact();
}
