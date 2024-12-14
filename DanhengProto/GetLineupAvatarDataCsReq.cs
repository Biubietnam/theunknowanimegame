using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006F9 RID: 1785
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetLineupAvatarDataCsReq : IMessage<GetLineupAvatarDataCsReq>, IMessage, IEquatable<GetLineupAvatarDataCsReq>, IDeepCloneable<GetLineupAvatarDataCsReq>, IBufferMessage
	{
		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x06004FCF RID: 20431 RVA: 0x000D76B7 File Offset: 0x000D58B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetLineupAvatarDataCsReq> Parser
		{
			get
			{
				return GetLineupAvatarDataCsReq._parser;
			}
		}

		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x06004FD0 RID: 20432 RVA: 0x000D76BE File Offset: 0x000D58BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetLineupAvatarDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x06004FD1 RID: 20433 RVA: 0x000D76D0 File Offset: 0x000D58D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLineupAvatarDataCsReq.Descriptor;
			}
		}

		// Token: 0x06004FD2 RID: 20434 RVA: 0x000D76D7 File Offset: 0x000D58D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLineupAvatarDataCsReq()
		{
		}

		// Token: 0x06004FD3 RID: 20435 RVA: 0x000D76DF File Offset: 0x000D58DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLineupAvatarDataCsReq(GetLineupAvatarDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004FD4 RID: 20436 RVA: 0x000D76F8 File Offset: 0x000D58F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLineupAvatarDataCsReq Clone()
		{
			return new GetLineupAvatarDataCsReq(this);
		}

		// Token: 0x06004FD5 RID: 20437 RVA: 0x000D7700 File Offset: 0x000D5900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetLineupAvatarDataCsReq);
		}

		// Token: 0x06004FD6 RID: 20438 RVA: 0x000D770E File Offset: 0x000D590E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetLineupAvatarDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004FD7 RID: 20439 RVA: 0x000D772C File Offset: 0x000D592C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004FD8 RID: 20440 RVA: 0x000D7752 File Offset: 0x000D5952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004FD9 RID: 20441 RVA: 0x000D775A File Offset: 0x000D595A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004FDA RID: 20442 RVA: 0x000D7763 File Offset: 0x000D5963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004FDB RID: 20443 RVA: 0x000D777C File Offset: 0x000D597C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004FDC RID: 20444 RVA: 0x000D77A2 File Offset: 0x000D59A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetLineupAvatarDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004FDD RID: 20445 RVA: 0x000D77BF File Offset: 0x000D59BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004FDE RID: 20446 RVA: 0x000D77C8 File Offset: 0x000D59C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001F6F RID: 8047
		private static readonly MessageParser<GetLineupAvatarDataCsReq> _parser = new MessageParser<GetLineupAvatarDataCsReq>(() => new GetLineupAvatarDataCsReq());

		// Token: 0x04001F70 RID: 8048
		private UnknownFieldSet _unknownFields;
	}
}
