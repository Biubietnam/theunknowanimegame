using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D64 RID: 3428
	public static class RaidCollectionDataScRspReflection
	{
		// Token: 0x17002B38 RID: 11064
		// (get) Token: 0x06009931 RID: 39217 RVA: 0x00197BED File Offset: 0x00195DED
		public static FileDescriptor Descriptor
		{
			get
			{
				return RaidCollectionDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04003B77 RID: 15223
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1SYWlkQ29sbGVjdGlvbkRhdGFTY1JzcC5wcm90bxoRS09HQkRITk1NREYu" + "cHJvdG8iUAoXUmFpZENvbGxlY3Rpb25EYXRhU2NSc3ASJAoOY2hhbGxlbmdl" + "X2xpc3QYDSADKAsyDC5LT0dCREhOTU1ERhIPCgdyZXRjb2RlGA4gASgNQh6q" + "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			KOGBDHNMMDFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RaidCollectionDataScRsp), RaidCollectionDataScRsp.Parser, new string[]
			{
				"ChallengeList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
