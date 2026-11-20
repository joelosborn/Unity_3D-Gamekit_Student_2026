using UnityEngine;
using FMOD.Studio;
using FMODUnity;
using Gamekit3D;


public class MusicTrigger : MonoBehaviour
{
 
    public EventReference eventRef;
    private EventInstance eventInstance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        eventInstance = RuntimeManager.CreateInstance("eventRef");
        eventInstance.start();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        //Play the current event
        RuntimeManager.PlayOneShotAttached(eventRef, gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
