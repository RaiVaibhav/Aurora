﻿using Aurora.EffectsEngine;
using Aurora.EffectsEngine.Animations;
using Aurora.Profiles.Dota_2.GSI;
using Aurora.Profiles.Dota_2.GSI.Nodes;
using Aurora.Settings;
using Aurora.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora.Profiles.Dota_2
{
    public class GameEvent_Dota2 : LightEvent
    {
        public GameEvent_Dota2()
        {
            _game_state = new GameState_Dota2();
        }

        public override void UpdateLights(EffectFrame frame)
        {
            Queue<EffectLayer> layers = new Queue<EffectLayer>();
            Dota2Settings settings = (Dota2Settings)this.Profile.Settings;

            //Scripts
            this.Profile.UpdateEffectScripts(layers, _game_state);

            foreach (var layer in settings.Layers.Reverse().ToArray())
            {
                if (layer.Enabled && layer.LogicPass)
                    layers.Enqueue(layer.Render(_game_state));
            }

            frame.AddLayers(layers.ToArray());
        }

        public override void UpdateLights(EffectFrame frame, IGameState new_game_state)
        {
            if (new_game_state is GameState_Dota2)
            {
                _game_state = new_game_state;

                UpdateLights(frame);
            }
        }

        public override bool IsEnabled()
        {
            return this.Profile.Settings.isEnabled;
        }
    }
}