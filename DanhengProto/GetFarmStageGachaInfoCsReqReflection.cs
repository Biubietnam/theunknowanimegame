using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000698 RID: 1688
	public static class GetFarmStageGachaInfoCsReqReflection
	{
		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x06004BA2 RID: 19362 RVA: 0x000CD804 File Offset: 0x000CBA04
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetFarmStageGachaInfoCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001DF9 RID: 7673
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBHZXRGYXJtU3RhZ2VHYWNoYUluZm9Dc1JlcS5wcm90byI+ChpHZXRGYXJt" + "U3RhZ2VHYWNoYUluZm9Dc1JlcRIgChhmYXJtX3N0YWdlX2dhY2hhX2lkX2xp" + "c3QYAiADKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetFarmStageGachaInfoCsReq), GetFarmStageGachaInfoCsReq.Parser, new string[]
			{
				"FarmStageGachaIdList"
			}, null, null, null, null)
		}));
	}
}
