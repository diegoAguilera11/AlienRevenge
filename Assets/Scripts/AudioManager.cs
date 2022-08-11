using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource _shotSound;

    public AudioSource _shotSoundPlayerDamage;
    public AudioSource _levelOneTheme;
    public AudioSource _levelBoss;

    public AudioSource _gameOverSound;
    public AudioSource _winLevel;
    public AudioSource _winGame;

    public AudioSource _soundButton;



    #region CLASS_METHODS
    public void PlayLevelOnetheme()
    {
        _levelOneTheme.Play();
    }

    public void PauseLevelOnetheme()
    {
        _levelOneTheme.Pause();
    }

    public void StopLevelOneTheme()
    {
        _levelOneTheme.Stop();

    }

    public void playSoundButton()
    {
        _soundButton.Play();
    }



    public void PlayLevelBosstheme()
    {
        _levelBoss.Play();
    }
    public void PauseLevelBosstheme()
    {
        _levelBoss.Pause();
    }

    public void StopLevelBossTheme()
    {
        _levelBoss.Stop();

    }



    public void PlayWinGame()
    {
        _winGame.Play();
    }
    public void PlayWinLevel()
    {
        _winLevel.Play();
    }


    public void PlayShotSound()
    {
        _shotSound.Play();
    }
    public void StopShotSound()
    {
        _shotSound.Stop();
    }

    public void PlayShotPlayerDamage()
    {
        _shotSoundPlayerDamage.Play();
    }
    public void StopPlayShotPlayerDamage()
    {
        _shotSoundPlayerDamage.Stop();
    }

    public void PlayGameOverSound()
    {
        _gameOverSound.Play();
    }
    #endregion
}
