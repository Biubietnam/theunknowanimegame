using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004CD RID: 1229
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildTakeExpRewardCsReq : IMessage<EvolveBuildTakeExpRewardCsReq>, IMessage, IEquatable<EvolveBuildTakeExpRewardCsReq>, IDeepCloneable<EvolveBuildTakeExpRewardCsReq>, IBufferMessage
	{
		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x060036F3 RID: 14067 RVA: 0x00096FAF File Offset: 0x000951AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildTakeExpRewardCsReq> Parser
		{
			get
			{
				return EvolveBuildTakeExpRewardCsReq._parser;
			}
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x060036F4 RID: 14068 RVA: 0x00096FB6 File Offset: 0x000951B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildTakeExpRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x060036F5 RID: 14069 RVA: 0x00096FC8 File Offset: 0x000951C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildTakeExpRewardCsReq.Descriptor;
			}
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x00096FCF File Offset: 0x000951CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildTakeExpRewardCsReq()
		{
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x00096FD7 File Offset: 0x000951D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildTakeExpRewardCsReq(EvolveBuildTakeExpRewardCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x00096FF0 File Offset: 0x000951F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildTakeExpRewardCsReq Clone()
		{
			return new EvolveBuildTakeExpRewardCsReq(this);
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x00096FF8 File Offset: 0x000951F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildTakeExpRewardCsReq);
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x00097006 File Offset: 0x00095206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildTakeExpRewardCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x00097024 File Offset: 0x00095224
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

		// Token: 0x060036FC RID: 14076 RVA: 0x0009704A File Offset: 0x0009524A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060036FD RID: 14077 RVA: 0x00097052 File Offset: 0x00095252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060036FE RID: 14078 RVA: 0x0009705B File Offset: 0x0009525B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x00097074 File Offset: 0x00095274
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

		// Token: 0x06003700 RID: 14080 RVA: 0x0009709A File Offset: 0x0009529A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildTakeExpRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003701 RID: 14081 RVA: 0x000970B7 File Offset: 0x000952B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003702 RID: 14082 RVA: 0x000970C0 File Offset: 0x000952C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040015D2 RID: 5586
		private static readonly MessageParser<EvolveBuildTakeExpRewardCsReq> _parser = new MessageParser<EvolveBuildTakeExpRewardCsReq>(() => new EvolveBuildTakeExpRewardCsReq());

		// Token: 0x040015D3 RID: 5587
		private UnknownFieldSet _unknownFields;
	}
}
