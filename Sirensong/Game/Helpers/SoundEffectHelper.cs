using System;
using FFXIVClientStructs.FFXIV.Client.Sound;
using FFXIVClientStructs.FFXIV.Client.UI;

namespace Sirensong.Game.Helpers
{
    /// <summary>
    ///     Helper methods for playing sound effects.
    /// </summary>
    public static class SoundEffectHelper
    {
        /// <summary>
        ///     Plays a sound effect.
        /// </summary>
        /// <param name="soundEffect">The sound effect to play.</param>
        [Obsolete("Use UIGlobals.PlaySoundEffect(effectId, outSoundDataPad, outSoundData, a4) instead")]
        public static unsafe void PlaySound(uint effectId, SoundData** outSoundDataPad = null, SoundData** outSoundData = null, byte a4 = 0) => UIGlobals.PlaySoundEffect(effectId, outSoundDataPad, outSoundData, a4);

        /// <summary>
        ///     Plays a chat sound effect.
        /// </summary>
        /// <param name="effectId">The sound effect to play.</param>
        [Obsolete("Use UIGlobals.PlaySoundEffect(effectId, outSoundDataPad, outSoundData, a4) instead")]
        public static void PlayChatSoundEffect(uint effectId) => UIGlobals.PlayChatSoundEffect(effectId);
    }
}