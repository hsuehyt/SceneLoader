# Unity Scene Transition Project

This project demonstrates simple scene transitions in Unity using UI buttons. It includes two scenes, and users can switch from the first scene ("Scene1") to the second scene ("Scene2") by clicking a button.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

What things you need to install the software and how to install them:

- [Unity](https://unity.com/)
- [TextMesh Pro](https://docs.unity3d.com/Manual/com.unity.textmeshpro.html) (Optional, only if you are using TMP components)

### Installing

A step-by-step series of examples that tell you how to get a development environment running:

1. Clone the repository to your local machine or download the ZIP file and extract it.
2. Open Unity Hub and add the project by selecting the project folder.
3. Once the project is opened in Unity, go to `File > Build Settings` and make sure both scenes ("Scene1" and "Scene2") are added in the Scenes in Build.
4. Hit `Play` to start the scene in Unity Editor.

## Usage

### Set Up the Button Interaction

To set up the button for scene transitions, follow these steps:

1. Ensure you have a UI Canvas in "Scene1" with a Button named "Button".
2. Create a C# script named `SceneLoader.cs`.
3. Open `SceneLoader.cs` and write the following code to add an event listener to the button:

   ```csharp
   using UnityEngine;
   using UnityEngine.SceneManagement;
   using UnityEngine.UI;

   public class SceneLoader : MonoBehaviour
   {
       void Start()
       {
           Button btn = GameObject.Find("Canvas/Button").GetComponent<Button>();
           btn.onClick.AddListener(OnButtonClick);
       }

       void OnButtonClick()
       {
           SceneManager.LoadScene("Scene2");
       }
   }
   ```

### Attach the Script to an Object

1. In the Unity Editor, create an empty GameObject in "Scene1". Name it "Scene Manager".
2. Drag the `SceneLoader` script onto the "Scene Manager" GameObject in the inspector to attach it.

- Start the game either by playing the scene in Unity Editor or building the game.
- In "Scene1", press the button labeled "Button" to transition to "Scene2".

## Built With

* [Unity](https://unity.com/) - The game development platform used

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
