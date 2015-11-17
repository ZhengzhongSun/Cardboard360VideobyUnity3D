using UnityEngine;
using System.Collections;

public class VideoGUI : MonoBehaviour {
	
	public MediaPlayerCtrl scrMedia;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		foreach(Touch touch in Input.touches)
		{
			transform.localEulerAngles = new Vector3(
				transform.localEulerAngles.x, transform.localEulerAngles.y + touch.deltaPosition.x, transform.localEulerAngles.z);
		}
		if (Input.GetKey(KeyCode.Escape)) 
		{ 
			Application.Quit(); 
		}
	
	}
	
	void OnGUI() {
		
	
		if( GUI.Button(new Rect(50,25,50,50),"Load"))
		{
			scrMedia.Load("EasyMovieTexture.mp4");
		}
		
		if( GUI.Button(new Rect(50,75,50,50),"Play"))
		{
			scrMedia.Play();
		}
	 	
		if( GUI.Button(new Rect(50,125,50,50),"stop"))
		{
			scrMedia.Stop();
		}
		
		if( GUI.Button(new Rect(50,175,50,50),"pause"))
		{
			scrMedia.Pause();
		}
		
		if( GUI.Button(new Rect(50,225,50,50),"Unload"))
		{
			scrMedia.UnLoad();
		}
		

	}
}
