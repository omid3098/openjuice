using UnityEngine;
namespace OD.OpenJuice.Samples
{
    public class LoadSceneButton : BaseButton
    {
        [SerializeField] string sceneName;
        protected override void OnPressed()
        {
            Juicer.Instance.LoadScene(sceneName);
        }
    }
}
