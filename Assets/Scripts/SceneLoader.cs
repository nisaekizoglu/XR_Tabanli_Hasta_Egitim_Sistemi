using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void OpenEducation()
    {
        SceneManager.LoadScene("EducationScene");
    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OpenMedication()
    {
        SceneManager.LoadScene("MedicationScene");
    }
    public void LoadXRScene()
    {
        SceneManager.LoadScene("ExerciseHubScene");
       
    }
    public void OpenArmExercise()
    {
        SceneManager.LoadScene("XRExerciseScene");
    }
    public void OpenNeckExercise()
    {
        SceneManager.LoadScene("NeckExerciseScene");
    }

    public void OpenShoulderExercise()
    {
        SceneManager.LoadScene("ShoulderExerciseScene");
    }

    public void OpenBreathExercise()
    {
        SceneManager.LoadScene("BreathExerciseScene");
    }
   
}