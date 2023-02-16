using UnityEngine;  

namespace Game.Global
{
    public class CameraFollower : MonoBehaviour
    {
        [SerializeField] private Transform _followerPosition;
        [SerializeField] private float _muvingSpeed;
        [SerializeField] private int _offsetFromFollower;

        private void Awake()
        {
            transform.position = new Vector3()
            {
                x = transform.position.x,
                y = transform.position.y,
                z = _followerPosition.position.z - _offsetFromFollower
            };
        }
       
        private void FixedUpdate()
        {
            if (_followerPosition)
            {
                Vector3 target = new Vector3()
                {
                    x = transform.position.x,
                    y = transform.position.y,
                    z = _followerPosition.position.z - _offsetFromFollower
            };

                Vector3 position = Vector3.Lerp(transform.position, target, _muvingSpeed * Time.deltaTime);

                transform.position = position; 

            }
        }

    }

}
