using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsInitializer : MonoBehaviour, IUnityAdsInitializationListener
{
    [SerializeField] string _gameId;
    [SerializeField] bool _testMode = false;

    private void Awake()
    {
        InitializeAd();
        AdsManager.Instance._interstitialAd.LoadAd();
        AdsManager.Instance._interstitialAd.ShowAd();
        AdsManager.Instance._rewardAd.LoadAd();
      
      


    }

    private void InitializeAd()
    {
       if(!Advertisement.isInitialized && Advertisement.isSupported)
       {

            Advertisement.Initialize(_gameId,_testMode , this);
            


       }
    }

    public void OnInitializationComplete()
    {
        Debug.Log("Unity Ads initialization complete.");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
    }
}
