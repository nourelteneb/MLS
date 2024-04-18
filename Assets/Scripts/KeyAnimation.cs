using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAnimation: MonoBehaviour
{
  //   public AudioSource aud;
    public Animator animator;
    private KeysControl key;

    private void Start()
    {
        key = GetComponent<KeysControl>();
        // aud = GetComponent<AudioSource>();
    }


    public void PlayKeyAnimation()
    {
        animator.Play("KeyAni1");
	animator.Play("KeyAni2");
	animator.Play("KeyAni3");
	animator.Play("KeyAni4");
	animator.Play("KeyAni5");
	animator.Play("KeyAni6");
	animator.Play("KeyAni7");
        // aud.Play();
        key.RevealNextKey();
    }
}
