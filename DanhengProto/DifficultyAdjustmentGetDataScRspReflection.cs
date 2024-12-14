using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200039C RID: 924
	public static class DifficultyAdjustmentGetDataScRspReflection
	{
		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06002921 RID: 10529 RVA: 0x000725E6 File Offset: 0x000707E6
		public static FileDescriptor Descriptor
		{
			get
			{
				return DifficultyAdjustmentGetDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04001096 RID: 4246
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiZEaWZmaWN1bHR5QWRqdXN0bWVudEdldERhdGFTY1JzcC5wcm90bxoRRlBH",
			"S0hJRkVOR0wucHJvdG8iXwogRGlmZmljdWx0eUFkanVzdG1lbnRHZXREYXRh",
			"U2NSc3ASKgoUY29udGVudF9wYWNrYWdlX2xpc3QYDyADKAsyDC5GUEdLSElG",
			"RU5HTBIPCgdyZXRjb2RlGAUgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
			"ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			FPGKHIFENGLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DifficultyAdjustmentGetDataScRsp), DifficultyAdjustmentGetDataScRsp.Parser, new string[]
			{
				"ContentPackageList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
