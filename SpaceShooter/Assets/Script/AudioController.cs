using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource audioSource;

    private int audioClipInt;
    [SerializeField] private AudioClip audioClip1;
    [SerializeField] private AudioClip audioClip2;
    [SerializeField] private AudioClip audioClip3;
    [SerializeField] private AudioClip audioClip4;
    [SerializeField] private AudioClip audioClip5;
    [SerializeField] private AudioClip audioClip6;
    [SerializeField] private AudioClip audioClip7;
    [SerializeField] private AudioClip audioClip8;
    [SerializeField] private AudioClip audioClip9;
    [SerializeField] private AudioClip audioClip10;
    [SerializeField] private AudioClip audioClip11;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioClipInt = Random.Range(0, 11);
            switch (audioClipInt)
            {
                case 1 :
                {
                    audioSource.clip=audioClip1;
                    audioSource.Play();
                    break;
                }case 2 :
                {
                    audioSource.clip=audioClip2;
                    audioSource.Play();
                    break;
                }case 3 :
                {
                    audioSource.clip=audioClip3;
                    audioSource.Play();
                    break;
                }case 4 :
                {
                    audioSource.clip=audioClip4;
                    audioSource.Play();
                    break;
                }case 5 :
                {
                    audioSource.clip=audioClip5;
                    audioSource.Play();
                    break;
                }case 6 :
                {
                    audioSource.clip=audioClip6;
                    audioSource.Play();
                    break;
                }case 7 :
                {
                    audioSource.clip=audioClip7;
                    audioSource.Play();
                    break;
                }case 8 :
                {
                    audioSource.clip=audioClip8;
                    audioSource.Play();
                    break;
                }case 9 :
                {
                    audioSource.clip=audioClip9;
                    audioSource.Play();
                    break;
                }case 10 :
                {
                    audioSource.clip=audioClip10;
                    audioSource.Play();
                    break;
                }case 11 :
                {
                    audioSource.clip=audioClip11;
                    audioSource.Play();
                    break;
                }
            }
        }
    }
}
