using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Gaze : MonoBehaviour
{
    List<infobehavior> infos = new List<infobehavior>();

    void Start(){
        infos = FindObjectsOfType<infobehavior>().ToList();
    }

    void Update(){
        if (Physics.Raycast(transform.position,transform.forward, out RaycastHit hit)){
            GameObject go = hit.collider.gameObject;
            if (go.CompareTag("hasInfo")){
                OpenInfo(go.GetComponent<infobehavior>());
            }
        } else {
            CloseAll();
        }
    }
    void OpenInfo(infobehavior desiredInfo){
        foreach (infobehavior info in infos) {
            if (info == desiredInfo){
                info.OpenInfo();
            } else {
                info.CloseInfo();
            }
        }
    }

    void CloseAll() {
        foreach (infobehavior info in infos) {
            info.CloseInfo();
    }

}
}
