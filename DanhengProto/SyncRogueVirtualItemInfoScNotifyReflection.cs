using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012A0 RID: 4768
	public static class SyncRogueVirtualItemInfoScNotifyReflection
	{
		// Token: 0x17003BD9 RID: 15321
		// (get) Token: 0x0600D4C0 RID: 54464 RVA: 0x00238151 File Offset: 0x00236351
		public static FileDescriptor Descriptor
		{
			get
			{
				return SyncRogueVirtualItemInfoScNotifyReflection.descriptor;
			}
		}

		// Token: 0x0400551D RID: 21789
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiZTeW5jUm9ndWVWaXJ0dWFsSXRlbUluZm9TY05vdGlmeS5wcm90bxoaUm9n",
			"dWVWaXJ0dWFsSXRlbUluZm8ucHJvdG8iWgogU3luY1JvZ3VlVmlydHVhbEl0",
			"ZW1JbmZvU2NOb3RpZnkSNgoXcm9ndWVfdmlydHVhbF9pdGVtX2luZm8YDiAB",
			"KAsyFS5Sb2d1ZVZpcnR1YWxJdGVtSW5mb0IeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueVirtualItemInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SyncRogueVirtualItemInfoScNotify), SyncRogueVirtualItemInfoScNotify.Parser, new string[]
			{
				"RogueVirtualItemInfo"
			}, null, null, null, null)
		}));
	}
}
