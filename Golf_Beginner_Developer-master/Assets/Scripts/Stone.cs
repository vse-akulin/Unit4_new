using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Golf
{
    public class Stone1 : MonoBehaviour
    {
        public bool isAffect = false;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.TryGetComponent(out Stone1 other))
            { 
                if (!other.isAffect) 
                {
                    GameEvents.CollisonStonesInvoke(collision);
                }
            }
        }
    }

}