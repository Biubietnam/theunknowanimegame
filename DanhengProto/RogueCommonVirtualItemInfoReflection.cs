using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E66 RID: 3686
	public static class RogueCommonVirtualItemInfoReflection
	{
		// Token: 0x17002E66 RID: 11878
		// (get) Token: 0x0600A46B RID: 42091 RVA: 0x001B9CDE File Offset: 0x001B7EDE
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueCommonVirtualItemInfoReflection.descriptor;
			}
		}

		// Token: 0x0400432E RID: 17198
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSb2d1ZUNvbW1vblZpcnR1YWxJdGVtSW5mby5wcm90byJPChpSb2d1ZUNv" + "bW1vblZpcnR1YWxJdGVtSW5mbxIYChB2aXJ0dWFsX2l0ZW1fbnVtGAUgASgN" + "EhcKD3ZpcnR1YWxfaXRlbV9pZBgJIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n" + "U2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueCommonVirtualItemInfo), RogueCommonVirtualItemInfo.Parser, new string[]
			{
				"VirtualItemNum",
				"VirtualItemId"
			}, null, null, null, null)
		}));
	}
}
