using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour
{
    // Start is called before the first frame update
    public YouWin youwin;

    public void RevealYouWin()
    {
        youwin.gameObject.SetActive(true);
    }
}
