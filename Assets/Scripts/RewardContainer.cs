using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class RewardContainer : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private TMP_Text _gemValue;
    [SerializeField] private TMP_Text _cashValue;
    [SerializeField] private TMP_Text _xpValue;
    
    [SerializeField] private GameObject _cash;
    [SerializeField] private GameObject _gem;
    [SerializeField] private GameObject _xp;
    [SerializeField] private GameObject _plus;
    [SerializeField] private GameObject _plus2;

    private List<Reward> _rewards = new List<Reward>
    {
        new Reward {Cash = 0.5f, Gem = 0, Xp = 0},
        new Reward {Cash = 0f, Gem = 250, Xp = 0},
        new Reward {Cash = 0f, Gem = 0, Xp = 99},
        new Reward {Cash = 20f, Gem = 100, Xp = 50},
        new Reward {Cash = 15.5f, Gem = 1000, Xp = 0},
        new Reward {Cash = 0f, Gem = 345, Xp = 18},
    };

    private int currentRewardIndex = 0;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        UpdateValues();
    }
    
    public void UpdateValues()
    {
        currentRewardIndex++;
        if (currentRewardIndex >= _rewards.Count)
        {
            currentRewardIndex = 0;
        }

        var reward = _rewards[currentRewardIndex];

        bool cashActive = reward.Cash > 0;
        bool gemActive = reward.Gem > 0;
        bool xpActive = reward.Xp > 0;

        _cashValue.text = reward.Cash.ToString();
        _cash.SetActive(cashActive);

        _gemValue.text = reward.Gem.ToString();
        _gem.SetActive(gemActive);

        _xpValue.text = reward.Xp.ToString();
        _xp.SetActive(xpActive);

        // added
        _plus.SetActive(cashActive && gemActive);
        _plus2.SetActive(gemActive && xpActive);
    }

    public class Reward
    {
        public float Cash;
        public int Gem;
        public int Xp;
    }
}
