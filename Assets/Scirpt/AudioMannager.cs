using UnityEngine;

public class AudioMannager : MonoBehaviour
{
    [SerializeField] private AudioSource BackGroundAudio;
    [SerializeField] private AudioSource effectAudio;

    [SerializeField] private AudioClip BackGroundClip;
    [SerializeField] private AudioClip JumpClip;
    [SerializeField] private AudioClip CoinClip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayBackGroundMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayBackGroundMusic()
    {
        BackGroundAudio.clip = BackGroundClip;
        BackGroundAudio.Play();
    }
    public void PlayCoinSound()
    {
        effectAudio.PlayOneShot(CoinClip);
    }
    public void PlayJumpSound()
    {
        effectAudio.PlayOneShot(JumpClip);
    }
}
