using UnityEngine;
using System.Collections;

public class Mirror : MonoBehaviour {

	public Camera mirrorCam;
	public MeshRenderer mirrorRenderer;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		mirrorRenderer.material.mainTexture = RTImage ();
	}

	Texture2D RTImage(){
		RenderTexture currentRT = RenderTexture.active;
		RenderTexture.active = mirrorCam.targetTexture;
		mirrorCam.Render ();

		Texture2D image = new Texture2D(mirrorCam.targetTexture.width, mirrorCam.targetTexture.height);
		image.ReadPixels(new Rect(0, 0, mirrorCam.targetTexture.width, mirrorCam.targetTexture.height), 0, 0);
		image.Apply();
		RenderTexture.active = currentRT;
		return image;
	}
}
