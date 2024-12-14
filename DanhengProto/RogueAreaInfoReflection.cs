using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E08 RID: 3592
	public static class RogueAreaInfoReflection
	{
		// Token: 0x17002D5E RID: 11614
		// (get) Token: 0x0600A0AD RID: 41133 RVA: 0x001AF282 File Offset: 0x001AD482
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueAreaInfoReflection.descriptor;
			}
		}

		// Token: 0x040041D1 RID: 16849
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNSb2d1ZUFyZWFJbmZvLnByb3RvGg9Sb2d1ZUFyZWEucHJvdG8iNAoNUm9n" + "dWVBcmVhSW5mbxIjCg9yb2d1ZV9hcmVhX2xpc3QYBiADKAsyCi5Sb2d1ZUFy" + "ZWFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			RogueAreaReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueAreaInfo), RogueAreaInfo.Parser, new string[]
			{
				"RogueAreaList"
			}, null, null, null, null)
		}));
	}
}
