using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000211 RID: 529
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueEnterCsReq : IMessage<ChessRogueEnterCsReq>, IMessage, IEquatable<ChessRogueEnterCsReq>, IDeepCloneable<ChessRogueEnterCsReq>, IBufferMessage
	{
		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x00043C18 File Offset: 0x00041E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueEnterCsReq> Parser
		{
			get
			{
				return ChessRogueEnterCsReq._parser;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06001789 RID: 6025 RVA: 0x00043C1F File Offset: 0x00041E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueEnterCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x00043C31 File Offset: 0x00041E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueEnterCsReq.Descriptor;
			}
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x00043C38 File Offset: 0x00041E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueEnterCsReq()
		{
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00043C40 File Offset: 0x00041E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueEnterCsReq(ChessRogueEnterCsReq other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x00043C65 File Offset: 0x00041E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueEnterCsReq Clone()
		{
			return new ChessRogueEnterCsReq(this);
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x00043C6D File Offset: 0x00041E6D
		// (set) Token: 0x0600178F RID: 6031 RVA: 0x00043C75 File Offset: 0x00041E75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x00043C7E File Offset: 0x00041E7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueEnterCsReq);
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x00043C8C File Offset: 0x00041E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueEnterCsReq other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x00043CBC File Offset: 0x00041EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x00043CFB File Offset: 0x00041EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x00043D03 File Offset: 0x00041F03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x00043D0C File Offset: 0x00041F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x00043D40 File Offset: 0x00041F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x00043D7E File Offset: 0x00041F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueEnterCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x00043DAF File Offset: 0x00041FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x00043DB8 File Offset: 0x00041FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000A00 RID: 2560
		private static readonly MessageParser<ChessRogueEnterCsReq> _parser = new MessageParser<ChessRogueEnterCsReq>(() => new ChessRogueEnterCsReq());

		// Token: 0x04000A01 RID: 2561
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A02 RID: 2562
		public const int IdFieldNumber = 9;

		// Token: 0x04000A03 RID: 2563
		private uint id_;
	}
}
