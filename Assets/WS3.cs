using UnityEngine;
using FMODUnity;
using FMOD.Studio;


public class WS3 : MonoBehaviour
{
    public float timer = 5f;
    public EventInstance eventInstance;
    public EventReference eventReference;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        eventInstance = RuntimeManager.CreateInstance(eventReference);
        eventInstance.start();
    }

    // Update is called once per frame
    void Update()
    {   
        if (timer <= 0f)
        {
            eventInstance.setParameterByName("Parameter1", 1);
    }
}
