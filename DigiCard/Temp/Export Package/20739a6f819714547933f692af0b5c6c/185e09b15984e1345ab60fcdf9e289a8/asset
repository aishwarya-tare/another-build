using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class buttonClicked_mute : MonoBehaviour
{
	public Button yourButton;
	private AudioSource childsound;

	public Sprite OffSprite;
	public Sprite OnSprite;
	public Button flashBut;
	public void ChangeImage() {
		if (flashBut.image.sprite == OnSprite)
			flashBut.image.sprite = OffSprite;
		else {
			flashBut.image.sprite = OnSprite;
		}
	}

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!");
		childsound.Stop();
	}
}