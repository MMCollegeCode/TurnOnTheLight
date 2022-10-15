using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightswitch : MonoBehaviour
{

    public GameObject light;
    private bool on = false;

    void OnTriggerStay(Collider plyr) {

        if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E) && !on) {

            light.SetActive(true);
            on = true;

        }
        else if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E) && on) {

            light.SetActive(false);
            on = false;        
        
        }    
    
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
