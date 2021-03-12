using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    bool open = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (open)
                this.transform.Translate(0, -3f, 0);
            else
                this.transform.Translate(0, 3f, 0);

            open = !open;
        }
    }
}
