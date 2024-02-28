using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

/// <summary>
/// Class to keep track of health
/// When Health changes, it will send out a message 
/// </summary>
public class Health : MonoBehaviour
{
    [SerializeField] private float currentHealth = 0;
    [SerializeField] private float maxHealth = 100;

    [SerializeField] private UnityEvent<float> healthChanged;
    [SerializeField] private UnityEvent gameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        BroadcastEvents();
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
        currentHealth -= damageDone;
        
        // todo: let 'the world' know the stats have changed. (to update the HUD)
        BroadcastEvents();
    }

    /// <summary>
    /// Send out message on health stats
    /// </summary>
    private void BroadcastEvents()
    {
        healthChanged?.Invoke(currentHealth/maxHealth);
        if (currentHealth <= 0)
        {
            gameOver?.Invoke();
        }
    }
}
