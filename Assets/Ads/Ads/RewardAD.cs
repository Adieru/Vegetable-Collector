using UnityEngine.Advertisements;
using UnityEngine;
using UnityEngine.UI;

public class RewardAD : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
{


    public Button _showAdButton;
    [SerializeField] string _androidAdUnitId = "Rewarded_Android";
    string _adUnitId = null;
  
    private void Awake()
    {
        _adUnitId = _androidAdUnitId;
    }

    public void LoadAd()
    {
       
       Advertisement.Load(_androidAdUnitId , this);
    }

    public void OnUnityAdsLoaded(string adUnitId)
    {
        Debug.Log("Reward ad loaded");
        if (adUnitId.Equals(_adUnitId))
        {
       
            _showAdButton.onClick.AddListener(ShowAd);
        }
    }

    public void ShowAd()
    {
        Advertisement.Show(_adUnitId, this);

      


    }
   
    #region LoadCallbacks
    public void OnUnityAdsAdLoaded(string placementId)
    {
        OnUnityAdsLoaded("Rewarded_Android");
    }
        
    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        Debug.Log("Reward ad failed to load");

    }
    #endregion
    #region ShowCallbacks
    public void OnUnityAdsShowClick(string placementId)
    {
        
    }

    public void OnUnityAdsShowComplete(string adUnitId, UnityAdsShowCompletionState showCompletionState)
    {
        if (adUnitId.Equals(_adUnitId) && showCompletionState.Equals(UnityAdsShowCompletionState.COMPLETED))
        {
            Debug.Log("Unity Ads Rewarded Ad Completed");
            // Grant a reward.
          RewardSuccess();
         
      
        }
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
       
    }

    public void OnUnityAdsShowStart(string placementId)
    {
        
    }

   public void RewardSuccess()
    {
        /*if(GoBackManager.Instance._GoBackCounter != 0)
        {
            InstantiaterManager.Instance.InstantiateNewEmptyTube();
        }
              

        // Reset the _GoBackCounter value
        else
        {
            GoBackManager.Instance.ReAssignGoBackCounterValue();
        }*/
        LoadAd();
    }
    #endregion
}
