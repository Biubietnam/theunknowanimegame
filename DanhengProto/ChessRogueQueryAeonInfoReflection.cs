using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200026E RID: 622
	public static class ChessRogueQueryAeonInfoReflection
	{
		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x0004FCB8 File Offset: 0x0004DEB8
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueQueryAeonInfoReflection.descriptor;
			}
		}

		// Token: 0x04000BA7 RID: 2983
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1DaGVzc1JvZ3VlUXVlcnlBZW9uSW5mby5wcm90bxoZQ2hlc3NSb2d1ZVF1" + "ZXJ5QWVvbi5wcm90byJCChdDaGVzc1JvZ3VlUXVlcnlBZW9uSW5mbxInCglh" + "ZW9uX2xpc3QYBiADKAsyFC5DaGVzc1JvZ3VlUXVlcnlBZW9uQh6qAhtFZ2dM" + "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			ChessRogueQueryAeonReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueQueryAeonInfo), ChessRogueQueryAeonInfo.Parser, new string[]
			{
				"AeonList"
			}, null, null, null, null)
		}));
	}
}
