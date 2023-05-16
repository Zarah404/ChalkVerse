using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip ThrowSound , shotgunSound , BazookaSound ;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        ThrowSound = Resources.Load<AudioClip> ("throw");
        shotgunSound = Resources.Load<AudioClip> ("shotgun");
        BazookaSound = Resources.Load<AudioClip> ("bazooka");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch(clip)
        {
            case "throw" :
                audioSrc.PlayOneShot(ThrowSound);
                break;
            case "shotgun" :
                audioSrc.PlayOneShot(shotgunSound);
                break;
            case "bazooka" :
                audioSrc.PlayOneShot(BazookaSound);
                break;  
        }
    }
}
