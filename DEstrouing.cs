using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEstrouing : MonoBehaviour
{

    public GameObject gm;

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gm);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
