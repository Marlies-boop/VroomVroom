using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Samples.RebindUI;

public class RebindSaveLoad : MonoBehaviour
{
    public InputActionAsset actions;

    public void OnEnable()
    {
        LoadJson();
    }


    public void OnDisable()
    {
        SaveJson();
    }
    public void LoadJson()
    {
        var rebinds = PlayerPrefs.GetString("rebinds");
        if (!string.IsNullOrEmpty(rebinds))
        {
            print(rebinds);
            actions.LoadBindingOverridesFromJson(rebinds);
            //var temp = GetComponentsInChildren<RebindActionUI>();
            //foreach (RebindActionUI action in temp)
            //{
            //    action.UpdateBindingDisplay();
            //}
        }
    }
    public void SaveJson()
    {
        var rebinds = actions.SaveBindingOverridesAsJson();
        PlayerPrefs.SetString("rebinds", rebinds);
    }
}
