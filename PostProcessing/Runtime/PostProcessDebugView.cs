using System;

namespace UnityEngine.Experimental.PostProcessing
{
    // TODO: Make a nice debug view with ALL TEH SHIT
    [Serializable]
    public sealed class PostProcessDebugView
    {
        public enum Monitor
        {
            Histogram,
            Waveform,
            Vectorscope
        }

        public bool display = false;
        public Monitor monitor = Monitor.Waveform;

        public void OnGUI(PostProcessRenderContext context)
        {
            if (!display || !SystemInfo.supportsComputeShaders || context == null)
                return;
        }
    }
}
