using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200042E RID: 1070
	public static class EnterAdventureCsReqReflection
	{
		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06002F96 RID: 12182 RVA: 0x0008326E File Offset: 0x0008146E
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterAdventureCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001306 RID: 4870
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlFbnRlckFkdmVudHVyZUNzUmVxLnByb3RvIiUKE0VudGVyQWR2ZW50dXJl" + "Q3NSZXESDgoGbWFwX2lkGAwgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2" + "ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterAdventureCsReq), EnterAdventureCsReq.Parser, new string[]
			{
				"MapId"
			}, null, null, null, null)
		}));
	}
}
