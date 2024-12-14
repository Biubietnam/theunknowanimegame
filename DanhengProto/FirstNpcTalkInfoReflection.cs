using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005AA RID: 1450
	public static class FirstNpcTalkInfoReflection
	{
		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x060040C6 RID: 16582 RVA: 0x000B066C File Offset: 0x000AE86C
		public static FileDescriptor Descriptor
		{
			get
			{
				return FirstNpcTalkInfoReflection.descriptor;
			}
		}

		// Token: 0x040019B2 RID: 6578
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZGaXJzdE5wY1RhbGtJbmZvLnByb3RvIjMKEEZpcnN0TnBjVGFsa0luZm8S" + "DgoGbnBjX2lkGAcgASgNEg8KB2lzX21lZXQYBCABKAhCHqoCG0VnZ0xpbmsu" + "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FirstNpcTalkInfo), FirstNpcTalkInfo.Parser, new string[]
			{
				"NpcId",
				"IsMeet"
			}, null, null, null, null)
		}));
	}
}
