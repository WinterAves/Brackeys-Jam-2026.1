using UnityEngine;

namespace Winter.Player
{
    public class PlayerAnimationEvents : MonoBehaviour
    {
        public void AnimEvent_Step()
        {
            PlayerController.Instance.OnStepSFX?.Invoke();

        }
    }
}

