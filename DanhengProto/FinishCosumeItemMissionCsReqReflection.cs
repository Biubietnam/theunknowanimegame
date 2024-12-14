using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200056C RID: 1388
	public static class FinishCosumeItemMissionCsReqReflection
	{
		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x06003DF3 RID: 15859 RVA: 0x000A9883 File Offset: 0x000A7A83
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishCosumeItemMissionCsReqReflection.descriptor;
			}
		}

		// Token: 0x040018C3 RID: 6339
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJGaW5pc2hDb3N1bWVJdGVtTWlzc2lvbkNzUmVxLnByb3RvGg5JdGVtTGlz" + "dC5wcm90byJUChxGaW5pc2hDb3N1bWVJdGVtTWlzc2lvbkNzUmVxEhwKCWl0" + "ZW1fbGlzdBgCIAEoCzIJLkl0ZW1MaXN0EhYKDnN1Yl9taXNzaW9uX2lkGAkg" + "ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishCosumeItemMissionCsReq), FinishCosumeItemMissionCsReq.Parser, new string[]
			{
				"ItemList",
				"SubMissionId"
			}, null, null, null, null)
		}));
	}
}
