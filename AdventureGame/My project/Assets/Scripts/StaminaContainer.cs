using UnityEngine;

public class StaminaContainer : MonoBehaviour
{
    public SimpleFloatData staminaData;

    public void ReduceStamina(float amount)
    {
        staminaData.UpdateValue(amount);
    }
}
