using UnityEngine;
using FMODUnity;
using FMOD.Studio;


public class WS3 : MonoBehaviour
{
    private float timer = 5f;
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
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            eventInstance.setParameterByName("Progress", 1);
        }
    }
}
