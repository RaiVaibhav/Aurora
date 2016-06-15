﻿using Aurora.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aurora.Utils
{
    public static class KeyUtils
    {
        public static DeviceKeys GetDeviceKey(Keys forms_key)
        {
            switch (forms_key)
            {
                case (Keys.Escape):
                    return DeviceKeys.ESC;
                case (Keys.Back):
                    return DeviceKeys.BACKSPACE;
                case (Keys.Tab):
                    return DeviceKeys.TAB;
                case (Keys.Enter):
                    return DeviceKeys.ENTER;
                case (Keys.LShiftKey):
                    return DeviceKeys.LEFT_SHIFT;
                case (Keys.LControlKey):
                    return DeviceKeys.LEFT_CONTROL;
                case (Keys.LMenu):
                    return DeviceKeys.LEFT_ALT;
                case (Keys.IMENonconvert):
                    return DeviceKeys.JPN_MUHENKAN;
                case (Keys.IMEConvert):
                    return DeviceKeys.JPN_HENKAN;
                case (Keys.IMEModeChange):
                    return DeviceKeys.JPN_HIRAGANA_KATAKANA;
                case (Keys.RShiftKey):
                    return DeviceKeys.RIGHT_SHIFT;
                case (Keys.RControlKey):
                    return DeviceKeys.RIGHT_CONTROL;
                case (Keys.RMenu):
                    return DeviceKeys.RIGHT_ALT;
                case (Keys.Pause):
                    return DeviceKeys.PAUSE_BREAK;
                case (Keys.CapsLock):
                    return DeviceKeys.CAPS_LOCK;
                case (Keys.Space):
                    return DeviceKeys.SPACE;
                case (Keys.PageUp):
                    return DeviceKeys.PAGE_UP;
                case (Keys.PageDown):
                    return DeviceKeys.PAGE_DOWN;
                case (Keys.End):
                    return DeviceKeys.END;
                case (Keys.Home):
                    return DeviceKeys.HOME;
                case (Keys.Left):
                    return DeviceKeys.ARROW_LEFT;
                case (Keys.Up):
                    return DeviceKeys.ARROW_UP;
                case (Keys.Right):
                    return DeviceKeys.ARROW_RIGHT;
                case (Keys.Down):
                    return DeviceKeys.ARROW_DOWN;
                case (Keys.PrintScreen):
                    return DeviceKeys.PRINT_SCREEN;
                case (Keys.Insert):
                    return DeviceKeys.INSERT;
                case (Keys.Delete):
                    return DeviceKeys.DELETE;
                case (Keys.D0):
                    return DeviceKeys.ZERO;
                case (Keys.D1):
                    return DeviceKeys.ONE;
                case (Keys.D2):
                    return DeviceKeys.TWO;
                case (Keys.D3):
                    return DeviceKeys.THREE;
                case (Keys.D4):
                    return DeviceKeys.FOUR;
                case (Keys.D5):
                    return DeviceKeys.FIVE;
                case (Keys.D6):
                    return DeviceKeys.SIX;
                case (Keys.D7):
                    return DeviceKeys.SEVEN;
                case (Keys.D8):
                    return DeviceKeys.EIGHT;
                case (Keys.D9):
                    return DeviceKeys.NINE;
                case (Keys.A):
                    return DeviceKeys.A;
                case (Keys.B):
                    return DeviceKeys.B;
                case (Keys.C):
                    return DeviceKeys.C;
                case (Keys.D):
                    return DeviceKeys.D;
                case (Keys.E):
                    return DeviceKeys.E;
                case (Keys.F):
                    return DeviceKeys.F;
                case (Keys.G):
                    return DeviceKeys.G;
                case (Keys.H):
                    return DeviceKeys.H;
                case (Keys.I):
                    return DeviceKeys.I;
                case (Keys.J):
                    return DeviceKeys.J;
                case (Keys.K):
                    return DeviceKeys.K;
                case (Keys.L):
                    return DeviceKeys.L;
                case (Keys.M):
                    return DeviceKeys.M;
                case (Keys.N):
                    return DeviceKeys.N;
                case (Keys.O):
                    return DeviceKeys.O;
                case (Keys.P):
                    return DeviceKeys.P;
                case (Keys.Q):
                    return DeviceKeys.Q;
                case (Keys.R):
                    return DeviceKeys.R;
                case (Keys.S):
                    return DeviceKeys.S;
                case (Keys.T):
                    return DeviceKeys.T;
                case (Keys.U):
                    return DeviceKeys.U;
                case (Keys.V):
                    return DeviceKeys.V;
                case (Keys.W):
                    return DeviceKeys.W;
                case (Keys.X):
                    return DeviceKeys.X;
                case (Keys.Y):
                    return DeviceKeys.Y;
                case (Keys.Z):
                    return DeviceKeys.Z;
                case (Keys.LWin):
                    return DeviceKeys.LEFT_WINDOWS;
                case (Keys.RWin):
                    return DeviceKeys.RIGHT_WINDOWS;
                case (Keys.Apps):
                    return DeviceKeys.APPLICATION_SELECT;
                case (Keys.NumPad0):
                    return DeviceKeys.NUM_ZERO;
                case (Keys.NumPad1):
                    return DeviceKeys.NUM_ONE;
                case (Keys.NumPad2):
                    return DeviceKeys.NUM_TWO;
                case (Keys.NumPad3):
                    return DeviceKeys.NUM_THREE;
                case (Keys.NumPad4):
                    return DeviceKeys.NUM_FOUR;
                case (Keys.NumPad5):
                    return DeviceKeys.NUM_FIVE;
                case (Keys.NumPad6):
                    return DeviceKeys.NUM_SIX;
                case (Keys.NumPad7):
                    return DeviceKeys.NUM_SEVEN;
                case (Keys.NumPad8):
                    return DeviceKeys.NUM_EIGHT;
                case (Keys.NumPad9):
                    return DeviceKeys.NUM_NINE;
                case (Keys.Multiply):
                    return DeviceKeys.NUM_ASTERISK;
                case (Keys.Add):
                    return DeviceKeys.NUM_PLUS;
                case (Keys.Subtract):
                    return DeviceKeys.NUM_MINUS;
                case (Keys.Decimal):
                    return DeviceKeys.NUM_PERIOD;
                case (Keys.Divide):
                    return DeviceKeys.NUM_SLASH;
                case (Keys.F1):
                    return DeviceKeys.F1;
                case (Keys.F2):
                    return DeviceKeys.F2;
                case (Keys.F3):
                    return DeviceKeys.F3;
                case (Keys.F4):
                    return DeviceKeys.F4;
                case (Keys.F5):
                    return DeviceKeys.F5;
                case (Keys.F6):
                    return DeviceKeys.F6;
                case (Keys.F7):
                    return DeviceKeys.F7;
                case (Keys.F8):
                    return DeviceKeys.F8;
                case (Keys.F9):
                    return DeviceKeys.F9;
                case (Keys.F10):
                    return DeviceKeys.F10;
                case (Keys.F11):
                    return DeviceKeys.F11;
                case (Keys.F12):
                    return DeviceKeys.F12;
                case (Keys.NumLock):
                    return DeviceKeys.NUM_LOCK;
                case (Keys.Scroll):
                    return DeviceKeys.SCROLL_LOCK;
                case (Keys.VolumeMute):
                    return DeviceKeys.VOLUME_MUTE;
                case (Keys.VolumeDown):
                    return DeviceKeys.VOLUME_DOWN;
                case (Keys.VolumeUp):
                    return DeviceKeys.VOLUME_UP;
                case (Keys.MediaNextTrack):
                    return DeviceKeys.MEDIA_NEXT;
                case (Keys.MediaPreviousTrack):
                    return DeviceKeys.MEDIA_PREVIOUS;
                case (Keys.MediaStop):
                    return DeviceKeys.MEDIA_STOP;
                case (Keys.MediaPlayPause):
                    return DeviceKeys.MEDIA_PLAY_PAUSE;
                case (Keys.OemSemicolon):
                    return DeviceKeys.SEMICOLON;
                case (Keys.Oemplus):
                    return DeviceKeys.EQUALS;
                case (Keys.Oemcomma):
                    return DeviceKeys.COMMA;
                case (Keys.OemMinus):
                    return DeviceKeys.MINUS;
                case (Keys.OemPeriod):
                    return DeviceKeys.PERIOD;
                case (Keys.OemQuestion):
                    return DeviceKeys.FORWARD_SLASH;
                case (Keys.ProcessKey):
                    return DeviceKeys.JPN_HALFFULLWIDTH;
                case (Keys.Oemtilde):
                    return DeviceKeys.TILDE;
                case (Keys.OemOpenBrackets):
                    return DeviceKeys.OPEN_BRACKET;
                case (Keys.OemPipe):
                    return DeviceKeys.BACKSLASH;
                case (Keys.OemCloseBrackets):
                    return DeviceKeys.CLOSE_BRACKET;
                case (Keys.OemQuotes):
                    return DeviceKeys.APOSTROPHE;
                case (Keys.OemBackslash):
                    return DeviceKeys.BACKSLASH_UK;
                case (Keys.Oem8):
                    return DeviceKeys.OEM8;
                case (Keys.Play):
                    return DeviceKeys.MEDIA_PLAY;
                default:
                    return DeviceKeys.NONE;
            }
        }
    }
}
