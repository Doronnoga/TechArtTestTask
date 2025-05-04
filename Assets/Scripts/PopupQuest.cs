using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;
public class PopupQuest : MonoBehaviour
{
    [SerializeField] private TMP_Text _missionHeader;
    [SerializeField] private TMP_Text _timerText;
    [SerializeField] private RewardContainer _rewardContainer;
    [SerializeField] private Stage[] _stages;
    
    void Start()
    {
        _missionHeader.text = $"Level {Random.Range(1, 15)} \"Lorem Ipsum\"";
    }


}
