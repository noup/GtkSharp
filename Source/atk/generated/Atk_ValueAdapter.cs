// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ValueAdapter : GLib.GInterfaceAdapter, Atk.IValue {

		[StructLayout (LayoutKind.Sequential)]
		struct AtkValueIface {
			public GetCurrentValueNativeDelegate GetCurrentValue;
			public GetMaximumValueNativeDelegate GetMaximumValue;
			public GetMinimumValueNativeDelegate GetMinimumValue;
			public SetCurrentValueNativeDelegate SetCurrentValue;
			public GetMinimumIncrementNativeDelegate GetMinimumIncrement;
			public GetValueAndTextNativeDelegate GetValueAndText;
			public GetRangeNativeDelegate GetRange;
			public GetIncrementNativeDelegate GetIncrement;
			public GetSubRangesNativeDelegate GetSubRanges;
			public SetValueNativeDelegate SetValue;
		}

		static AtkValueIface iface;

		static ValueAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (ValueAdapter));
			iface.GetCurrentValue = new GetCurrentValueNativeDelegate (GetCurrentValue_cb);
			iface.GetMaximumValue = new GetMaximumValueNativeDelegate (GetMaximumValue_cb);
			iface.GetMinimumValue = new GetMinimumValueNativeDelegate (GetMinimumValue_cb);
			iface.SetCurrentValue = new SetCurrentValueNativeDelegate (SetCurrentValue_cb);
			iface.GetMinimumIncrement = new GetMinimumIncrementNativeDelegate (GetMinimumIncrement_cb);
			iface.GetValueAndText = new GetValueAndTextNativeDelegate (GetValueAndText_cb);
			iface.GetRange = new GetRangeNativeDelegate (GetRange_cb);
			iface.GetIncrement = new GetIncrementNativeDelegate (GetIncrement_cb);
			iface.GetSubRanges = new GetSubRangesNativeDelegate (GetSubRanges_cb);
			iface.SetValue = new SetValueNativeDelegate (SetValue_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GetCurrentValueNativeDelegate (IntPtr inst, IntPtr value);

		static void GetCurrentValue_cb (IntPtr inst, IntPtr value)
		{
			try {
				IValueImplementor __obj = GLib.Object.GetObject (inst, false) as IValueImplementor;
				GLib.Value myvalue = (GLib.Value) Marshal.PtrToStructure (value, typeof (GLib.Value));
				__obj.GetCurrentValue (ref myvalue);
				if (value != IntPtr.Zero) System.Runtime.InteropServices.Marshal.StructureToPtr (myvalue, value, false);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GetMaximumValueNativeDelegate (IntPtr inst, IntPtr value);

		static void GetMaximumValue_cb (IntPtr inst, IntPtr value)
		{
			try {
				IValueImplementor __obj = GLib.Object.GetObject (inst, false) as IValueImplementor;
				GLib.Value myvalue = (GLib.Value) Marshal.PtrToStructure (value, typeof (GLib.Value));
				__obj.GetMaximumValue (ref myvalue);
				if (value != IntPtr.Zero) System.Runtime.InteropServices.Marshal.StructureToPtr (myvalue, value, false);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GetMinimumValueNativeDelegate (IntPtr inst, IntPtr value);

		static void GetMinimumValue_cb (IntPtr inst, IntPtr value)
		{
			try {
				IValueImplementor __obj = GLib.Object.GetObject (inst, false) as IValueImplementor;
				GLib.Value myvalue = (GLib.Value) Marshal.PtrToStructure (value, typeof (GLib.Value));
				__obj.GetMinimumValue (ref myvalue);
				if (value != IntPtr.Zero) System.Runtime.InteropServices.Marshal.StructureToPtr (myvalue, value, false);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SetCurrentValueNativeDelegate (IntPtr inst, IntPtr value);

		static bool SetCurrentValue_cb (IntPtr inst, IntPtr value)
		{
			try {
				IValueImplementor __obj = GLib.Object.GetObject (inst, false) as IValueImplementor;
				bool __result;
				__result = __obj.SetCurrentValue ((GLib.Value) Marshal.PtrToStructure (value, typeof (GLib.Value)));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GetMinimumIncrementNativeDelegate (IntPtr inst, IntPtr value);

		static void GetMinimumIncrement_cb (IntPtr inst, IntPtr value)
		{
			try {
				IValueImplementor __obj = GLib.Object.GetObject (inst, false) as IValueImplementor;
				GLib.Value myvalue = (GLib.Value) Marshal.PtrToStructure (value, typeof (GLib.Value));
				__obj.GetMinimumIncrement (ref myvalue);
				if (value != IntPtr.Zero) System.Runtime.InteropServices.Marshal.StructureToPtr (myvalue, value, false);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GetValueAndTextNativeDelegate (IntPtr inst, out double value, IntPtr text);

		static void GetValueAndText_cb (IntPtr inst, out double value, IntPtr text)
		{
			try {
				IValueImplementor __obj = GLib.Object.GetObject (inst, false) as IValueImplementor;
				__obj.GetValueAndText (out value, GLib.Marshaller.PtrToStringGFree(text));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetRangeNativeDelegate (IntPtr inst);

		static IntPtr GetRange_cb (IntPtr inst)
		{
			try {
				IValueImplementor __obj = GLib.Object.GetObject (inst, false) as IValueImplementor;
				Atk.Range __result;
				__result = __obj.Range;
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate double GetIncrementNativeDelegate (IntPtr inst);

		static double GetIncrement_cb (IntPtr inst)
		{
			try {
				IValueImplementor __obj = GLib.Object.GetObject (inst, false) as IValueImplementor;
				double __result;
				__result = __obj.Increment;
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetSubRangesNativeDelegate (IntPtr inst);

		static IntPtr GetSubRanges_cb (IntPtr inst)
		{
			try {
				IValueImplementor __obj = GLib.Object.GetObject (inst, false) as IValueImplementor;
				GLib.SList __result;
				__result = __obj.SubRanges;
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SetValueNativeDelegate (IntPtr inst, double new_value);

		static void SetValue_cb (IntPtr inst, double new_value)
		{
			try {
				IValueImplementor __obj = GLib.Object.GetObject (inst, false) as IValueImplementor;
				__obj.Value = new_value;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			AtkValueIface native_iface = (AtkValueIface) Marshal.PtrToStructure (ifaceptr, typeof (AtkValueIface));
			native_iface.GetCurrentValue = iface.GetCurrentValue;
			native_iface.GetMaximumValue = iface.GetMaximumValue;
			native_iface.GetMinimumValue = iface.GetMinimumValue;
			native_iface.SetCurrentValue = iface.SetCurrentValue;
			native_iface.GetMinimumIncrement = iface.GetMinimumIncrement;
			native_iface.GetValueAndText = iface.GetValueAndText;
			native_iface.GetRange = iface.GetRange;
			native_iface.GetIncrement = iface.GetIncrement;
			native_iface.GetSubRanges = iface.GetSubRanges;
			native_iface.SetValue = iface.SetValue;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public ValueAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public ValueAdapter (IValueImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public ValueAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_value_get_type();

		private static GLib.GType _gtype = new GLib.GType (atk_value_get_type ());

		public static GLib.GType GType {
			get {
				return _gtype;
			}
		}

		public override GLib.GType GInterfaceGType {
			get {
				return _gtype;
			}
		}

		public override IntPtr Handle {
			get {
				return implementor.Handle;
			}
		}

		public IntPtr OwnedHandle {
			get {
				return implementor.OwnedHandle;
			}
		}

		public static IValue GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IValue GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IValueImplementor)
				return new ValueAdapter (obj as IValueImplementor);
			else if (obj as IValue == null)
				return new ValueAdapter (obj.Handle);
			else
				return obj as IValue;
		}

		public IValueImplementor Implementor {
			get {
				return implementor as IValueImplementor;
			}
		}

		[GLib.Signal("value_changed")]
		public event Atk.ValueChangedHandler ValueChanged {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("value_changed", value, typeof (Atk.ValueChangedArgs));
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("value_changed", value);
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void atk_value_get_current_value(IntPtr raw, IntPtr value);

		[Obsolete]
		public void GetCurrentValue(ref GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			atk_value_get_current_value(Handle, native_value);
			value = (GLib.Value) Marshal.PtrToStructure (native_value, typeof (GLib.Value));
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double atk_value_get_increment(IntPtr raw);

		public double Increment { 
			get {
				double raw_ret = atk_value_get_increment(Handle);
				double ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void atk_value_get_maximum_value(IntPtr raw, IntPtr value);

		[Obsolete]
		public void GetMaximumValue(ref GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			atk_value_get_maximum_value(Handle, native_value);
			value = (GLib.Value) Marshal.PtrToStructure (native_value, typeof (GLib.Value));
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void atk_value_get_minimum_increment(IntPtr raw, IntPtr value);

		[Obsolete]
		public void GetMinimumIncrement(ref GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			atk_value_get_minimum_increment(Handle, native_value);
			value = (GLib.Value) Marshal.PtrToStructure (native_value, typeof (GLib.Value));
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void atk_value_get_minimum_value(IntPtr raw, IntPtr value);

		[Obsolete]
		public void GetMinimumValue(ref GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			atk_value_get_minimum_value(Handle, native_value);
			value = (GLib.Value) Marshal.PtrToStructure (native_value, typeof (GLib.Value));
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_value_get_range(IntPtr raw);

		public Atk.Range Range { 
			get {
				IntPtr raw_ret = atk_value_get_range(Handle);
				Atk.Range ret = raw_ret == IntPtr.Zero ? null : (Atk.Range) GLib.Opaque.GetOpaque (raw_ret, typeof (Atk.Range), false);
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_value_get_sub_ranges(IntPtr raw);

		public GLib.SList SubRanges { 
			get {
				IntPtr raw_ret = atk_value_get_sub_ranges(Handle);
				GLib.SList ret = new GLib.SList(raw_ret);
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void atk_value_get_value_and_text(IntPtr raw, out double value, IntPtr text);

		public double GetValueAndText(string text) {
			double value;
			atk_value_get_value_and_text(Handle, out value, GLib.Marshaller.StringToPtrGStrdup(text));
			return value;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool atk_value_set_current_value(IntPtr raw, IntPtr value);

		[Obsolete]
		public bool SetCurrentValue(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			bool raw_ret = atk_value_set_current_value(Handle, native_value);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void atk_value_set_value(IntPtr raw, double new_value);

		public double Value { 
			set {
				atk_value_set_value(Handle, value);
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_value_type_get_localized_name(int value_type);

		public static string TypeGetLocalizedName(Atk.ValueType value_type) {
			IntPtr raw_ret = atk_value_type_get_localized_name((int) value_type);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_value_type_get_name(int value_type);

		public static string TypeGetName(Atk.ValueType value_type) {
			IntPtr raw_ret = atk_value_type_get_name((int) value_type);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

#endregion
	}
}