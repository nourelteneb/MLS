using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperAni : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void AnimatePaper()
    {
        animator.Play("ClueAni1");
        animator.Play("ClueAni2");
        animator.Play("ClueAni3");
        animator.Play("ClueAni4");
        animator.Play("ClueAni5");
        animator.Play("ClueAni6");
        animator.Play("ClueAni7");

    }
}
