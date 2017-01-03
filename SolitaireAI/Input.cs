﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using static PInvoke.User32;
namespace SolitaireAI {
	public static class Input {

		unsafe public static void SendKey(VK key) {
			//SetForegroundWindow(Form1.m_captureProcess.Process.MainWindowHandle);
			/*PostMessage(Form1.m_captureProcess.Process.MainWindowHandle, WindowMessage.WM_KEYDOWN, (void*)(ushort)key, null);
			PostMessage(Form1.m_captureProcess.Process.MainWindowHandle, WindowMessage.WM_KEYUP, (void*)(ushort)key, null);*/
			INPUT[] input = new INPUT[] {
				new INPUT() {
					type = InputType.INPUT_KEYBOARD,
					ki = new KEYBDINPUT {
						wVk = (VirtualKey)key,
						wScan = 0,
						dwFlags = 0,
						dwExtraInfo = null,
						time = 0
					}
				}
			};

			SendInput(1, input, Marshal.SizeOf(typeof(INPUT)));
		}

		unsafe public static void SendKeyDown(VK key) {
			PostMessage(Form1.m_captureProcess.Process.MainWindowHandle, WindowMessage.WM_KEYDOWN, (void*)(ushort)key, null);
		}
		
		unsafe public static void SendKeyUp(VK key) {
			PostMessage(Form1.m_captureProcess.Process.MainWindowHandle, WindowMessage.WM_KEYUP, (void*)(ushort)key, null);
		}


		unsafe public static void SendMouseLButtonDown(Point pos) {
			SetForegroundWindow(Form1.m_captureProcess.Process.MainWindowHandle);
			INPUT input = new INPUT();
			input.type = InputType.INPUT_MOUSE;
			input.mi.dx = 2222;
			input.mi.dy = 22;
			input.mi.dwFlags = (MOUSEEVENTF.MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF.MOUSEEVENTF_MOVE | MOUSEEVENTF.MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF.MOUSEEVENTF_RIGHTUP);
			input.mi.mouseData = 0;
			input.mi.dwExtraInfo = null;
			input.mi.time = 0;
			SendInput(1, &input, sizeof(INPUT));

			//PostMessage(Form1.m_captureProcess.Process.MainWindowHandle, WindowMessage.WM_SETFOCUS, GetForegroundWindow().ToPointer(), (void*)0);
			/*uint lparam = 0;
			lparam = 256 << 15;
			lparam |= 128;
			PostMessage(Form1.m_captureProcess.Process.MainWindowHandle, WindowMessage.WM_LBUTTONDOWN, (void*)0, (void*)lparam);
			PostMessage(Form1.m_captureProcess.Process.MainWindowHandle, WindowMessage.WM_LBUTTONUP, (void*)0, (void*)lparam);*/

		}

		unsafe public static void SendMousePos(Point pos) {

			//PostMessage(Form1.m_captureProcess.Process.MainWindowHandle, WindowMessage.WM_MOUSEMOVE, (void*)0, (void*)0);
		}
	}
	public enum VK : ushort {
		NO_KEY = 0,
		LBUTTON = 1,
		RBUTTON = 2,
		CANCEL = 3,
		MBUTTON = 4,
		XBUTTON1 = 5,
		XBUTTON2 = 6,
		BACK = 8,
		TAB = 9,
		CLEAR = 12,
		RETURN = 13,
		SHIFT = 16,
		CONTROL = 17,
		MENU = 18,
		PAUSE = 19,
		CAPITAL = 20,
		KANA = 21,
		HANGEUL = 21,
		HANGUL = 21,
		JUNJA = 23,
		FINAL = 24,
		HANJA = 25,
		KANJI = 25,
		ESCAPE = 27,
		CONVERT = 28,
		NONCONVERT = 29,
		ACCEPT = 30,
		MODECHANGE = 31,
		SPACE = 32,
		PRIOR = 33,
		NEXT = 34,
		END = 35,
		HOME = 36,
		LEFT = 37,
		UP = 38,
		RIGHT = 39,
		DOWN = 40,
		SELECT = 41,
		PRINT = 42,
		EXECUTE = 43,
		SNAPSHOT = 44,
		INSERT = 45,
		DELETE = 46,
		HELP = 47,
		KEY_0 = 48,
		KEY_1 = 49,
		KEY_2 = 50,
		KEY_3 = 51,
		KEY_4 = 52,
		KEY_5 = 53,
		KEY_6 = 54,
		KEY_7 = 55,
		KEY_8 = 56,
		KEY_9 = 57,
		A = 65,
		B = 66,
		C = 67,
		D = 68,
		E = 69,
		F = 70,
		G = 71,
		H = 72,
		I = 73,
		J = 74,
		K = 75,
		L = 76,
		M = 77,
		N = 78,
		O = 79,
		P = 80,
		Q = 81,
		R = 82,
		S = 83,
		T = 84,
		U = 85,
		V = 86,
		W = 87,
		X = 88,
		Y = 89,
		Z = 90,
		LWIN = 91,
		RWIN = 92,
		APPS = 93,
		SLEEP = 95,
		NUMPAD0 = 96,
		NUMPAD1 = 97,
		NUMPAD2 = 98,
		NUMPAD3 = 99,
		NUMPAD4 = 100,
		NUMPAD5 = 101,
		NUMPAD6 = 102,
		NUMPAD7 = 103,
		NUMPAD8 = 104,
		NUMPAD9 = 105,
		MULTIPLY = 106,
		ADD = 107,
		SEPARATOR = 108,
		SUBTRACT = 109,
		DECIMAL = 110,
		DIVIDE = 111,
		F1 = 112,
		F2 = 113,
		F3 = 114,
		F4 = 115,
		F5 = 116,
		F6 = 117,
		F7 = 118,
		F8 = 119,
		F9 = 120,
		F10 = 121,
		F11 = 122,
		F12 = 123,
		F13 = 124,
		F14 = 125,
		F15 = 126,
		F16 = 127,
		F17 = 128,
		F18 = 129,
		F19 = 130,
		F20 = 131,
		F21 = 132,
		F22 = 133,
		F23 = 134,
		F24 = 135,
		NUMLOCK = 144,
		SCROLL = 145,
		OEM_NEC_EQUAL = 146,
		OEM_FJ_JISHO = 146,
		OEM_FJ_MASSHOU = 147,
		OEM_FJ_TOUROKU = 148,
		OEM_FJ_LOYA = 149,
		OEM_FJ_ROYA = 150,
		LSHIFT = 160,
		RSHIFT = 161,
		LCONTROL = 162,
		RCONTROL = 163,
		LMENU = 164,
		RMENU = 165,
		BROWSER_BACK = 166,
		BROWSER_FORWARD = 167,
		BROWSER_REFRESH = 168,
		BROWSER_STOP = 169,
		BROWSER_SEARCH = 170,
		BROWSER_FAVORITES = 171,
		BROWSER_HOME = 172,
		VOLUME_MUTE = 173,
		VOLUME_DOWN = 174,
		VOLUME_UP = 175,
		MEDIA_NEXT_TRACK = 176,
		MEDIA_PREV_TRACK = 177,
		MEDIA_STOP = 178,
		MEDIA_PLAY_PAUSE = 179,
		LAUNCH_MAIL = 180,
		LAUNCH_MEDIA_SELECT = 181,
		LAUNCH_APP1 = 182,
		LAUNCH_APP2 = 183,
		OEM_1 = 186,
		OEM_PLUS = 187,
		OEM_COMMA = 188,
		OEM_MINUS = 189,
		OEM_PERIOD = 190,
		OEM_2 = 191,
		OEM_3 = 192,
		OEM_4 = 219,
		OEM_5 = 220,
		OEM_6 = 221,
		OEM_7 = 222,
		OEM_8 = 223,
		OEM_AX = 225,
		OEM_102 = 226,
		ICO_HELP = 227,
		ICO_00 = 228,
		PROCESSKEY = 229,
		ICO_CLEAR = 230,
		PACKET = 231,
		OEM_RESET = 233,
		OEM_JUMP = 234,
		OEM_PA1 = 235,
		OEM_PA2 = 236,
		OEM_PA3 = 237,
		OEM_WSCTRL = 238,
		OEM_CUSEL = 239,
		OEM_ATTN = 240,
		OEM_FINISH = 241,
		OEM_COPY = 242,
		OEM_AUTO = 243,
		OEM_ENLW = 244,
		OEM_BACKTAB = 245,
		ATTN = 246,
		CRSEL = 247,
		EXSEL = 248,
		EREOF = 249,
		PLAY = 250,
		ZOOM = 251,
		NONAME = 252,
		PA1 = 253,
		OEM_CLEAR = 254
	}
}