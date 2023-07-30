using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnimation : MonoBehaviour
{
    private Animator _animator;
    [SerializeField] private string _animationName;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnMouseUp()
    {
        _animator.enabled = true;
        PlayAnimationOnClick();
    }

    private void PlayAnimationOnClick()
    {
        _animator.Play(_animationName);
    }
}





