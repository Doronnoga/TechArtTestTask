using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage : MonoBehaviour
{
    [SerializeField] private Button _button;
    
    [SerializeField] private GameObject _stateLocked;
    [SerializeField] private GameObject _stateCurrent;
    [SerializeField] private GameObject _stateDone;

    private int _index = 2;
    
    private void OnEnable()
    {
        _button.onClick.AddListener(OnClickHandler);
    }
    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnClickHandler);
    }

    private void OnClickHandler()
    {
        _index++;
        if (_index > 2)
        {
            _index = 0;
        }
        _stateLocked.SetActive(_index == 0);
        _stateCurrent.SetActive(_index == 1);
        _stateDone.SetActive(_index == 2);
    }
}
