using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//作成者：桑原
//ボタン選択後に別のボタンを選択できないようにするためにこれを使う
public class NavigationEventsManager : MonoBehaviour
{
    [SerializeField] EventSystem eventSystem;

    private void Start()
    {
        ChangeNavigationEvent(true);
    }

    //別のボタンを選択できるようにするか
    public void ChangeNavigationEvent(bool active)
    {
        if(eventSystem!=null)
        {
            eventSystem.sendNavigationEvents=active;
        }
    }
}
