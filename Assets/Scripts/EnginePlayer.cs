using FMODUnity;
using UnityEngine;

public class EnginePlayer : MonoBehaviour
{
    private StudioEventEmitter _emitter;

    private void Awake() => _emitter = GetComponent<StudioEventEmitter>();
    
    public void SetRPM(float value) => _emitter.SetParameter("RPM", value);

    public void SetLoad(float value) => _emitter.SetParameter("Load", value);
}
