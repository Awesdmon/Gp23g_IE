using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ad : MonoBehaviour
{
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;
    public AudioClip clip5;
    public AudioClip clip6;
    public AudioClip clip7;
    public AudioClip clip8;
    public AudioClip clip9;
   



    private AudioSource Ad_audio;
    private int DSaudio = 0;
    private int Arson = 0;
    private int pure = 0;
    private int mace = 0;
    public Texture2D Advertisement1;
    public Texture2D Advertisement2;
    public Texture2D Advertisement3;
    public Texture2D Advertisement4;
    public Texture2D Advertisement5;
    public Texture2D Advertisement6;
    public Texture2D Advertisement7;
    public Texture2D[] ad_list;
    public Texture2D rand_ad;

   private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Ad_audio = GetComponent<AudioSource>();
        ad_list = new Texture2D[] {Advertisement1, Advertisement2, Advertisement3, Advertisement4, Advertisement5, Advertisement6, Advertisement7};
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
    // Update is called once per frame
    void Update()
    {
        
    }


    public void Ad_change()
    {
        Texture2D rand_ad = ad_list[Random.Range(0, ad_list.Length)];
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = rand_ad;
       
    }
    public void Play_ad()
    {
        if (rand_ad == Advertisement1 && DSaudio == 0)
        {
            Ad_audio.clip = clip1;
            Ad_audio.Play();
            DSaudio++;
        }
        else if (rand_ad == Advertisement1 && DSaudio == 1)
        {
            Ad_audio.clip = clip2;
            Ad_audio.Play();
        }
        else if(rand_ad == Advertisement2 && Arson == 0)
        {
            Ad_audio.clip = clip3;
            Ad_audio.Play();
            Arson++;
        }
        else if(rand_ad == Advertisement2 && Arson == 1)
        {
            Ad_audio.clip = clip4;
            Ad_audio.Play();
        }
        else if( rand_ad == Advertisement3 && pure == 0)
        {

            Ad_audio.clip = clip5;
            Ad_audio.Play();
            pure++;
        }
        else if (rand_ad == Advertisement3 && pure == 1)
        {
            Ad_audio.clip = clip6; 
            Ad_audio.Play();
        }
        else if (rand_ad == Advertisement4 && mace == 0)
        {
            Ad_audio.clip = clip7;
            Ad_audio.Play();
            mace++;
        }
        else if (rand_ad ==Advertisement4 && mace == 1)
        {
            Ad_audio.clip = clip8; 
            Ad_audio.Play();
        }
        else if (rand_ad == Advertisement5)
        {
            Ad_audio.clip = clip9;
            Ad_audio.Play();
        }
    }
    public void reset_audio()
    {
        if (Ad_audio.isPlaying)
        {
            Ad_audio.Stop();
        }


    }

    public void turn_on_gravity()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;

    }
}


