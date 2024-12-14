using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200001A RID: 26
	public static class AcceptMainMissionScRspReflection
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000040E5 File Offset: 0x000022E5
		public static FileDescriptor Descriptor
		{
			get
			{
				return AcceptMainMissionScRspReflection.descriptor;
			}
		}

		// Token: 0x0400004F RID: 79
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxBY2NlcHRNYWluTWlzc2lvblNjUnNwLnByb3RvIkIKFkFjY2VwdE1haW5N" + "aXNzaW9uU2NSc3ASFwoPbWFpbl9taXNzaW9uX2lkGAUgASgNEg8KB3JldGNv" + "ZGUYASABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AcceptMainMissionScRsp), AcceptMainMissionScRsp.Parser, new string[]
			{
				"MainMissionId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
