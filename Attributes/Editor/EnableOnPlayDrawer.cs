﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace BowieCode {

	[CustomPropertyDrawer(typeof(EnableOnPlay))]
	public class EnableOnPlayDrawer : PropertyDrawer {

		public override void OnGUI (Rect position, SerializedProperty property, GUIContent label) {
			EditorGUI.BeginDisabledGroup( !Application.isPlaying );
			EditorGUI.PropertyField( position, property, true );
			EditorGUI.EndDisabledGroup();
		}
	}

}
