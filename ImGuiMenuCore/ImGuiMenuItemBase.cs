﻿using UnityEngine;


namespace ImGuiManager.Core
{
	public abstract class ImGuiMenuItemBase<TContext> : ScriptableObject
	{
		protected TContext Context;

		public void Initialize(TContext context)
		{
			Context = context;
		}

		public abstract bool IsWindow();

		public abstract void OnLayoutMenu();

		public abstract void OnLayout(UImGui.UImGui uImGui);

		public abstract void RegisterWindow();

		public abstract void UnregisterWindow();
	}
}
