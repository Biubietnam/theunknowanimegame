using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AC4 RID: 2756
	public static class MessageItemReflection
	{
		// Token: 0x1700224E RID: 8782
		// (get) Token: 0x06007A31 RID: 31281 RVA: 0x00143A6B File Offset: 0x00141C6B
		public static FileDescriptor Descriptor
		{
			get
			{
				return MessageItemReflection.descriptor;
			}
		}

		// Token: 0x04002EE5 RID: 12005
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNZXNzYWdlSXRlbS5wcm90byIvCgtNZXNzYWdlSXRlbRIPCgd0ZXh0X2lk" + "GAcgASgNEg8KB2l0ZW1faWQYBCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl" + "cnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MessageItem), MessageItem.Parser, new string[]
			{
				"TextId",
				"ItemId"
			}, null, null, null, null)
		}));
	}
}
