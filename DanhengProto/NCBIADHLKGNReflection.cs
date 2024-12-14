using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C02 RID: 3074
	public static class NCBIADHLKGNReflection
	{
		// Token: 0x17002630 RID: 9776
		// (get) Token: 0x0600881E RID: 34846 RVA: 0x0016764E File Offset: 0x0016584E
		public static FileDescriptor Descriptor
		{
			get
			{
				return NCBIADHLKGNReflection.descriptor;
			}
		}

		// Token: 0x04003433 RID: 13363
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQ0JJQURITEtHTi5wcm90bxofUm9ndWVNYWdpY0dhbWVTY2VwdGVySW5m" + "by5wcm90byJGCgtOQ0JJQURITEtHThI3ChN1cGRhdGVfc2NlcHRlcl9pbmZv" + "GA0gASgLMhouUm9ndWVNYWdpY0dhbWVTY2VwdGVySW5mb0IeqgIbRWdnTGlu" + "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			RogueMagicGameScepterInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(NCBIADHLKGN), NCBIADHLKGN.Parser, new string[]
			{
				"UpdateScepterInfo"
			}, null, null, null, null)
		}));
	}
}
