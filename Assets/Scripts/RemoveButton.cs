using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveButton : MonoBehaviour
{
    public RemoveButton removebutton;
    public RemoveButton removebutton2;

    public void DeactivateButton()
    {
        removebutton.gameObject.SetActive(false);
        removebutton2.gameObject.SetActive(false);
    }
}

