using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C34 RID: 3124
	public static class NpcMonsterRogueInfoReflection
	{
		// Token: 0x170026D9 RID: 9945
		// (get) Token: 0x06008A77 RID: 35447 RVA: 0x0016D909 File Offset: 0x0016BB09
		public static FileDescriptor Descriptor
		{
			get
			{
				return NpcMonsterRogueInfoReflection.descriptor;
			}
		}

		// Token: 0x04003514 RID: 13588
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlOcGNNb25zdGVyUm9ndWVJbmZvLnByb3RvIoIBChNOcGNNb25zdGVyUm9n",
			"dWVJbmZvEg0KBWxldmVsGAcgASgNEhgKEHJvZ3VlX21vbnN0ZXJfaWQYBCAB",
			"KA0SEwoLZWxpdGVfZ3JvdXAYCCABKA0SGAoQaGFyZF9sZXZlbF9ncm91cBgO",
			"IAEoDRITCgtJSUJFT0VOS05DThgCIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(NpcMonsterRogueInfo), NpcMonsterRogueInfo.Parser, new string[]
			{
				"Level",
				"RogueMonsterId",
				"EliteGroup",
				"HardLevelGroup",
				"IIBEOENKNCN"
			}, null, null, null, null)
		}));
	}
}
