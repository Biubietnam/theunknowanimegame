using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011C0 RID: 4544
	public static class StartRaidCsReqReflection
	{
		// Token: 0x17003943 RID: 14659
		// (get) Token: 0x0600CB08 RID: 51976 RVA: 0x00220C5F File Offset: 0x0021EE5F
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartRaidCsReqReflection.descriptor;
			}
		}

		// Token: 0x040051E1 RID: 20961
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChRTdGFydFJhaWRDc1JlcS5wcm90byJ5Cg5TdGFydFJhaWRDc1JlcRIUCgxp",
			"c19zYXZlX2RhdGEYDyABKA0SFgoOcHJvcF9lbnRpdHlfaWQYCyABKA0SEwoL",
			"d29ybGRfbGV2ZWwYDiABKA0SDwoHcmFpZF9pZBgEIAEoDRITCgthdmF0YXJf",
			"bGlzdBgGIAMoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartRaidCsReq), StartRaidCsReq.Parser, new string[]
			{
				"IsSaveData",
				"PropEntityId",
				"WorldLevel",
				"RaidId",
				"AvatarList"
			}, null, null, null, null)
		}));
	}
}
