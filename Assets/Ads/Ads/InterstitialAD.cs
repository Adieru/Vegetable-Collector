using UnityEngine.Advertisements;
using UnityEngine;


public class InterstitialAD : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
{
    [SerializeField] string _androidAdUnitId = "Interstitial_Android";
    string _adUnityId = null;

    private void Awake()
    {
        _adUnityId = _androidAdUnitId;
    }
    public void LoadAd()
    {
        Debug.Log("Loading Ad " + _adUnityId);
        Advertisement.Load(_adUnityId , this);
    }

    public void ShowAd()
    {
      
        Debug.Log("Showing Ad: " + _adUnityId);
        Advertisement.Show(_adUnityId,this);
    }
    

    #region LoadCallBacks
    public void OnUnityAdsAdLoaded(string placementId)
    {
        Debug.Log("Ad is loaded");
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        Debug.Log("Ad is Failed to load");
    }
    #endregion

    #region ShowCallBacks
    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        LoadAd();
       // StartCoroutine(LevelManager.Instance.ReadyToLoadLevel()); 
    }

    public void OnUnityAdsShowStart(string placementId)
    {
        Debug.Log("Show Start");
    }

    public void OnUnityAdsShowClick(string placementId)
    {
        Debug.Log("show click");
    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        LoadAd();
   
       //StartCoroutine(LevelManager.Instance.ReadyToLoadLevel());



    }

   
    #endregion
}
