using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011BC RID: 4540
	public static class StartPunkLordRaidCsReqReflection
	{
		// Token: 0x17003932 RID: 14642
		// (get) Token: 0x0600CAD1 RID: 51921 RVA: 0x002201C9 File Offset: 0x0021E3C9
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartPunkLordRaidCsReqReflection.descriptor;
			}
		}

		// Token: 0x040051C8 RID: 20936
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxTdGFydFB1bmtMb3JkUmFpZENzUmVxLnByb3RvIk4KFlN0YXJ0UHVua0xv" + "cmRSYWlkQ3NSZXESEgoKbW9uc3Rlcl9pZBgMIAEoDRILCgN1aWQYCCABKA0S" + "EwoLS0VQSEFHS0NBR0sYBiABKAhCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl" + "ci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartPunkLordRaidCsReq), StartPunkLordRaidCsReq.Parser, new string[]
			{
				"MonsterId",
				"Uid",
				"KEPHAGKCAGK"
			}, null, null, null, null)
		}));
	}
}
