using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010BE RID: 4286
	public static class ServerAnnounceNotifyReflection
	{
		// Token: 0x170035FF RID: 13823
		// (get) Token: 0x0600BF2F RID: 48943 RVA: 0x00202F51 File Offset: 0x00201151
		public static FileDescriptor Descriptor
		{
			get
			{
				return ServerAnnounceNotifyReflection.descriptor;
			}
		}

		// Token: 0x04004DA7 RID: 19879
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTZXJ2ZXJBbm5vdW5jZU5vdGlmeS5wcm90bxoSQW5ub3VuY2VEYXRhLnBy" + "b3RvIkEKFFNlcnZlckFubm91bmNlTm90aWZ5EikKEmFubm91bmNlX2RhdGFf" + "bGlzdBgGIAMoCzINLkFubm91bmNlRGF0YUIeqgIbRWdnTGluay5EYW5oZW5n" + "U2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			AnnounceDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ServerAnnounceNotify), ServerAnnounceNotify.Parser, new string[]
			{
				"AnnounceDataList"
			}, null, null, null, null)
		}));
	}
}
