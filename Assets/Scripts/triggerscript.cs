using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class triggerscript : MonoBehaviour
{
    public PlayableDirector timeline;
    public bool playOnce;

    private void OnTriggerEnter(Collider other)
    {
        timeline.Play();

        if (playOnce == true)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
