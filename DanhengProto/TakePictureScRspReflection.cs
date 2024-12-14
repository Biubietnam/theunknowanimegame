using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001306 RID: 4870
	public static class TakePictureScRspReflection
	{
		// Token: 0x17003D10 RID: 15632
		// (get) Token: 0x0600D94D RID: 55629 RVA: 0x0024316A File Offset: 0x0024136A
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakePictureScRspReflection.descriptor;
			}
		}

		// Token: 0x0400569E RID: 22174
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZUYWtlUGljdHVyZVNjUnNwLnByb3RvIiMKEFRha2VQaWN0dXJlU2NSc3AS" + "DwoHcmV0Y29kZRgBIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakePictureScRsp), TakePictureScRsp.Parser, new string[]
			{
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
