using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003C0 RID: 960
	public static class DoGachaCsReqReflection
	{
		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06002AB0 RID: 10928 RVA: 0x00076F1C File Offset: 0x0007511C
		public static FileDescriptor Descriptor
		{
			get
			{
				return DoGachaCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001151 RID: 4433
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJEb0dhY2hhQ3NSZXEucHJvdG8iYQoMRG9HYWNoYUNzUmVxEhAKCGdhY2hh" + "X2lkGAIgASgNEhYKDnNpbXVsYXRlX21hZ2ljGAEgASgNEhEKCWdhY2hhX251" + "bRgEIAEoDRIUCgxnYWNoYV9yYW5kb20YBSABKA1CHqoCG0VnZ0xpbmsuRGFu" + "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DoGachaCsReq), DoGachaCsReq.Parser, new string[]
			{
				"GachaId",
				"SimulateMagic",
				"GachaNum",
				"GachaRandom"
			}, null, null, null, null)
		}));
	}
}
