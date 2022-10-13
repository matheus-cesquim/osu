// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Localisation;
using osu.Game.Overlays.OSD;

namespace osu.Game.Graphics.UserInterface
{
    public class CopyUrlToast : Toast
    {
        public CopyUrlToast()
            : base(UserInterfaceStrings.GeneralHeader, ToastStrings.UrlCopied, "")
        {
        }
    }
}
