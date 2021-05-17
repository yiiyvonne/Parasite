using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

// XRBaseInteractable - OBJECT

[RequireComponent(typeof(XRDirectInteractor))]

	public class AudioGrabPlayer : MonoBehaviour
{
	private XRBaseInteractable interactable = null;
	AudioSource audioData;

	private void Awake()
	{	
        interactable = GetComponent<XRBaseInteractable>();
        interactable.onHoverEntered.AddListener(StartAudio);
        interactable.onHoverExited.AddListener(StopAudio);	
	}

	void Start(){
		audioData = GetComponent<AudioSource>();
		audioData.Play(0);
		Debug.Log("started");	
	}

// hoverEntered and hoverExited	

	private void OnDestroy()
	{	
		interactable.onHoverEntered.RemoveListener(StartAudio); 
		interactable.onHoverExited.RemoveListener(StopAudio);
	}
	
	
	private void StartAudio(XRBaseInteractor interactor)
	{
		audioData.UnPause();
	}

	private void StopAudio(XRBaseInteractor interactor)
	{
		audioData.Pause();
		Debug.Log("Pause: " + audioData.time);
	}
}
