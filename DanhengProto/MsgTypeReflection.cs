using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B9E RID: 2974
	public static class MsgTypeReflection
	{
		// Token: 0x170024F1 RID: 9457
		// (get) Token: 0x060083C4 RID: 33732 RVA: 0x0015BDB9 File Offset: 0x00159FB9
		public static FileDescriptor Descriptor
		{
			get
			{
				return MsgTypeReflection.descriptor;
			}
		}

		// Token: 0x04003269 RID: 12905
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg1Nc2dUeXBlLnByb3RvKl8KB01zZ1R5cGUSEQoNTVNHX1RZUEVfTk9ORRAA" + "EhgKFE1TR19UWVBFX0NVU1RPTV9URVhUEAESEgoOTVNHX1RZUEVfRU1PSkkQ" + "AhITCg9NU0dfVFlQRV9JTlZJVEUQA0IeqgIbRWdnTGluay5EYW5oZW5nU2Vy" + "dmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[]
		{
			typeof(MsgType)
		}, null, null));
	}
}
