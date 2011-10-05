// Type: Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer
// Assembly: Microsoft.VisualStudio.DebuggerVisualizers, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// Assembly location: d:\Program Files\Microsoft Visual Studio 10.0\Common7\IDE\ReferenceAssemblies\v2.0\Microsoft.VisualStudio.DebuggerVisualizers.dll

namespace Microsoft.VisualStudio.DebuggerVisualizers
{
	public abstract class DialogDebuggerVisualizer
	{
		protected internal abstract void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider);
	}
}
