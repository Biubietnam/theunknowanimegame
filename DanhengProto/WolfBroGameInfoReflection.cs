using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200142A RID: 5162
	public static class WolfBroGameInfoReflection
	{
		// Token: 0x170040A7 RID: 16551
		// (get) Token: 0x0600E652 RID: 58962 RVA: 0x002641C2 File Offset: 0x002623C2
		public static FileDescriptor Descriptor
		{
			get
			{
				return WolfBroGameInfoReflection.descriptor;
			}
		}

		// Token: 0x04005B69 RID: 23401
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVXb2xmQnJvR2FtZUluZm8ucHJvdG8aEE1vdGlvbkluZm8ucHJvdG8aDFZl",
			"Y3Rvci5wcm90byJ2Cg9Xb2xmQnJvR2FtZUluZm8SGwoGbW90aW9uGA8gASgL",
			"MgsuTW90aW9uSW5mbxITCgtQUElOUEVISkZBQhgIIAEoDRIcCgtKQk9GSUFM",
			"TE9QSRgEIAMoCzIHLlZlY3RvchITCgtIRk5FS01NTUZITxgGIAEoCEIeqgIb",
			"RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			MotionInfoReflection.Descriptor,
			VectorReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(WolfBroGameInfo), WolfBroGameInfo.Parser, new string[]
			{
				"Motion",
				"PPINPEHJFAB",
				"JBOFIALLOPI",
				"HFNEKMMMFHO"
			}, null, null, null, null)
		}));
	}
}
