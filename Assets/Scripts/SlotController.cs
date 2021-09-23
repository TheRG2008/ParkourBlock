using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotController : MonoBehaviour
{
    [SerializeField] private GameObject[] _slot;   
    private int _gameLevel;
    private List<int> _deathCount;
    
    private void Awake()
    {
        //if (_gameLevel == 0)
        //{
        //    PlayerPrefs.DeleteAll();
        //}
        _gameLevel = PlayerPrefs.GetInt("GameLevel");
        Debug.Log(_gameLevel);
        _deathCount = new List<int>();
        for (int i = 0; i < _gameLevel; i++)
        {
            int deathCount = PlayerPrefs.GetInt("StarCountLevel" + i.ToString());
            _deathCount.Add(deathCount);
        }
        StarCountChange();

        if (_gameLevel >= 1)
        {            
            OpenNextLevl();
        }
      

    }
    private void Start()
    {
        for (int i = 0; i < _slot.Length; i++)
        {
            _slot[i].GetComponent<Slot>().ChangeText(i + 1);
            _slot[i].GetComponent<Slot>().SlotNumber = i + 1;
        }
    }

    public void StarCountChange()
    {
        for (int i = 0; i < _deathCount.Count; i++)
        {
            Slot slot = _slot[i].GetComponent<Slot>();
            slot.StarCount = _deathCount[i];
            slot.StarUpdate();
        }
    }

    public void OpenNextLevl()
    {
        Slot nextSlot = _slot[_gameLevel].GetComponent<Slot>();
        if (!nextSlot.IsOpen)
        {
            nextSlot.UnLockLvl();
        }
        
    }
}
