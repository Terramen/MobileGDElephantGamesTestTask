using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnimation : MonoBehaviour
{
    private Animator _animator;
    private AudioSource _source;
    [SerializeField] private string _animationName;
    [SerializeField] private AudioClip _soundOnClick;

    private void Start()
    {
        _source = GetComponent<AudioSource>();
        _source.clip = _soundOnClick;
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
        _source.Play();
    }
}





