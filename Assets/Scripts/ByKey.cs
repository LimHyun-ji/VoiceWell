using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByKey : MonoBehaviour
{
    private Animator _animator;
    public KeyCode _key;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(_key))
        {
            _animator.SetBool("pushing", false);
        }
    }
}
