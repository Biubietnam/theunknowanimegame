using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D84 RID: 3460
	public static class RecallPetScRspReflection
	{
		// Token: 0x17002B96 RID: 11158
		// (get) Token: 0x06009A83 RID: 39555 RVA: 0x0019B28E File Offset: 0x0019948E
		public static FileDescriptor Descriptor
		{
			get
			{
				return RecallPetScRspReflection.descriptor;
			}
		}

		// Token: 0x04003BFC RID: 15356
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRSZWNhbGxQZXRTY1JzcC5wcm90byJJCg5SZWNhbGxQZXRTY1JzcBISCgpj" + "dXJfcGV0X2lkGAYgASgNEg8KB3JldGNvZGUYAiABKA0SEgoKbmV3X3BldF9p" + "ZBgIIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RecallPetScRsp), RecallPetScRsp.Parser, new string[]
			{
				"CurPetId",
				"Retcode",
				"NewPetId"
			}, null, null, null, null)
		}));
	}
}
