using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HPBar : MonoBehaviour
{
    // the reference to the hp bar
    private Image bar;

    [SerializeField] private Gradient barColor;
    
    // Start is called before the first frame update
    void Start()
    {
        // look for the Image component on this gameobject and store in variable
        bar = GetComponent<Image>();
    }
    
    /// <summary>
    /// this should update the UI image 
    /// </summary>
    /// <param name="percentage"></param>
    public void ShowHealth(float percentage)
    {
        // set the width of the bar to reflect the percentage indicated
        bar.fillAmount = percentage;
        // change the color of the bar
        bar.color = barColor.Evaluate(percentage);
    }
}
