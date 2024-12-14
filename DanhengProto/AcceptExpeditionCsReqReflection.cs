using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000014 RID: 20
	public static class AcceptExpeditionCsReqReflection
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000381D File Offset: 0x00001A1D
		public static FileDescriptor Descriptor
		{
			get
			{
				return AcceptExpeditionCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400003E RID: 62
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtBY2NlcHRFeHBlZGl0aW9uQ3NSZXEucHJvdG8aEUpMSEhDSUpQT1BELnBy" + "b3RvIkgKFUFjY2VwdEV4cGVkaXRpb25Dc1JlcRIvChlGVU5DX1VOTE9DS19J" + "RF9FWFBFRElUSU9OGAsgASgLMgwuSkxISENJSlBPUERCHqoCG0VnZ0xpbmsu" + "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			JLHHCIJPOPDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AcceptExpeditionCsReq), AcceptExpeditionCsReq.Parser, new string[]
			{
				"FUNCUNLOCKIDEXPEDITION"
			}, null, null, null, null)
		}));
	}
}
