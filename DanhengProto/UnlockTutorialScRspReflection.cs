using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013D2 RID: 5074
	public static class UnlockTutorialScRspReflection
	{
		// Token: 0x17003F86 RID: 16262
		// (get) Token: 0x0600E236 RID: 57910 RVA: 0x00259A8C File Offset: 0x00257C8C
		public static FileDescriptor Descriptor
		{
			get
			{
				return UnlockTutorialScRspReflection.descriptor;
			}
		}

		// Token: 0x040059F9 RID: 23033
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlVbmxvY2tUdXRvcmlhbFNjUnNwLnByb3RvGg5UdXRvcmlhbC5wcm90byJD" + "ChNVbmxvY2tUdXRvcmlhbFNjUnNwEhsKCFR1dG9yaWFsGAogASgLMgkuVHV0" + "b3JpYWwSDwoHcmV0Y29kZRgBIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy" + "dmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			TutorialReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UnlockTutorialScRsp), UnlockTutorialScRsp.Parser, new string[]
			{
				"Tutorial",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
