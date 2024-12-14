using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F80 RID: 3968
	public static class RogueTournAreaUpdateScNotifyReflection
	{
		// Token: 0x170031DB RID: 12763
		// (get) Token: 0x0600B0BD RID: 45245 RVA: 0x001DACD5 File Offset: 0x001D8ED5
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournAreaUpdateScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040047ED RID: 18413
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJSb2d1ZVRvdXJuQXJlYVVwZGF0ZVNjTm90aWZ5LnByb3RvGhhSb2d1ZVRv",
			"dXJuQXJlYUluZm8ucHJvdG8iUgocUm9ndWVUb3VybkFyZWFVcGRhdGVTY05v",
			"dGlmeRIyChVyb2d1ZV90b3Vybl9hcmVhX2luZm8YBiADKAsyEy5Sb2d1ZVRv",
			"dXJuQXJlYUluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
			"cHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueTournAreaInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournAreaUpdateScNotify), RogueTournAreaUpdateScNotify.Parser, new string[]
			{
				"RogueTournAreaInfo"
			}, null, null, null, null)
		}));
	}
}
