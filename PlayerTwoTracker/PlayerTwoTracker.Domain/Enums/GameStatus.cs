
using System.ComponentModel.DataAnnotations;

namespace PlayerTwoTracker.Domain.Enums;

/// <summary>
/// Represents the status of a game in the PlayerTwoTracker application.
/// </summary>
public enum GameStatus
{
    /// <summary>
    /// Unknown status, used as a default value.
    /// </summary>
    None,
    /// <summary>
    /// The user wants to play the game but has not started yet.
    /// </summary>
    [Display(Name = "Want to Play")]
    WantToPlay,
    /// <summary>
    /// The user is currently playing the game.
    /// </summary>
    [Display(Name = "Playing")]
    Playing,
    /// <summary>
    /// The user has completed the game.
    /// </summary>
    [Display(Name = "Completed")]
    Completed,
    /// <summary>
    /// The user has played the game but did not complete it.
    /// </summary>
    [Display(Name = "Abandoned")]
    Abandoned
}
