using System;
using Microsoft.VisualStudio.DebuggerVisualizers;
using Visualizer;
using Visualizer.Extensions;
using VisualizerUI;

[assembly: System.Diagnostics.DebuggerVisualizer(typeof(ObjectToCSharpCodeVisualizer), typeof(VisualizerObjectSource), Target = typeof(WeakReference), Description = "Create c# Code")]

namespace Visualizer
{
	public class ObjectToCSharpCodeVisualizer : DialogDebuggerVisualizer
	{
		protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
		{
			var obj = (WeakReference)objectProvider.GetObject();
			using (var window = new Window())
			{
				try
				{
					window.txtCode.Text = obj.Target.CreateCode();
				}
				catch (Exception ex)
				{
					window.txtCode.Text = ex.ToString();
				}
				windowService.ShowDialog(window);
			}
		}

		internal static void TestShowVisualizer(object objectToVisualize)
		{
			var visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(ObjectToCSharpCodeVisualizer));
			visualizerHost.ShowVisualizer();
		}
	}
}
