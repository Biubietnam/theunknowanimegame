using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000934 RID: 2356
	public static class InteractChargerScRspReflection
	{
		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x06006925 RID: 26917 RVA: 0x00118AF9 File Offset: 0x00116CF9
		public static FileDescriptor Descriptor
		{
			get
			{
				return InteractChargerScRspReflection.descriptor;
			}
		}

		// Token: 0x0400284E RID: 10318
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpJbnRlcmFjdENoYXJnZXJTY1JzcC5wcm90bxoRQ2hhcmdlckluZm8ucHJv",
			"dG8aF1JvdGF0ZXJFbmVyZ3lJbmZvLnByb3RvInQKFEludGVyYWN0Q2hhcmdl",
			"clNjUnNwEiIKDGNoYXJnZXJfaW5mbxgGIAEoCzIMLkNoYXJnZXJJbmZvEg8K",
			"B3JldGNvZGUYDCABKA0SJwoLZW5lcmd5X2luZm8YAyABKAsyEi5Sb3RhdGVy",
			"RW5lcmd5SW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[]
		{
			ChargerInfoReflection.Descriptor,
			RotaterEnergyInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(InteractChargerScRsp), InteractChargerScRsp.Parser, new string[]
			{
				"ChargerInfo",
				"Retcode",
				"EnergyInfo"
			}, null, null, null, null)
		}));
	}
}
