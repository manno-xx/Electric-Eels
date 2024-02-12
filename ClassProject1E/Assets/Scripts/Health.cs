using UnityEngine;

/// <summary>
/// Class to keep track of health
/// When Health changes, it will send out a message 
/// </summary>
public class Health : MonoBehaviour
{
    
    [SerializeField] private float CurrentHealth = 0;
    [SerializeField] private float MaxHealth = 100;    
    
    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    /// <summary>
    /// When I click this GameObject
    /// Only works of there is a collider attached to it.
    /// </summary>
    private void OnMouseDown()
    {
        DoDamage(5);
    }

    /// <summary>
    /// A public function/method to do damage
    /// public so that in the future other game objects (like a bullet) can execute the function
    /// </summary>
    /// <param name="damageDone"></param>
    public void DoDamage(int damageDone)
    {
        CurrentHealth -= damageDone;
        
        // todo: let 'the world' know the stats have changed. (to update the HUD)
    }
}
