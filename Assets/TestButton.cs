using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButton : MonoBehaviour
{
    public RectTransform[] potentialParents;
    public GameObject[] P_pos;
 public GameObject child;
 public int counter;
    private AudioSource Story;
    public RectTransform position1;
    public RectTransform position2;
    public RectTransform position3;
    public RectTransform position4;
    public RectTransform position5;
    public RectTransform position6;
    public RectTransform position7;
    public RectTransform position8;
    public RectTransform position9;
    public RectTransform position10;
    public RectTransform position11;
    public RectTransform position12;
    public RectTransform position13;
    public RectTransform position14;
    public RectTransform position15;
    public RectTransform position16;
    public RectTransform position17;
    public RectTransform position18;
    public RectTransform position19;
    public RectTransform position20;
    public RectTransform position21;
    public RectTransform position22;
    public RectTransform position23;
    public RectTransform position24;
    public RectTransform position25;
    public RectTransform position26;
    public RectTransform position27;

    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;
    public AudioClip clip5;
    public AudioClip clip6;
    public AudioClip clip7;
    public AudioClip clip8;
    public AudioClip clip9;
    public AudioClip clip10;
    public AudioClip clip11;
    public AudioClip clip12;
    public AudioClip clip13;
    public AudioClip clip14;
    public AudioClip clip15;
    public AudioClip clip16;
    public AudioClip clip17;
    public AudioClip clip18;
    public AudioClip clip19;
    public AudioClip clip20;
    public AudioClip clip21;
    public AudioClip clip22;
    public AudioClip clip23;
    public AudioClip clip24;
    public AudioClip clip25;
    public AudioClip clip26;

    public AudioClip clip27;
    public AudioClip clip28;
        
    public AudioClip clip29;
    public AudioClip clip30;
    public AudioClip clip31;
    public void Start()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        Story.clip = clip13;
        Story.Play();
        P_pos = new GameObject[] { pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9, pos10, pos11, pos12, pos13, pos14, pos15, pos16, pos17, pos18, pos19, pos20, pos21, pos22, pos23, pos24, pos25, pos26, pos27 };
        GameObject rand_pos = P_pos[Random.Range(0, P_pos.Length)];
        potentialParents = new RectTransform[] { position1, position2, position3, position4, position5, position6, position7, position8, position9, position10, position11, position12, position13, position14, position15, position16, position17, position18, position19, position20, position21, position22, position23, position24, position25, position26, position27 };
        RectTransform randomParent = potentialParents[Random.Range(0, potentialParents.Length)];
           
    }









    public void increase_counter()
    {
   
        counter++;
        if (counter == 2)
        {
            Story.clip = clip14;
            Story.Play();
        }
        else if (counter == 4)
        {
            Story.clip = clip15;  
            Story.Play();
        }
        if (counter == 6)
        {
            Story.clip = clip16;
            Story.Play();
        }
        if(counter == 8)
        {
            Story.clip = clip17;
            Story.Play();
        }
        if (counter == 10)
        {
            Story.clip = clip18;
            Story.Play();
        }
        if (counter == 12)
        {
            Story.clip = clip19;
            Story.Play();

        }
        if (counter == 14)
        {
            Story.clip = clip20;
            Story.Play();
        }
        if (counter == 16)
        {
            Story.clip = clip21;   
            Story.Play();
        }
        if (counter == 18)
        {
            Story.clip = clip22;
            Story.Play();
        }
        if (counter == 20)
        {
            Story.clip = clip23;
            Story.Play();
        }
        if (counter == 22)
        {
            Story.clip = clip2;
            Story.Play();
        }
        if (counter == 24)
        {
            Story.clip = clip3;
            Story.Play();
        }
        if (counter == 26)
        {
            Story.clip = clip4;
            Story.Play();
        }

        if(counter == 28)
        {
            Story.clip = clip5;
            Story.Play();
        }
        if (counter == 30)
        {
            Story.clip = clip6;
            Story.Play();
        }
        if (counter == 32)
        {
            Story.clip = clip7;
            Story.Play();
        }
        if (counter == 34)
        {
            Story.clip = clip8;
            Story.Play();
        }
        if (counter == 36)
        {
            Story.clip = clip9; 
            Story.Play();
        }
        if (counter == 38)
        {
            Story.clip = clip10;
            Story.Play();
        }
        if (counter == 40)
        {
            Story.clip = clip11;
            Story.Play();
        }
        if (counter == 42)
        {
            Story.clip = clip12;
            Story.Play();
        }
        if (counter == 44)
        {
            Story.clip = clip1;
            Story.Play();
        }
        if (counter == 46)
        {
            Story.clip = clip24;
        }
    }
}
