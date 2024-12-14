using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D7E RID: 3454
	public static class RebattleByClientCsNotifyReflection
	{
		// Token: 0x17002B8A RID: 11146
		// (get) Token: 0x06009A55 RID: 39509 RVA: 0x0019ABDA File Offset: 0x00198DDA
		public static FileDescriptor Descriptor
		{
			get
			{
				return RebattleByClientCsNotifyReflection.descriptor;
			}
		}

		// Token: 0x04003BE7 RID: 15335
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5SZWJhdHRsZUJ5Q2xpZW50Q3NOb3RpZnkucHJvdG8aFkJhdHRsZVN0YXRp",
			"c3RpY3MucHJvdG8aElJlYmF0dGxlVHlwZS5wcm90byJgChhSZWJhdHRsZUJ5",
			"Q2xpZW50Q3NOb3RpZnkSJAoNcmViYXR0bGVfdHlwZRgFIAEoDjINLlJlYmF0",
			"dGxlVHlwZRIeCgNzdHQYByABKAsyES5CYXR0bGVTdGF0aXN0aWNzQh6qAhtF",
			"Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			BattleStatisticsReflection.Descriptor,
			RebattleTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RebattleByClientCsNotify), RebattleByClientCsNotify.Parser, new string[]
			{
				"RebattleType",
				"Stt"
			}, null, null, null, null)
		}));
	}
}
