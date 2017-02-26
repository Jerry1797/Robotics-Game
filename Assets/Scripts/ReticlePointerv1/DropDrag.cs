using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public interface DropDrag : IEventSystemHandler {
    void HandleGazeTriggerStart();
    void HandleGazeTriggerEnd();


}
