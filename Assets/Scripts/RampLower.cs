using UnityEngine;

public class RampLower : MonoBehaviour
{
    [SerializeField] Animator rampAnimator;

    private void Start()
    {
        rampAnimator = GetComponent<Animator>();
    }

    public void LowerRamp()
    {
        rampAnimator.SetTrigger("ButtonPress");
    }
}
