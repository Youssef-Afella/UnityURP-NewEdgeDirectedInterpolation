using UnityEngine;
using UnityEngine.UI;

public class LuminanceBasedUpscaleManager : MonoBehaviour
{
    public ComputeShader computeShader;

    public Texture inputTexture;

    public RawImage nediTarget;
    public RawImage bilinearTarget;

    public int upscaleFactor = 2;

    [Range(2, 16)] public int windowSize = 4;
    [Range(0.0f, 0.02f)] public float regulate = 0.01f;

    private RenderTexture[] upscaledTextures;

    void Start()
    {
        upscaledTextures = new RenderTexture[upscaleFactor];

        for(int i = 0; i < upscaledTextures.Length; i++)
        {
            int factor = (int)Mathf.Pow(2, i + 1);
            upscaledTextures[i] = new RenderTexture(inputTexture.width * factor, inputTexture.height * factor, 0, RenderTextureFormat.ARGBFloat, 0);
            upscaledTextures[i].enableRandomWrite = true;
            upscaledTextures[i].filterMode = FilterMode.Point;
            upscaledTextures[i].Create();
        }

        nediTarget.rectTransform.sizeDelta = new Vector2(upscaledTextures[upscaledTextures.Length - 1].width, upscaledTextures[upscaledTextures.Length - 1].height);
        bilinearTarget.rectTransform.sizeDelta = new Vector2(upscaledTextures[upscaledTextures.Length - 1].width, upscaledTextures[upscaledTextures.Length - 1].height);

        nediTarget.texture = upscaledTextures[upscaledTextures.Length-1];
        bilinearTarget.texture = inputTexture;
    }

    void Update()
    {
        computeShader.SetInt("WindowSize", windowSize);
        computeShader.SetFloat("Regulate", regulate);

        for(int i = 0; i < upscaledTextures.Length; i++)
        {
            if (i == 0) {
                UpscaleTexture(inputTexture, upscaledTextures[i]);
            }
            else
            {
                UpscaleTexture(upscaledTextures[i-1], upscaledTextures[i]);
            }
        }
    }

    private void UpscaleTexture(Texture input, Texture output) {

        computeShader.SetTexture(0, "InputTex", input);
        computeShader.SetTexture(0, "ResultTex", output);
        computeShader.Dispatch(0, Mathf.CeilToInt(input.width / 8.0f), Mathf.CeilToInt(input.height / 8.0f), 1);

        computeShader.SetTexture(1, "ResultTex", output);
        computeShader.Dispatch(1, Mathf.CeilToInt(input.width / 8.0f), Mathf.CeilToInt(input.height / 8.0f), 1);
    }
}
