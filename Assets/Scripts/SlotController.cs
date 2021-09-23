using System.Collections.Generic;
using UnityEngine;


public class SlotController : MonoBehaviour
{
    [SerializeField] private GameObject[] _slot;   
    private int _gameLevel;
    private List<int> _deathCount;
    
    private void Awake()
    {
        LoadSaveData();
        StarCountChange();                
        OpenNextLevl();        
    }
    private void Start()
    {
        GetSlotNumbers();
    }

    public void LoadSaveData()
    {
        _gameLevel = PlayerPrefs.GetInt("GameLevel");
        _deathCount = new List<int>();
        for (int i = 0; i < _gameLevel; i++)
        {
            int deathCount = PlayerPrefs.GetInt("StarCountLevel" + i.ToString());
            _deathCount.Add(deathCount);
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
        for (int i = 0; i <= _gameLevel; i++)
        {
            Slot slot = _slot[i].GetComponent<Slot>();
            slot.UnLockLvl();
        }
    }

    public void GetSlotNumbers()
    {
        for (int i = 0; i < _slot.Length; i++)
        {
            _slot[i].GetComponent<Slot>().ChangeText(i + 1);
            _slot[i].GetComponent<Slot>().SlotNumber = i + 1;
        }
    }
}
