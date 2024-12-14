using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005C4 RID: 1476
	public static class FriendHistoryInfoReflection
	{
		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x060041ED RID: 16877 RVA: 0x000B36E3 File Offset: 0x000B18E3
		public static FileDescriptor Descriptor
		{
			get
			{
				return FriendHistoryInfoReflection.descriptor;
			}
		}

		// Token: 0x04001A2A RID: 6698
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdGcmllbmRIaXN0b3J5SW5mby5wcm90byI/ChFGcmllbmRIaXN0b3J5SW5m" + "bxIWCg5sYXN0X3NlbmRfdGltZRgDIAEoAxISCgpjb250YWN0X2lkGA0gASgN" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FriendHistoryInfo), FriendHistoryInfo.Parser, new string[]
			{
				"LastSendTime",
				"ContactId"
			}, null, null, null, null)
		}));
	}
}
