using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CluesControl : MonoBehaviour
{
    public CluesControl clueControl;
    public CluesControl previousClue;

    public void RevealNextClue()
    {
        clueControl.gameObject.SetActive(true);
        previousClue.gameObject.SetActive(false);
    }
}
