/*===============================================================================
Copyright (c) 2016 PTC Inc. All Rights Reserved.

Vuforia is a trademark of PTC Inc., registered in the United States and other 
countries.
===============================================================================*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SamplesMainMenu : MonoBehaviour
{

	#region PUBLIC_MEMBERS

    public enum MenuItem
    {
        HowTo = 0,
		Tentang = 1,
		Fort = 2,
		Parr = 3,
		Rumah = 4,
		Jamik = 5,
		first = 6,
		second = 7,
		third = 8,
		fourth = 9,
		Arsitektur=10,
		Bengkulu=11,
		shaw=12,
		foto=13

    }

    public Canvas AboutCanvas;
    public Text AboutTitle;
    public Text AboutDescription;

    public static bool isAboutScreenVisible = false;

    // initialize static enum with one of the items
	public static MenuItem menuItem = MenuItem.HowTo;

    public const string MenuScene = "Vuforia-1-Menu1";
    public const string LoadingScene = "Vuforia-2-Loading";

    SamplesAboutScreenInfo aboutScreenInfo;

	#endregion // PUBLIC_MEMBERS

    void Start()
    {
        // about screen is hidden when scene reloaded
        // set about screen state to false for nav handler
        isAboutScreenVisible = false;

        if (aboutScreenInfo == null)
        {
            // initialize if null
            aboutScreenInfo = new SamplesAboutScreenInfo();
        }
    }

	#region PUBLIC_METHODS

    public static string GetSceneToLoad()
    {
		return "Vuforia-3-ImageTargets";//+ SamplesMainMenu.menuItem.ToString();
    }

    public static void LoadScene(string scene)
    {
        #if (UNITY_5_2 || UNITY_5_1 || UNITY_5_0)
        Application.LoadLevel(scene);
        #else // UNITY_5_3 or above
		UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
        #endif
    }

	public void Web()
	{
		Application.OpenURL("https://besarpkmt.wixsite.com/pkm-t-besar-unib");
	}

	public void LoadDesc()
	{
		string name = Vuforia.DefaultTrackableEventHandler.desctitle;
		switch (name) {
		case("11"):
			LoadAboutScene ("Fort");
			break;
		case("12"):
			LoadAboutScene ("Parr");
			break;
		case("13"):
			LoadAboutScene ("Rumah");
			break;
		case("14"):
			LoadAboutScene ("Jamik");
			break;
		case("fort"):
			LoadAboutScene ("Fort");
			break;
		case("besar-fort"):
			LoadAboutScene ("Tentang");
			break;
		case("karno"):
			LoadAboutScene ("Rumah");
			break;
		case("besar-karno"):
			LoadAboutScene ("Tentang");
			break;
		case("brosur2"):
			LoadAboutScene ("Bengkulu");
			break;
		case("shaw"):
			LoadAboutScene ("shaw");
			break;
		case("foto"):
			LoadAboutScene ("foto");
			break;
		default:
			LoadAboutScene ("Tentang");
			break;
		}

	}

    public void LoadAboutScene(string itemSelected)
    {
        // This method called from list of Sample App menu buttons
        switch (itemSelected)
        {

        case("Fort"):
			SamplesMainMenu.menuItem = SamplesMainMenu.MenuItem.Fort;
            break;
		case("Arsitektur"):
			SamplesMainMenu.menuItem = SamplesMainMenu.MenuItem.Arsitektur;
			break;
		case("Bengkulu"):
			SamplesMainMenu.menuItem = SamplesMainMenu.MenuItem.Bengkulu;
			break;
		case("HowTo"):
			SamplesMainMenu.menuItem = SamplesMainMenu.MenuItem.HowTo;
            break;
		case("Parr"):
			SamplesMainMenu.menuItem = SamplesMainMenu.MenuItem.Parr;
			break;
        case("Tentang"):
			SamplesMainMenu.menuItem = SamplesMainMenu.MenuItem.Tentang;
            break;
		case("Rumah"):
			SamplesMainMenu.menuItem = SamplesMainMenu.MenuItem.Rumah;
			break;
		case("Jamik"):
			SamplesMainMenu.menuItem = SamplesMainMenu.MenuItem.Jamik;
			break;
		case("first"):
			SamplesMainMenu.menuItem = SamplesMainMenu.MenuItem.first;
			break;
		case("second"):
			SamplesMainMenu.menuItem = SamplesMainMenu.MenuItem.second;
			break;
		case("third"):
			SamplesMainMenu.menuItem = SamplesMainMenu.MenuItem.third;
			break;
		case("fourth"):
			SamplesMainMenu.menuItem = SamplesMainMenu.MenuItem.fourth;
			break;
		case("shaw"):
			SamplesMainMenu.menuItem = SamplesMainMenu.MenuItem.shaw;
			break;
		case("foto"):
			SamplesMainMenu.menuItem = SamplesMainMenu.MenuItem.foto;
			break;
        }

        AboutTitle.text = aboutScreenInfo.GetTitle(SamplesMainMenu.menuItem.ToString());
        AboutDescription.text = aboutScreenInfo.GetDescription(SamplesMainMenu.menuItem.ToString());

        AboutCanvas.transform.parent.transform.position = Vector3.zero; // move canvas into position
        AboutCanvas.sortingOrder = 1; // bring canvas in front of main menu
        isAboutScreenVisible = true;

    }

	public void CloseAboutScreen()
	{
		AboutCanvas.transform.parent.transform.position = -Vector3.right * (2 * Screen.width); // move canvas into position
		AboutCanvas.sortingOrder = 2; // bring canvas in front of main menu
		isAboutScreenVisible = false;
	}

	#endregion // PUBLIC_METHODS

}
