using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contract : MonoBehaviour
{
    public Transform[] Parents;
    public Transform position1;
    public Transform position2;
    public Transform position3;
    public Transform position4;
    public Transform position5;
    public Transform position6;
    public Transform position7;
    public Transform position8;
    public Transform position9;
    public Transform position10;
    public Transform position11;
    public Transform position12;
    public Transform position13;
    public Transform position14;
    public Transform position15;
    public Transform position16;
    public Transform position17;
    public Transform position18;
    public Transform position19;
    public Transform position20;
    public Transform position21;
    public Transform position22;
    public Transform position23;
    public Transform position24;
    public Transform position25;
    public Transform position26;
    public Transform position27;

    // Start is called before the first frame update
    void Start()
    {
        Parents = new Transform[] { position1, position2, position3, position4, position5, position6, position7, position8, position9, position10, position11, position12, position13, position14, position15, position16, position17, position18, position19, position20, position21, position22, position23, position24, position25, position26, position27 };
        Transform randomParent = Parents[Random.Range(0, Parents.Length)];
        transform.SetParent(randomParent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
