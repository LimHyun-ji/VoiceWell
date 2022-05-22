using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duration_five : MonoBehaviour
{
    public Animator _animator;
    public float duration;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("StopClapping");
    }

    IEnumerator StopClapping()
    {
        yield return new WaitForSeconds(duration);
        _animator.SetBool("clapping", false);
    }
}
