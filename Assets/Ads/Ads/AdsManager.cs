using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdsManager : MonoBehaviour
{
    public AdsInitializer _adsInitializer;
    public BannedAD _bannerAD;
    public InterstitialAD _interstitialAd;
    public RewardAD _rewardAd;
    public static AdsManager Instance { get; private set;}
    private void Awake()
    {
        if(Instance !=null && Instance !=this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
