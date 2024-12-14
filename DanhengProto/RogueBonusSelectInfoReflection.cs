using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E10 RID: 3600
	public static class RogueBonusSelectInfoReflection
	{
		// Token: 0x17002D6D RID: 11629
		// (get) Token: 0x0600A0EB RID: 41195 RVA: 0x001AF9EA File Offset: 0x001ADBEA
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueBonusSelectInfoReflection.descriptor;
			}
		}

		// Token: 0x040041E5 RID: 16869
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpSb2d1ZUJvbnVzU2VsZWN0SW5mby5wcm90byItChRSb2d1ZUJvbnVzU2Vs" + "ZWN0SW5mbxIVCg1ib251c19pZF9saXN0GA0gAygNQh6qAhtFZ2dMaW5rLkRh" + "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueBonusSelectInfo), RogueBonusSelectInfo.Parser, new string[]
			{
				"BonusIdList"
			}, null, null, null, null)
		}));
	}
}
