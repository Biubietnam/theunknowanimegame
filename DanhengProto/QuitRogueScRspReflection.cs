using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D50 RID: 3408
	public static class QuitRogueScRspReflection
	{
		// Token: 0x17002B00 RID: 11008
		// (get) Token: 0x06009853 RID: 38995 RVA: 0x00195D76 File Offset: 0x00193F76
		public static FileDescriptor Descriptor
		{
			get
			{
				return QuitRogueScRspReflection.descriptor;
			}
		}

		// Token: 0x04003B39 RID: 15161
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChRRdWl0Um9ndWVTY1JzcC5wcm90bxoVUm9ndWVGaW5pc2hJbmZvLnByb3Rv",
			"Gg9Sb2d1ZUluZm8ucHJvdG8icwoOUXVpdFJvZ3VlU2NSc3ASDwoHcmV0Y29k",
			"ZRgPIAEoDRIjCg9yb2d1ZV9nYW1lX2luZm8YByABKAsyCi5Sb2d1ZUluZm8S",
			"KwoRcm9ndWVfZmluaXNoX2luZm8YCiABKAsyEC5Sb2d1ZUZpbmlzaEluZm9C",
			"HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueFinishInfoReflection.Descriptor,
			RogueInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(QuitRogueScRsp), QuitRogueScRsp.Parser, new string[]
			{
				"Retcode",
				"RogueGameInfo",
				"RogueFinishInfo"
			}, null, null, null, null)
		}));
	}
}
