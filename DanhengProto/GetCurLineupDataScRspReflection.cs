using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000678 RID: 1656
	public static class GetCurLineupDataScRspReflection
	{
		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x06004A39 RID: 19001 RVA: 0x000CA13A File Offset: 0x000C833A
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetCurLineupDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04001D7A RID: 7546
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRDdXJMaW5ldXBEYXRhU2NSc3AucHJvdG8aEExpbmV1cEluZm8ucHJv" + "dG8iRQoVR2V0Q3VyTGluZXVwRGF0YVNjUnNwEg8KB3JldGNvZGUYCiABKA0S" + "GwoGbGluZXVwGA4gASgLMgsuTGluZXVwSW5mb0IeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			LineupInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetCurLineupDataScRsp), GetCurLineupDataScRsp.Parser, new string[]
			{
				"Retcode",
				"Lineup"
			}, null, null, null, null)
		}));
	}
}
