using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001182 RID: 4482
	public static class SpringRecoverSingleAvatarScRspReflection
	{
		// Token: 0x1700386D RID: 14445
		// (get) Token: 0x0600C80F RID: 51215 RVA: 0x00218CF2 File Offset: 0x00216EF2
		public static FileDescriptor Descriptor
		{
			get
			{
				return SpringRecoverSingleAvatarScRspReflection.descriptor;
			}
		}

		// Token: 0x040050C8 RID: 20680
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiRTcHJpbmdSZWNvdmVyU2luZ2xlQXZhdGFyU2NSc3AucHJvdG8aEEF2YXRh",
			"clR5cGUucHJvdG8iagoeU3ByaW5nUmVjb3ZlclNpbmdsZUF2YXRhclNjUnNw",
			"Eh8KCkF2YXRhclR5cGUYCiABKA4yCy5BdmF0YXJUeXBlEgoKAmlkGAcgASgN",
			"Eg8KB3JldGNvZGUYASABKA0SCgoCSHAYCSABKA1CHqoCG0VnZ0xpbmsuRGFu",
			"aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SpringRecoverSingleAvatarScRsp), SpringRecoverSingleAvatarScRsp.Parser, new string[]
			{
				"AvatarType",
				"Id",
				"Retcode",
				"Hp"
			}, null, null, null, null)
		}));
	}
}
