using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent (typeof (RawImage))]
public class LoadAdvertisament : MonoBehaviour
{
	/*
	 * Nota del desarrollador:
	 * La url de las imagenes a descargar debe ser estrictamente directa, porque de lo contrario no podra
	 * descargarse, en otras palabras, el servidor debe propocionar la ruta directa para acceder a la imagen,
	 * no a una pagina web que posea la imagen dentro, porque de hacerse asi producira un error
	 * */
	[SerializeField] private readonly string _imageURL = "http://images.earthcam.com/ec_metros/ourcams/fridays.jpg";
	[SerializeField] private RawImage _image;
	[SerializeField] private GameObject _panelLoading;

	private IEnumerator Start ()
	{
		_image = GetComponent<RawImage> ();
		var ad = new WWW (_imageURL);

		Debug.Log ("Empece ejecucion");
		_panelLoading.SetActive (true);

		yield return ad;

		_panelLoading.SetActive (false);

		_image.texture = ad.texture as Texture;

		// Esta forma no sirve porque la textura es un Texture y el metodo recibe un Texture2D
		//ad.LoadImageIntoTexture (_image.texture);
	}
}
