﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Game.Rulesets.Edit;
using osu.Game.Rulesets.Osu.Objects;
using osu.Game.Rulesets.Osu.Objects.Drawables;

namespace osu.Game.Rulesets.Osu.Edit.Masks
{
    public class SliderCircleSelectionMask : SelectionMask
    {
        public SliderCircleSelectionMask(DrawableOsuHitObject hitObject, Slider slider, SliderPosition position)
            : base(hitObject)
        {
            InternalChild = new SliderCircleMask(slider, position);

            Select();
        }

        // Todo: This is temporary, since the slider circle masks don't do anything special yet. In the future they will handle input.
        public override bool HandlePositionalInput => false;
    }
}
