using UnityEngine;

namespace NoCrashfish
{
    class Destructor : MonoBehaviour
    {
        public void Start()
        {
            Destroy(GetComponent<CrashHome>());
        }
    }
}
