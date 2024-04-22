using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearButton : MonoBehaviour
{
    public AppearButton appearbutton1;
    public AppearButton appearbutton2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void RevealButton()
    {
        appearbutton1.gameObject.SetActive(true);
        appearbutton2.gameObject.SetActive(true);
    }
}
