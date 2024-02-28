using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class Shaker : MonoBehaviour
{
    [SerializeField]
    private AnimationCurve intensityCurve;
    
    [SerializeField]
    [Range(0, 3)]
    private float intensity;
    
    [SerializeField]
    [Range(0, 4)]
    private float shakeDuration;
    
    private Vector3 _shakeStartPos;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _shakeStartPos = transform.position;
            StartCoroutine(Shake());
        }
    }

    IEnumerator Shake()
    {
        float t = 0f;

        while (t <= 1)
        { 
            float radius = intensityCurve.Evaluate(t) * intensity;

            Vector3 displacement = Random.onUnitSphere * radius;
            displacement.z = 0;
            
            transform.position = _shakeStartPos + displacement;
            
            t += Time.deltaTime / shakeDuration;
            
            yield return new WaitForEndOfFrame();
        }
        
        transform.position = _shakeStartPos;
    }
}