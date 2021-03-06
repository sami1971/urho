// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// Pass.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho
{
	/// <summary>
	/// %Material rendering pass, which defines shaders and render state.
	/// </summary>
	public unsafe partial class Pass : RefCounted
	{
		public Pass (IntPtr handle) : base (handle)
		{
		}

		protected Pass (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Pass_Pass (string passName);

		public Pass (string passName) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(Pass));
			handle = Pass_Pass (passName);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Pass_SetBlendMode (IntPtr handle, BlendMode mode);

		/// <summary>
		/// Set blend mode.
		/// </summary>
		private void SetBlendMode (BlendMode mode)
		{
			Runtime.ValidateRefCounted (this);
			Pass_SetBlendMode (handle, mode);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Pass_SetCullMode (IntPtr handle, CullMode mode);

		/// <summary>
		/// Set culling mode override. By default culling mode is read from the material instead. Set the illegal culling mode MAX_CULLMODES to disable override again.
		/// </summary>
		private void SetCullMode (CullMode mode)
		{
			Runtime.ValidateRefCounted (this);
			Pass_SetCullMode (handle, mode);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Pass_SetDepthTestMode (IntPtr handle, CompareMode mode);

		/// <summary>
		/// Set depth compare mode.
		/// </summary>
		private void SetDepthTestMode (CompareMode mode)
		{
			Runtime.ValidateRefCounted (this);
			Pass_SetDepthTestMode (handle, mode);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Pass_SetLightingMode (IntPtr handle, PassLightingMode mode);

		/// <summary>
		/// Set pass lighting mode, affects what shader variations will be attempted to be loaded.
		/// </summary>
		private void SetLightingMode (PassLightingMode mode)
		{
			Runtime.ValidateRefCounted (this);
			Pass_SetLightingMode (handle, mode);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Pass_SetDepthWrite (IntPtr handle, bool enable);

		/// <summary>
		/// Set depth write on/off.
		/// </summary>
		private void SetDepthWrite (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Pass_SetDepthWrite (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Pass_SetAlphaMask (IntPtr handle, bool enable);

		/// <summary>
		/// Set alpha masking hint. Completely opaque draw calls will be performed before alpha masked.
		/// </summary>
		private void SetAlphaMask (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Pass_SetAlphaMask (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Pass_SetIsDesktop (IntPtr handle, bool enable);

		/// <summary>
		/// Set whether requires desktop level hardware.
		/// </summary>
		public void SetIsDesktop (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Pass_SetIsDesktop (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Pass_SetVertexShader (IntPtr handle, string name);

		/// <summary>
		/// Set vertex shader name.
		/// </summary>
		private void SetVertexShader (string name)
		{
			Runtime.ValidateRefCounted (this);
			Pass_SetVertexShader (handle, name);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Pass_SetPixelShader (IntPtr handle, string name);

		/// <summary>
		/// Set pixel shader name.
		/// </summary>
		private void SetPixelShader (string name)
		{
			Runtime.ValidateRefCounted (this);
			Pass_SetPixelShader (handle, name);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Pass_SetVertexShaderDefines (IntPtr handle, string defines);

		/// <summary>
		/// Set vertex shader defines.
		/// </summary>
		private void SetVertexShaderDefines (string defines)
		{
			Runtime.ValidateRefCounted (this);
			Pass_SetVertexShaderDefines (handle, defines);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Pass_SetPixelShaderDefines (IntPtr handle, string defines);

		/// <summary>
		/// Set pixel shader defines.
		/// </summary>
		private void SetPixelShaderDefines (string defines)
		{
			Runtime.ValidateRefCounted (this);
			Pass_SetPixelShaderDefines (handle, defines);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Pass_ReleaseShaders (IntPtr handle);

		/// <summary>
		/// Reset shader pointers.
		/// </summary>
		public void ReleaseShaders ()
		{
			Runtime.ValidateRefCounted (this);
			Pass_ReleaseShaders (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Pass_MarkShadersLoaded (IntPtr handle, uint frameNumber);

		/// <summary>
		/// Mark shaders loaded this frame.
		/// </summary>
		public void MarkShadersLoaded (uint frameNumber)
		{
			Runtime.ValidateRefCounted (this);
			Pass_MarkShadersLoaded (handle, frameNumber);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Pass_GetName (IntPtr handle);

		/// <summary>
		/// Return pass name.
		/// </summary>
		private string GetName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Pass_GetName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Pass_GetIndex (IntPtr handle);

		/// <summary>
		/// Return pass index. This is used for optimal render-time pass queries that avoid map lookups.
		/// </summary>
		private uint GetIndex ()
		{
			Runtime.ValidateRefCounted (this);
			return Pass_GetIndex (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern BlendMode Pass_GetBlendMode (IntPtr handle);

		/// <summary>
		/// Return blend mode.
		/// </summary>
		private BlendMode GetBlendMode ()
		{
			Runtime.ValidateRefCounted (this);
			return Pass_GetBlendMode (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern CullMode Pass_GetCullMode (IntPtr handle);

		/// <summary>
		/// Return culling mode override. If pass is not overriding culling mode (default), the illegal mode MAX_CULLMODES is returned.
		/// </summary>
		private CullMode GetCullMode ()
		{
			Runtime.ValidateRefCounted (this);
			return Pass_GetCullMode (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern CompareMode Pass_GetDepthTestMode (IntPtr handle);

		/// <summary>
		/// Return depth compare mode.
		/// </summary>
		private CompareMode GetDepthTestMode ()
		{
			Runtime.ValidateRefCounted (this);
			return Pass_GetDepthTestMode (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern PassLightingMode Pass_GetLightingMode (IntPtr handle);

		/// <summary>
		/// Return pass lighting mode.
		/// </summary>
		private PassLightingMode GetLightingMode ()
		{
			Runtime.ValidateRefCounted (this);
			return Pass_GetLightingMode (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Pass_GetShadersLoadedFrameNumber (IntPtr handle);

		/// <summary>
		/// Return last shaders loaded frame number.
		/// </summary>
		private uint GetShadersLoadedFrameNumber ()
		{
			Runtime.ValidateRefCounted (this);
			return Pass_GetShadersLoadedFrameNumber (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Pass_GetDepthWrite (IntPtr handle);

		/// <summary>
		/// Return depth write mode.
		/// </summary>
		private bool GetDepthWrite ()
		{
			Runtime.ValidateRefCounted (this);
			return Pass_GetDepthWrite (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Pass_GetAlphaMask (IntPtr handle);

		/// <summary>
		/// Return alpha masking hint.
		/// </summary>
		private bool GetAlphaMask ()
		{
			Runtime.ValidateRefCounted (this);
			return Pass_GetAlphaMask (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Pass_IsDesktop (IntPtr handle);

		/// <summary>
		/// Return whether requires desktop level hardware.
		/// </summary>
		private bool IsDesktop ()
		{
			Runtime.ValidateRefCounted (this);
			return Pass_IsDesktop (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Pass_GetVertexShader (IntPtr handle);

		/// <summary>
		/// Return vertex shader name.
		/// </summary>
		private string GetVertexShader ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Pass_GetVertexShader (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Pass_GetPixelShader (IntPtr handle);

		/// <summary>
		/// Return pixel shader name.
		/// </summary>
		private string GetPixelShader ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Pass_GetPixelShader (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Pass_GetVertexShaderDefines (IntPtr handle);

		/// <summary>
		/// Return vertex shader defines.
		/// </summary>
		private string GetVertexShaderDefines ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Pass_GetVertexShaderDefines (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Pass_GetPixelShaderDefines (IntPtr handle);

		/// <summary>
		/// Return pixel shader defines.
		/// </summary>
		private string GetPixelShaderDefines ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Pass_GetPixelShaderDefines (handle));
		}

		/// <summary>
		/// Return blend mode.
		/// Or
		/// Set blend mode.
		/// </summary>
		public BlendMode BlendMode {
			get {
				return GetBlendMode ();
			}
			set {
				SetBlendMode (value);
			}
		}

		/// <summary>
		/// Return culling mode override. If pass is not overriding culling mode (default), the illegal mode MAX_CULLMODES is returned.
		/// Or
		/// Set culling mode override. By default culling mode is read from the material instead. Set the illegal culling mode MAX_CULLMODES to disable override again.
		/// </summary>
		public CullMode CullMode {
			get {
				return GetCullMode ();
			}
			set {
				SetCullMode (value);
			}
		}

		/// <summary>
		/// Return depth compare mode.
		/// Or
		/// Set depth compare mode.
		/// </summary>
		public CompareMode DepthTestMode {
			get {
				return GetDepthTestMode ();
			}
			set {
				SetDepthTestMode (value);
			}
		}

		/// <summary>
		/// Return pass lighting mode.
		/// Or
		/// Set pass lighting mode, affects what shader variations will be attempted to be loaded.
		/// </summary>
		public PassLightingMode LightingMode {
			get {
				return GetLightingMode ();
			}
			set {
				SetLightingMode (value);
			}
		}

		/// <summary>
		/// Return depth write mode.
		/// Or
		/// Set depth write on/off.
		/// </summary>
		public bool DepthWrite {
			get {
				return GetDepthWrite ();
			}
			set {
				SetDepthWrite (value);
			}
		}

		/// <summary>
		/// Return alpha masking hint.
		/// Or
		/// Set alpha masking hint. Completely opaque draw calls will be performed before alpha masked.
		/// </summary>
		public bool AlphaMask {
			get {
				return GetAlphaMask ();
			}
			set {
				SetAlphaMask (value);
			}
		}

		/// <summary>
		/// Return vertex shader name.
		/// Or
		/// Set vertex shader name.
		/// </summary>
		public string VertexShader {
			get {
				return GetVertexShader ();
			}
			set {
				SetVertexShader (value);
			}
		}

		/// <summary>
		/// Return pixel shader name.
		/// Or
		/// Set pixel shader name.
		/// </summary>
		public string PixelShader {
			get {
				return GetPixelShader ();
			}
			set {
				SetPixelShader (value);
			}
		}

		/// <summary>
		/// Return vertex shader defines.
		/// Or
		/// Set vertex shader defines.
		/// </summary>
		public string VertexShaderDefines {
			get {
				return GetVertexShaderDefines ();
			}
			set {
				SetVertexShaderDefines (value);
			}
		}

		/// <summary>
		/// Return pixel shader defines.
		/// Or
		/// Set pixel shader defines.
		/// </summary>
		public string PixelShaderDefines {
			get {
				return GetPixelShaderDefines ();
			}
			set {
				SetPixelShaderDefines (value);
			}
		}

		/// <summary>
		/// Return pass name.
		/// </summary>
		public string Name {
			get {
				return GetName ();
			}
		}

		/// <summary>
		/// Return pass index. This is used for optimal render-time pass queries that avoid map lookups.
		/// </summary>
		public uint Index {
			get {
				return GetIndex ();
			}
		}

		/// <summary>
		/// Return last shaders loaded frame number.
		/// </summary>
		public uint ShadersLoadedFrameNumber {
			get {
				return GetShadersLoadedFrameNumber ();
			}
		}

		/// <summary>
		/// Return whether requires desktop level hardware.
		/// </summary>
		public bool Desktop {
			get {
				return IsDesktop ();
			}
		}
	}
}
