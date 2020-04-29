using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class LightOnCollision : MonoBehaviour
{
    AudioSource audioSource;
    bool triggered = false;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("MainCamera")) && !triggered)
        {
            StartCoroutine(playSound());
            triggered = true;
        }
    }

    IEnumerator playSound()
    {
        audioSource.PlayOneShot(audioSource.clip, 0.3f);
        yield return new WaitForSeconds(audioSource.clip.length);
        Destroy(gameObject);
    }

    public bool isTriggered()
    {
        return triggered;
    }
}
