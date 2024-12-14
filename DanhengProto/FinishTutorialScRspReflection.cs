using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005A4 RID: 1444
	public static class FinishTutorialScRspReflection
	{
		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x0600407C RID: 16508 RVA: 0x000AF956 File Offset: 0x000ADB56
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishTutorialScRspReflection.descriptor;
			}
		}

		// Token: 0x04001996 RID: 6550
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlGaW5pc2hUdXRvcmlhbFNjUnNwLnByb3RvGg5UdXRvcmlhbC5wcm90byJD" + "ChNGaW5pc2hUdXRvcmlhbFNjUnNwEg8KB3JldGNvZGUYDiABKA0SGwoIVHV0" + "b3JpYWwYAyABKAsyCS5UdXRvcmlhbEIeqgIbRWdnTGluay5EYW5oZW5nU2Vy" + "dmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			TutorialReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishTutorialScRsp), FinishTutorialScRsp.Parser, new string[]
			{
				"Retcode",
				"Tutorial"
			}, null, null, null, null)
		}));
	}
}
