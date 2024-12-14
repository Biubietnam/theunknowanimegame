using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000846 RID: 2118
	public static class GetUpdatedArchiveDataScRspReflection
	{
		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x06005E36 RID: 24118 RVA: 0x000F9786 File Offset: 0x000F7986
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetUpdatedArchiveDataScRspReflection.descriptor;
			}
		}

		// Token: 0x0400244C RID: 9292
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBHZXRVcGRhdGVkQXJjaGl2ZURhdGFTY1JzcC5wcm90bxoRQXJjaGl2ZURh" + "dGEucHJvdG8iUQoaR2V0VXBkYXRlZEFyY2hpdmVEYXRhU2NSc3ASDwoHcmV0" + "Y29kZRgKIAEoDRIiCgxhcmNoaXZlX2RhdGEYBiABKAsyDC5BcmNoaXZlRGF0" + "YUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ArchiveDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetUpdatedArchiveDataScRsp), GetUpdatedArchiveDataScRsp.Parser, new string[]
			{
				"Retcode",
				"ArchiveData"
			}, null, null, null, null)
		}));
	}
}
