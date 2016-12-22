﻿using Aurora.EffectsEngine;
using Aurora.Profiles.CSGO.GSI;
using Aurora.Profiles.CSGO.GSI.Nodes;
using Aurora.Settings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora.Profiles.CSGO
{
    public class GameEvent_CSGO : LightEvent
    {
        public GameEvent_CSGO()
        {
            _game_state = new GameState_CSGO();
        }

        public override void UpdateLights(EffectFrame frame)
        {
            Queue<EffectLayer> layers = new Queue<EffectLayer>();

            CSGOSettings settings = (CSGOSettings)this.Profile.Settings;

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
            if (new_game_state is GameState_CSGO)
            {
                _game_state = new_game_state;

                GameState_CSGO gs = (new_game_state as GameState_CSGO);

                try
                {
                    UpdateLights(frame);
                }
                catch (Exception e)
                {
                    Global.logger.LogLine("Exception during OnNewGameState. Error: " + e, Logging_Level.Error);
                    Global.logger.LogLine(gs.ToString(), Logging_Level.None);
                }
            }
        }

        public override bool IsEnabled()
        {
            return this.Profile.Settings.isEnabled;
        }
    }
}
