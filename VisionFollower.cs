using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class SceneLoader : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (CheckIfButtonPressed(XRNode.RightHand, UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button.Trigger))
        {
            StartCoroutine(LoadNextScene());
        }
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(3f);

        Scene scene = SceneManager.GetActiveScene();
        int nextLevelIndex = scene.buildIndex + 1;

        SceneManager.LoadScene(nextLevelIndex);
    }

    bool CheckIfButtonPressed(XRNode node, UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button button)
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(node);
        bool isPressed = false;
        device.TryGetFeatureValue(CommonUsages.triggerButton, out isPressed);

        return isPressed;
    }
}
