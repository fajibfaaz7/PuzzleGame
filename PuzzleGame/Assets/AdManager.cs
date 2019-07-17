using UnityEngine;
using GoogleMobileAds.Api;
public class AdManager : MonoBehaviour
{
    public static AdManager Instance { set; get; }
    private BannerView bannerView;
    private InterstitialAd interstitialAd;
    private string appID = "ca-app-pub-1863733579815414~4152575888";
    
    void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        MobileAds.Initialize(appID);
        this.RequestBanner();
    }

    private void RequestBanner()
    {
        string bannerID = "ca-app-pub-1863733579815414/3961004198";
        bannerView = new BannerView(bannerID, AdSize.Banner, AdPosition.Top);
        AdRequest request = new AdRequest.Builder().Build();
        bannerView.LoadAd(request);
    }

    public void RequestInterstitial()
    {
        string interstitialID = "ca-app-pub-1863733579815414/6068292789";
        this.interstitialAd = new InterstitialAd(interstitialID);
        AdRequest request = new AdRequest.Builder().Build();
        this.interstitialAd.LoadAd(request);
    }

    public void Glass()
    {
        if (this.interstitialAd.IsLoaded())
        {
            this.interstitialAd.Show();
        }
        //interstitialAd.Destroy();
    }
}
