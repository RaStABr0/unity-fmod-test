using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;

public class StepPlayer : MonoBehaviour
{
    private StudioEventEmitter _emitter;

    private void Awake() => _emitter = GetComponent<StudioEventEmitter>();

    public void Play() => _emitter.Play();
    
    public void SetSurface(float value) => _emitter.SetParameter("Surface", value);
}
