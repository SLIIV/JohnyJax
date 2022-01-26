using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingWindow : MonoBehaviour
{
    [SerializeField] private Slider _loadingSlider;

    private void Update() 
    {
        _loadingSlider.value = GameSceneManager.LoadingLevelPrecent;
    }
}
