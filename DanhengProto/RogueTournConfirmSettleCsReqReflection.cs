using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F86 RID: 3974
	public static class RogueTournConfirmSettleCsReqReflection
	{
		// Token: 0x170031EB RID: 12779
		// (get) Token: 0x0600B0FD RID: 45309 RVA: 0x001DB5E2 File Offset: 0x001D97E2
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournConfirmSettleCsReqReflection.descriptor;
			}
		}

		// Token: 0x040047FF RID: 18431
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSb2d1ZVRvdXJuQ29uZmlybVNldHRsZUNzUmVxLnByb3RvIlAKHFJvZ3Vl" + "VG91cm5Db25maXJtU2V0dGxlQ3NSZXESEQoJbWF4X3RpbWVzGAYgASgNEgwK" + "BG5hbWUYByABKAkSDwoHYXJlYV9pZBgBIAEoDUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournConfirmSettleCsReq), RogueTournConfirmSettleCsReq.Parser, new string[]
			{
				"MaxTimes",
				"Name",
				"AreaId"
			}, null, null, null, null)
		}));
	}
}
