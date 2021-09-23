using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private GameObject[] _stars;
    [SerializeField] private bool _isOpen = false;
    [SerializeField] private GameObject _lock;
    private int _slotNumber;
    private int _starCount;
    private readonly int _maxStarCount = 3;

    public int SlotNumber 
    { 
        get => _slotNumber; 
        set => _slotNumber = value;
    }
    public int StarCount 
    { 
        get => _starCount; 
        set
        {
            _starCount = value;
            if(_starCount < 0)
            {
                _starCount = 0;
            }
        }
    }
    public bool IsOpen { get => _isOpen; set => _isOpen = value; }

    public void ChangeText(int lvl)
    {
        _text.text = lvl.ToString();
    }

    public void StarUpdate()
    {
        for (int i = 0; i < _maxStarCount; i++)
        {
            _stars[i].SetActive(false);
        }
        for (int i = 0; i < StarCount; i++)
        {
            _stars[i].SetActive(true);
        }
    }
    
    public void UnLockLvl()
    {
        _isOpen = true;
        _lock.SetActive(false);
    }

    
}
