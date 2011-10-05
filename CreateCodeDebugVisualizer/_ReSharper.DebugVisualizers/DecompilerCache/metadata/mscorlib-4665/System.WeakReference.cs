// Type: System.WeakReference
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll

using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	[ComVisible(true)]
	[Serializable]
	public class WeakReference : ISerializable
	{
		public WeakReference(object target);

		[SecuritySafeCritical]
		public WeakReference(object target, bool trackResurrection);

		[SecuritySafeCritical]
		protected WeakReference(SerializationInfo info, StreamingContext context);

		public virtual bool IsAlive { [SecuritySafeCritical]
		get; }

		public virtual bool TrackResurrection { get; }

		public virtual object Target { [SecuritySafeCritical]
		get; [SecuritySafeCritical]
		set; }

		#region ISerializable Members

		[SecurityCritical]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context);

		#endregion

		[SecuritySafeCritical]
		~WeakReference();
	}
}
