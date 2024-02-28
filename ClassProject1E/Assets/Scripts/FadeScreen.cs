using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

/// <summary>
/// Defines a UI image to fade out/in/whatever to signify end of game
/// </summary>
public class FadeScreen : MonoBehaviour
{
    [SerializeField] private float fadeDuration = 2;

    private Image fadeImage;
    
    /// <summary>
    /// Init the component
    /// </summary>
    void Start()
    {
        fadeImage = GetComponent<Image>();
        // I was stupid. In the hurry, while deactivating the object in the inspector
        // I also disabled the Start function from executing. Thus also not defining the fadeImage variable. Anyways...
        gameObject.SetActive(false);  
    }

    /// <summary>
    /// Initialize the fade
    /// - activates the game object (is inactive by default to not clutter the screen)
    /// - starts a coroutine (see below)
    /// </summary>
    public void StartFade()
    {
        gameObject.SetActive(true);
        StartCoroutine(FadeOut());
    }
    
    /// <summary>
    /// Fade in a screen filling UI Image
    /// This is a so-called coroutine (https://docs.unity3d.com/Manual/Coroutines.html). A function that can be paused for a set amount of time
    /// This changes the alpha value of the color of the image and then pauses untill the next frame
    /// </summary>
    /// <returns></returns>
    IEnumerator FadeOut()
    {
        float alpha = 0;
        float fadePerSecond = 1 / fadeDuration; // with this setup, it is also possible to define the fade time in the inspector (see serialized variable at the top)
        Color color = fadeImage.color; // this is a little more optimal than as done in class. Now there is no new Color instance created every frame
        
        while (alpha < 1)
        {
            alpha += fadePerSecond * Time.deltaTime;
            color.a = alpha;
            fadeImage.color = color;
            yield return null;
        }
        // todo: maybe load another scene with the game over screen
    }
}
