using UnityEngine;

public class HUDManager : MonoBehaviour
{
    [SerializeField] GameObject cameraPointer;


    void OnEnable()
    {

        GameEvents.OnPlayerChangeCameraType +=handleCameraChange;
    }

    void OnDisable()
    {

    }

    void handleCameraChange(GameTypes.CameraType cameraType)
    {
        switch (cameraType)
        {
            case GameTypes.CameraType.FIRST_PERSON:
                cameraPointer.SetActive(true);
                break;

            case GameTypes.CameraType.THIRD_PERSON:
                cameraPointer.SetActive(false);
                break;

        }
    }
}
