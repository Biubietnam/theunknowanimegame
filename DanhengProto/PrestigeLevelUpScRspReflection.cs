using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CFE RID: 3326
	public static class PrestigeLevelUpScRspReflection
	{
		// Token: 0x170029E4 RID: 10724
		// (get) Token: 0x06009499 RID: 38041 RVA: 0x0018B07A File Offset: 0x0018927A
		public static FileDescriptor Descriptor
		{
			get
			{
				return PrestigeLevelUpScRspReflection.descriptor;
			}
		}

		// Token: 0x0400398D RID: 14733
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpQcmVzdGlnZUxldmVsVXBTY1JzcC5wcm90byI2ChRQcmVzdGlnZUxldmVs" + "VXBTY1JzcBINCgVsZXZlbBgLIAEoDRIPCgdyZXRjb2RlGAUgASgNQh6qAhtF" + "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PrestigeLevelUpScRsp), PrestigeLevelUpScRsp.Parser, new string[]
			{
				"Level",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
