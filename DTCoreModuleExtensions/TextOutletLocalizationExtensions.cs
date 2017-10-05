#if DT_CORE_MODULE
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

using DTLocalization;

namespace DT {
	public static class TextOutletLocalizationExtensions {
		public static void SetLocalizedKey(this TextOutlet textOutlet, string key) {
			if (textOutlet.GameObject == null) {
				Debug.LogWarning("SetLocalizedKey on invalid text outlet with no GameObject!");
				return;
			}

			var runtimeLocalizedText = textOutlet.GameObject.GetOrAddComponent<RuntimeLocalizedText>();
			runtimeLocalizedText.Init(key, textOutlet.SetText);
		}
	}
}
#endif