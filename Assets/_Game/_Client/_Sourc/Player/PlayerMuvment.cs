using UnityEngine;

namespace Game.Global
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMuvment : MonoBehaviour 
    {
        [SerializeField] private Vector3 _moveDer;
        private CharacterController _characterController;

        public void Awake() => _characterController = GetComponent<CharacterController>();

        private void FixedUpdate() => MoveDirectly();

        public void MoveDirectly() => _characterController.Move(_moveDer * Time.fixedDeltaTime);
    }
}

