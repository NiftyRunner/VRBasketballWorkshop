using UnityEngine;

public class RampManager : MonoBehaviour
{
    [SerializeField] Animator rampAnimator;
    [SerializeField] Vector3 defaultPosition;

    private void Start()
    {
        this.transform.localPosition = defaultPosition;
        rampAnimator = GetComponent<Animator>();
    }

    public void LowerRamp()
    {
        rampAnimator.SetTrigger("ButtonPress");
    }
}
