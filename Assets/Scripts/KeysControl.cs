using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysControl : MonoBehaviour
{
    public KeysControl keyControl;

    public void RevealNextKey()
    {
        keyControl.gameObject.SetActive(true);
    }
}
