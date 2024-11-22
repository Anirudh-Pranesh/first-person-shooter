using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class slowtest : MonoBehaviour
{

    public Volume volume;
    public ChromaticAberration chromatic;
    public LensDistortion distortion;
    public Vignette vignette;
    public DepthOfField depth;
    public ColorAdjustments color;
    public bool boolean;
    void Start()
    {
        volume.profile.TryGet<ChromaticAberration>(out chromatic);
        volume.profile.TryGet<LensDistortion>(out distortion);
        volume.profile.TryGet<Vignette>(out vignette);
        volume.profile.TryGet<DepthOfField>(out depth);
        volume.profile.TryGet<ColorAdjustments>(out color);
    }
    private void OnTriggerEnter()
	{
        boolean = true;

        while(boolean == true)
		{
            vignette.intensity.value = Mathf.Lerp(vignette.intensity.value, 0.356f, 10f * Time.deltaTime);
            chromatic.intensity.value = Mathf.Lerp(chromatic.intensity.value, 1f, 10f * Time.deltaTime);
            distortion.intensity.value = Mathf.Lerp(distortion.intensity.value, -0.7f, 10f * Time.deltaTime);
            depth.gaussianEnd.value = Mathf.Lerp(depth.gaussianEnd.value, 400f, 10f * Time.deltaTime);
            color.contrast.value = Mathf.Lerp(color.contrast.value, 15f, 10f * Time.deltaTime);
            Time.timeScale = Mathf.Lerp(Time.timeScale, 0.1f, 10f * Time.deltaTime);
            Time.fixedDeltaTime = Mathf.Lerp(Time.fixedDeltaTime, 0.02f * Time.timeScale, 10f * Time.deltaTime);
        }
    }

	private void OnTriggerExit()
	{
        boolean = false;

        while(boolean == false)
		{
            vignette.intensity.value = Mathf.Lerp(vignette.intensity.value, 0.22f, 10f * Time.deltaTime);
            chromatic.intensity.value = Mathf.Lerp(chromatic.intensity.value, 0f, 10f * Time.deltaTime);
            distortion.intensity.value = Mathf.Lerp(distortion.intensity.value, 0f, 10f * Time.deltaTime);
            depth.gaussianEnd.value = Mathf.Lerp(depth.gaussianEnd.value, 55f, 10f * Time.deltaTime);
            color.contrast.value = Mathf.Lerp(color.contrast.value, 6f, 10f * Time.deltaTime);
            Time.timeScale = Mathf.Lerp(Time.timeScale, 1f, 10f * Time.deltaTime);
            Time.fixedDeltaTime = Mathf.Lerp(Time.fixedDeltaTime, 0.02f, 10f * Time.deltaTime);
        }
    }
}
