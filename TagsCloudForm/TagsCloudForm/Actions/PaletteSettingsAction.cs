﻿using TagsCloudForm.Common;
using TagsCloudForm.UiActions;

namespace TagsCloudForm.Actions
{
    public class PaletteSettingsAction : IUiAction
    {
        private readonly IPalette palette;

        public PaletteSettingsAction(IPalette palette)
        {
            this.palette = palette;
        }

        public string Category => "Настройки";
        public string Name => "Палитра...";
        public string Description => "Цвета для рисования фракталов";

        public void Perform()
        {
            SettingsForm.For(palette).ShowDialog();
        }
    }
}