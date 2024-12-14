using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200083C RID: 2108
	public static class GetTutorialGuideScRspReflection
	{
		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x06005DCD RID: 24013 RVA: 0x000F896E File Offset: 0x000F6B6E
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetTutorialGuideScRspReflection.descriptor;
			}
		}

		// Token: 0x0400242B RID: 9259
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRUdXRvcmlhbEd1aWRlU2NSc3AucHJvdG8aE1R1dG9yaWFsR3VpZGUu" + "cHJvdG8iUwoVR2V0VHV0b3JpYWxHdWlkZVNjUnNwEg8KB3JldGNvZGUYASAB" + "KA0SKQoRVHV0b3JpYWxHdWlkZUxpc3QYAiADKAsyDi5UdXRvcmlhbEd1aWRl" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			TutorialGuideReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetTutorialGuideScRsp), GetTutorialGuideScRsp.Parser, new string[]
			{
				"Retcode",
				"TutorialGuideList"
			}, null, null, null, null)
		}));
	}
}
