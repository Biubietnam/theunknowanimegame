using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FF4 RID: 4084
	public static class RogueTournModuleInfoReflection
	{
		// Token: 0x1700333B RID: 13115
		// (get) Token: 0x0600B5C4 RID: 46532 RVA: 0x001E7FAA File Offset: 0x001E61AA
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournModuleInfoReflection.descriptor;
			}
		}

		// Token: 0x040049BD RID: 18877
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpSb2d1ZVRvdXJuTW9kdWxlSW5mby5wcm90byIqChRSb2d1ZVRvdXJuTW9k" + "dWxlSW5mbxISCgphbGxvd19mb29kGAwgASgIQh6qAhtFZ2dMaW5rLkRhbmhl" + "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournModuleInfo), RogueTournModuleInfo.Parser, new string[]
			{
				"AllowFood"
			}, null, null, null, null)
		}));
	}
}
