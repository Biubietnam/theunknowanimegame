using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200104A RID: 4170
	public static class SavePointsInfoNotifyReflection
	{
		// Token: 0x17003446 RID: 13382
		// (get) Token: 0x0600B989 RID: 47497 RVA: 0x001F2027 File Offset: 0x001F0227
		public static FileDescriptor Descriptor
		{
			get
			{
				return SavePointsInfoNotifyReflection.descriptor;
			}
		}

		// Token: 0x04004B21 RID: 19233
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTYXZlUG9pbnRzSW5mb05vdGlmeS5wcm90byI/ChRTYXZlUG9pbnRzSW5m" + "b05vdGlmeRISCgpWYWxpZFRpbWVzGAMgASgNEhMKC1JlZnJlc2hUaW1lGAog" + "ASgDQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SavePointsInfoNotify), SavePointsInfoNotify.Parser, new string[]
			{
				"ValidTimes",
				"RefreshTime"
			}, null, null, null, null)
		}));
	}
}
