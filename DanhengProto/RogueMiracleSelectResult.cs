using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F45 RID: 3909
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMiracleSelectResult : IMessage<RogueMiracleSelectResult>, IMessage, IEquatable<RogueMiracleSelectResult>, IDeepCloneable<RogueMiracleSelectResult>, IBufferMessage
	{
		// Token: 0x17003139 RID: 12601
		// (get) Token: 0x0600AE6F RID: 44655 RVA: 0x001D518C File Offset: 0x001D338C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMiracleSelectResult> Parser
		{
			get
			{
				return RogueMiracleSelectResult._parser;
			}
		}

		// Token: 0x1700313A RID: 12602
		// (get) Token: 0x0600AE70 RID: 44656 RVA: 0x001D5193 File Offset: 0x001D3393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMiracleSelectResultReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700313B RID: 12603
		// (get) Token: 0x0600AE71 RID: 44657 RVA: 0x001D51A5 File Offset: 0x001D33A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMiracleSelectResult.Descriptor;
			}
		}

		// Token: 0x0600AE72 RID: 44658 RVA: 0x001D51AC File Offset: 0x001D33AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMiracleSelectResult()
		{
		}

		// Token: 0x0600AE73 RID: 44659 RVA: 0x001D51B4 File Offset: 0x001D33B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMiracleSelectResult(RogueMiracleSelectResult other) : this()
		{
			this.miracleSelectId_ = other.miracleSelectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE74 RID: 44660 RVA: 0x001D51D9 File Offset: 0x001D33D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMiracleSelectResult Clone()
		{
			return new RogueMiracleSelectResult(this);
		}

		// Token: 0x1700313C RID: 12604
		// (get) Token: 0x0600AE75 RID: 44661 RVA: 0x001D51E1 File Offset: 0x001D33E1
		// (set) Token: 0x0600AE76 RID: 44662 RVA: 0x001D51E9 File Offset: 0x001D33E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MiracleSelectId
		{
			get
			{
				return this.miracleSelectId_;
			}
			set
			{
				this.miracleSelectId_ = value;
			}
		}

		// Token: 0x0600AE77 RID: 44663 RVA: 0x001D51F2 File Offset: 0x001D33F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMiracleSelectResult);
		}

		// Token: 0x0600AE78 RID: 44664 RVA: 0x001D5200 File Offset: 0x001D3400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMiracleSelectResult other)
		{
			return other != null && (other == this || (this.MiracleSelectId == other.MiracleSelectId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE79 RID: 44665 RVA: 0x001D5230 File Offset: 0x001D3430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MiracleSelectId != 0U)
			{
				num ^= this.MiracleSelectId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AE7A RID: 44666 RVA: 0x001D526F File Offset: 0x001D346F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AE7B RID: 44667 RVA: 0x001D5277 File Offset: 0x001D3477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE7C RID: 44668 RVA: 0x001D5280 File Offset: 0x001D3480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MiracleSelectId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.MiracleSelectId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE7D RID: 44669 RVA: 0x001D52B4 File Offset: 0x001D34B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MiracleSelectId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MiracleSelectId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE7E RID: 44670 RVA: 0x001D52F2 File Offset: 0x001D34F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMiracleSelectResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MiracleSelectId != 0U)
			{
				this.MiracleSelectId = other.MiracleSelectId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AE7F RID: 44671 RVA: 0x001D5323 File Offset: 0x001D3523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE80 RID: 44672 RVA: 0x001D532C File Offset: 0x001D352C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MiracleSelectId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004703 RID: 18179
		private static readonly MessageParser<RogueMiracleSelectResult> _parser = new MessageParser<RogueMiracleSelectResult>(() => new RogueMiracleSelectResult());

		// Token: 0x04004704 RID: 18180
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004705 RID: 18181
		public const int MiracleSelectIdFieldNumber = 6;

		// Token: 0x04004706 RID: 18182
		private uint miracleSelectId_;
	}
}
