using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200069A RID: 1690
	public static class GetFarmStageGachaInfoScRspReflection
	{
		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x06004BB6 RID: 19382 RVA: 0x000CDA78 File Offset: 0x000CBC78
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetFarmStageGachaInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04001DFF RID: 7679
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBHZXRGYXJtU3RhZ2VHYWNoYUluZm9TY1JzcC5wcm90bxoYRmFybVN0YWdl",
			"R2FjaGFJbmZvLnByb3RvImYKGkdldEZhcm1TdGFnZUdhY2hhSW5mb1NjUnNw",
			"Eg8KB3JldGNvZGUYCCABKA0SNwoaZmFybV9zdGFnZV9nYWNoYV9pbmZvX2xp",
			"c3QYCiADKAsyEy5GYXJtU3RhZ2VHYWNoYUluZm9CHqoCG0VnZ0xpbmsuRGFu",
			"aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			FarmStageGachaInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetFarmStageGachaInfoScRsp), GetFarmStageGachaInfoScRsp.Parser, new string[]
			{
				"Retcode",
				"FarmStageGachaInfoList"
			}, null, null, null, null)
		}));
	}
}
