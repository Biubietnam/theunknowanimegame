using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A98 RID: 2712
	public static class MatchBoxingClubOpponentScRspReflection
	{
		// Token: 0x170021C1 RID: 8641
		// (get) Token: 0x06007835 RID: 30773 RVA: 0x0013EAF6 File Offset: 0x0013CCF6
		public static FileDescriptor Descriptor
		{
			get
			{
				return MatchBoxingClubOpponentScRspReflection.descriptor;
			}
		}

		// Token: 0x04002E2B RID: 11819
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJNYXRjaEJveGluZ0NsdWJPcHBvbmVudFNjUnNwLnByb3RvGhFMSkxMSElK" + "S0tPSC5wcm90byJQChxNYXRjaEJveGluZ0NsdWJPcHBvbmVudFNjUnNwEh8K" + "CWNoYWxsZW5nZRgOIAEoCzIMLkxKTExISUpLS09IEg8KB3JldGNvZGUYASAB" + "KA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			LJLLHIJKKOHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MatchBoxingClubOpponentScRsp), MatchBoxingClubOpponentScRsp.Parser, new string[]
			{
				"Challenge",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
