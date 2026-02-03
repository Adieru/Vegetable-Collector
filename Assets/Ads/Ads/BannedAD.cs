using UnityEngine.Advertisements;
using UnityEngine;

public class BannedAD : MonoBehaviour
{
    [SerializeField] BannerPosition _bannerPosition = BannerPosition.BOTTOM_CENTER;
    [SerializeField] string _androidAdUnitId = "Banner_Android";
    string _adUnityId = null;

    private void Start()
    {
        _adUnityId = _androidAdUnitId;

        Advertisement.Banner.SetPosition(_bannerPosition);
    
    }
  

    public void LoadBanner()
    {
        BannerLoadOptions options = new BannerLoadOptions
        {
            loadCallback = OnBannerLoaded,
            errorCallback =  OnBannerError
        };
        Advertisement.Banner.Load(_adUnityId, options);
    }

    void OnBannerLoaded()
    {
        ShowBannerAd();
    }
    private void OnBannerError(string message)
    {
        Debug.Log($"Banner Error : {message}");
    }

    private void ShowBannerAd()
    {
        BannerOptions options = new BannerOptions
        {
            clickCallback = OnBannerClicked,
            hideCallback = OnBannerHidden,
            showCallback = OnBannerShown
        };
        Advertisement.Banner.Show(_adUnityId,options);
    }

    private void HideBannerAd()
    {
        Advertisement.Banner.Hide();
    }

    void OnBannerClicked() { }
    void OnBannerShown() { }
    void OnBannerHidden() { }
    private void OnDestroy()
    {
        
    }
}
