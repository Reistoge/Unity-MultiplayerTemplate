


using System;

public static class GameEvents
{




    public static Action<GameTypes.CameraType> OnPlayerChangeCameraType;

    public static void TriggerOnPlayerChangeCameraType(GameTypes.CameraType cameraState)
    {
        OnPlayerChangeCameraType?.Invoke(cameraState);
    }


    public static Action OnPlayerInstantiated;
    public static void TriggerOnPlayerInstantiated()
    {
        OnPlayerInstantiated?.Invoke();
    }





}