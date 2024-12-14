using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200120A RID: 4618
	public static class SummonPetScRspReflection
	{
		// Token: 0x17003A38 RID: 14904
		// (get) Token: 0x0600CE71 RID: 52849 RVA: 0x00229BFE File Offset: 0x00227DFE
		public static FileDescriptor Descriptor
		{
			get
			{
				return SummonPetScRspReflection.descriptor;
			}
		}

		// Token: 0x04005328 RID: 21288
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRTdW1tb25QZXRTY1JzcC5wcm90byJJCg5TdW1tb25QZXRTY1JzcBIPCgdy" + "ZXRjb2RlGA4gASgNEhIKCmN1cl9wZXRfaWQYCSABKA0SEgoKbmV3X3BldF9p" + "ZBgHIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SummonPetScRsp), SummonPetScRsp.Parser, new string[]
			{
				"Retcode",
				"CurPetId",
				"NewPetId"
			}, null, null, null, null)
		}));
	}
}
