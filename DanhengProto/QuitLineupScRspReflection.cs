using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D4C RID: 3404
	public static class QuitLineupScRspReflection
	{
		// Token: 0x17002AF2 RID: 10994
		// (get) Token: 0x06009821 RID: 38945 RVA: 0x001955B1 File Offset: 0x001937B1
		public static FileDescriptor Descriptor
		{
			get
			{
				return QuitLineupScRspReflection.descriptor;
			}
		}

		// Token: 0x04003B27 RID: 15143
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVRdWl0TGluZXVwU2NSc3AucHJvdG8idQoPUXVpdExpbmV1cFNjUnNwEg8K",
			"B3JldGNvZGUYCSABKA0SEAoIcGxhbmVfaWQYCCABKA0SEwoLTk5QQkVGTEJM",
			"UEcYAiABKAgSEgoKaXNfdmlydHVhbBgPIAEoCBIWCg5iYXNlX2F2YXRhcl9p",
			"ZBgMIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
			"bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(QuitLineupScRsp), QuitLineupScRsp.Parser, new string[]
			{
				"Retcode",
				"PlaneId",
				"NNPBEFLBLPG",
				"IsVirtual",
				"BaseAvatarId"
			}, null, null, null, null)
		}));
	}
}
