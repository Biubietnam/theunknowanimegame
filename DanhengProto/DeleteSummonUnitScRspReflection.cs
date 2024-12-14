using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200037E RID: 894
	public static class DeleteSummonUnitScRspReflection
	{
		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x060027CB RID: 10187 RVA: 0x0006EE40 File Offset: 0x0006D040
		public static FileDescriptor Descriptor
		{
			get
			{
				return DeleteSummonUnitScRspReflection.descriptor;
			}
		}

		// Token: 0x04001006 RID: 4102
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtEZWxldGVTdW1tb25Vbml0U2NSc3AucHJvdG8iQAoVRGVsZXRlU3VtbW9u" + "VW5pdFNjUnNwEg8KB3JldGNvZGUYCCABKA0SFgoOZW50aXR5X2lkX2xpc3QY" + "DiADKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DeleteSummonUnitScRsp), DeleteSummonUnitScRsp.Parser, new string[]
			{
				"Retcode",
				"EntityIdList"
			}, null, null, null, null)
		}));
	}
}
