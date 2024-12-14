using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FFA RID: 4090
	public static class RogueTournQueryScRspReflection
	{
		// Token: 0x1700334A RID: 13130
		// (get) Token: 0x0600B603 RID: 46595 RVA: 0x001E8772 File Offset: 0x001E6972
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournQueryScRspReflection.descriptor;
			}
		}

		// Token: 0x040049CC RID: 18892
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpSb2d1ZVRvdXJuUXVlcnlTY1JzcC5wcm90bxoXUm9ndWVUb3VybkN1cklu",
			"Zm8ucHJvdG8aFFJvZ3VlVG91cm5JbmZvLnByb3RvIoIBChRSb2d1ZVRvdXJu",
			"UXVlcnlTY1JzcBIPCgdyZXRjb2RlGAIgASgNEjAKFHJvZ3VlX3RvdXJuX2N1",
			"cl9pbmZvGA4gASgLMhIuUm9ndWVUb3VybkN1ckluZm8SJwoOcm9ndWVfZ2V0",
			"X2luZm8YByABKAsyDy5Sb2d1ZVRvdXJuSW5mb0IeqgIbRWdnTGluay5EYW5o",
			"ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueTournCurInfoReflection.Descriptor,
			RogueTournInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournQueryScRsp), RogueTournQueryScRsp.Parser, new string[]
			{
				"Retcode",
				"RogueTournCurInfo",
				"RogueGetInfo"
			}, null, null, null, null)
		}));
	}
}
