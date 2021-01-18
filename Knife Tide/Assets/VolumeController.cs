using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    // Start is called before the first frame update

    [HideInInspector] public float volume;

    public Slider volumeSlider;
    void Start()
    {
        volume = PlayerPrefs.GetFloat("volume");
        AudioListener.volume = volume;

        if (SceneManager.GetActiveScene().name == "Menu")
        {
            volumeSlider.value = volume;

        }

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void GameVolume(float newVolume)
    {
        volume = newVolume;

        PlayerPrefs.SetFloat("volume", volume);
    }
}
