using UnityEngine;
using System.Collections;

public class LoadAdCube : MonoBehaviour
{
	[SerializeField] private readonly string _imageURL = "http://images.earthcam.com/ec_metros/ourcams/fridays.jpg";
	[SerializeField] private Renderer _renderer;
	[SerializeField] private Texture2D _urlTexture;
	
	private IEnumerator Start ()
	{
		_renderer = renderer;
		_urlTexture = new Texture2D (150, 150);

		var ad = new WWW (_imageURL);
		
		Debug.Log ("Empece ejecucion");
		
		yield return ad;

		_urlTexture = ad.texture;
		_renderer.material.mainTexture = ad.texture as Texture;
	}
}
