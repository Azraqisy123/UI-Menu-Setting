using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public void Play()
    {
        Debug.Log("Start !");
    }

    public void Option()
    {
        Debug.Log("Options !");
    }

   public void Quit()
   {
    Debug.Log("QUIT !");
    Application.Quit();
   }

   public void Back()
   {
    Debug.Log("Back !");
   }

   List<int> widths = new List<int>() {586, 960, 1280, 1920};
   List<int> heights = new List<int>() {320, 540, 800, 1080};

   public void SetScreenSize (int index)
   {
    bool fullscreen = Screen.fullScreen;
    int width = widths[index];
    int height = heights[index];
    Screen.SetResolution(width, height, fullscreen);
   }

   public void SetFullscreen (bool _fullscreen)
   {
    Screen.fullScreen = _fullscreen;  
   }
}
