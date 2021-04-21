using System.Linq;
using FMODUnity;
using UnityEngine;

public class StepPlayer : MonoBehaviour
{
    private StudioEventEmitter _emitter;

    private void Awake() => _emitter = GetComponent<StudioEventEmitter>();

    public void Play() => _emitter.Play();
    
    //Тут какая-то немного странная история. Как я понял, через SetParameter можно настроить то, что уже воспроизводится. 
    //Если надо настроить звук, который мы в ручную воспроизводим, надо заново инициализировать начальные его параметры, 
    //а это можно сделать как показано ниже.
    public void SetSurface(float value) => _emitter.Params.First(p => p.Name == "Surface").Value = value;
    
}
