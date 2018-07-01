using UnityEngine;
using UnityEngine.Advertisements;

public class adds : MonoBehaviour {

	public void ShowAd(){
		if (Advertisement.IsReady ()) {
			Advertisement.Show();
		}
	}
}
