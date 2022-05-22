using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duration_seven : MonoBehaviour
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
        StartCoroutine("StopTreading");
    }

    IEnumerator StopWalking()
    {
        yield return new WaitForSeconds(duration);
        _animator.SetBool("treading", false);
    }
}
