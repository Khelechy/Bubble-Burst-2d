using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

    public static CameraShake Instance { set; get; }


    [HeaderAttribute("Camera Shake Values")]
    public Transform transform;
    public float shakeDuration = 0f;
    public float shakeMagnitude = 0.7f;
    public float dampingSpeed = 1f;

    
    Vector3 initialPosition;

    void Awake()
    {
        Instance = this;
    }
    void OnEnable()
    {
        initialPosition = transform.localPosition;
    }

    void Update()
    {
        if(shakeDuration > 0)
        {
            transform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;
            shakeDuration -= Time.deltaTime * dampingSpeed;
        }
        else
        {
            shakeDuration = 0f;
            transform.localPosition = initialPosition;
        }
    }

    public void Shake()
    {
        shakeDuration = 0.1f;
    }
	
}
