using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001BC RID: 444
	public static class ChallengeStoryBuffInfoReflection
	{
		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x00039909 File Offset: 0x00037B09
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeStoryBuffInfoReflection.descriptor;
			}
		}

		// Token: 0x0400086A RID: 2154
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDaGFsbGVuZ2VTdG9yeUJ1ZmZJbmZvLnByb3RvIjwKFkNoYWxsZW5nZVN0" + "b3J5QnVmZkluZm8SEAoIYnVmZl9vbmUYBCABKA0SEAoIYnVmZl90d28YCCAB" + "KA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeStoryBuffInfo), ChallengeStoryBuffInfo.Parser, new string[]
			{
				"BuffOne",
				"BuffTwo"
			}, null, null, null, null)
		}));
	}
}
