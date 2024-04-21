using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
}

    // Update is called once per frame
    public void PlayButtonAnimation()
    {
        animator.Play("StartButton");
}
}
