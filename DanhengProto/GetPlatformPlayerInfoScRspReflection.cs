using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000762 RID: 1890
	public static class GetPlatformPlayerInfoScRspReflection
	{
		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x0600547D RID: 21629 RVA: 0x000E3302 File Offset: 0x000E1502
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetPlatformPlayerInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x0400212C RID: 8492
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBHZXRQbGF0Zm9ybVBsYXllckluZm9TY1JzcC5wcm90bxoWUGxheWVyU2lt",
			"cGxlSW5mby5wcm90byJaChpHZXRQbGF0Zm9ybVBsYXllckluZm9TY1JzcBIP",
			"CgdyZXRjb2RlGAsgASgNEisKEHBsYXllcl9pbmZvX2xpc3QYAiADKAsyES5Q",
			"bGF5ZXJTaW1wbGVJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
			"dG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			PlayerSimpleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetPlatformPlayerInfoScRsp), GetPlatformPlayerInfoScRsp.Parser, new string[]
			{
				"Retcode",
				"PlayerInfoList"
			}, null, null, null, null)
		}));
	}
}
