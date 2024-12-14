using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200047C RID: 1148
	public static class EnterTreasureDungeonScRspReflection
	{
		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x0600332C RID: 13100 RVA: 0x0008CBAA File Offset: 0x0008ADAA
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterTreasureDungeonScRspReflection.descriptor;
			}
		}

		// Token: 0x0400145D RID: 5213
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9FbnRlclRyZWFzdXJlRHVuZ2VvblNjUnNwLnByb3RvGhpUcmVhc3VyZUR1",
			"bmdlb25MZXZlbC5wcm90byJYChlFbnRlclRyZWFzdXJlRHVuZ2VvblNjUnNw",
			"Eg8KB3JldGNvZGUYAyABKA0SKgoLTEhJRUNLUEpORkQYDSABKAsyFS5UcmVh",
			"c3VyZUR1bmdlb25MZXZlbEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy",
			"b3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			TreasureDungeonLevelReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterTreasureDungeonScRsp), EnterTreasureDungeonScRsp.Parser, new string[]
			{
				"Retcode",
				"LHIECKPJNFD"
			}, null, null, null, null)
		}));
	}
}
