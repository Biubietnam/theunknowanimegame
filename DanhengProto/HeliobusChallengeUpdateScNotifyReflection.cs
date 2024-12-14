using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008B8 RID: 2232
	public static class HeliobusChallengeUpdateScNotifyReflection
	{
		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x0600638A RID: 25482 RVA: 0x0010AB3D File Offset: 0x00108D3D
		public static FileDescriptor Descriptor
		{
			get
			{
				return HeliobusChallengeUpdateScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04002664 RID: 9828
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVIZWxpb2J1c0NoYWxsZW5nZVVwZGF0ZVNjTm90aWZ5LnByb3RvGhNDaGFs" + "bGVuZ2VMaXN0LnByb3RvIkQKH0hlbGlvYnVzQ2hhbGxlbmdlVXBkYXRlU2NO" + "b3RpZnkSIQoJY2hhbGxlbmdlGAkgASgLMg4uQ2hhbGxlbmdlTGlzdEIeqgIb" + "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ChallengeListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusChallengeUpdateScNotify), HeliobusChallengeUpdateScNotify.Parser, new string[]
			{
				"Challenge"
			}, null, null, null, null)
		}));
	}
}
