using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BCD RID: 3021
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MuseumTakeCollectRewardCsReq : IMessage<MuseumTakeCollectRewardCsReq>, IMessage, IEquatable<MuseumTakeCollectRewardCsReq>, IDeepCloneable<MuseumTakeCollectRewardCsReq>, IBufferMessage
	{
		// Token: 0x1700257B RID: 9595
		// (get) Token: 0x060085A8 RID: 34216 RVA: 0x00160E10 File Offset: 0x0015F010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MuseumTakeCollectRewardCsReq> Parser
		{
			get
			{
				return MuseumTakeCollectRewardCsReq._parser;
			}
		}

		// Token: 0x1700257C RID: 9596
		// (get) Token: 0x060085A9 RID: 34217 RVA: 0x00160E17 File Offset: 0x0015F017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MuseumTakeCollectRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700257D RID: 9597
		// (get) Token: 0x060085AA RID: 34218 RVA: 0x00160E29 File Offset: 0x0015F029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MuseumTakeCollectRewardCsReq.Descriptor;
			}
		}

		// Token: 0x060085AB RID: 34219 RVA: 0x00160E30 File Offset: 0x0015F030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumTakeCollectRewardCsReq()
		{
		}

		// Token: 0x060085AC RID: 34220 RVA: 0x00160E38 File Offset: 0x0015F038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumTakeCollectRewardCsReq(MuseumTakeCollectRewardCsReq other) : this()
		{
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060085AD RID: 34221 RVA: 0x00160E5D File Offset: 0x0015F05D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumTakeCollectRewardCsReq Clone()
		{
			return new MuseumTakeCollectRewardCsReq(this);
		}

		// Token: 0x1700257E RID: 9598
		// (get) Token: 0x060085AE RID: 34222 RVA: 0x00160E65 File Offset: 0x0015F065
		// (set) Token: 0x060085AF RID: 34223 RVA: 0x00160E6D File Offset: 0x0015F06D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x060085B0 RID: 34224 RVA: 0x00160E76 File Offset: 0x0015F076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MuseumTakeCollectRewardCsReq);
		}

		// Token: 0x060085B1 RID: 34225 RVA: 0x00160E84 File Offset: 0x0015F084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MuseumTakeCollectRewardCsReq other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060085B2 RID: 34226 RVA: 0x00160EB4 File Offset: 0x0015F0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060085B3 RID: 34227 RVA: 0x00160EF3 File Offset: 0x0015F0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060085B4 RID: 34228 RVA: 0x00160EFB File Offset: 0x0015F0FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060085B5 RID: 34229 RVA: 0x00160F04 File Offset: 0x0015F104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060085B6 RID: 34230 RVA: 0x00160F38 File Offset: 0x0015F138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060085B7 RID: 34231 RVA: 0x00160F76 File Offset: 0x0015F176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MuseumTakeCollectRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060085B8 RID: 34232 RVA: 0x00160FA7 File Offset: 0x0015F1A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060085B9 RID: 34233 RVA: 0x00160FB0 File Offset: 0x0015F1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ItemId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003335 RID: 13109
		private static readonly MessageParser<MuseumTakeCollectRewardCsReq> _parser = new MessageParser<MuseumTakeCollectRewardCsReq>(() => new MuseumTakeCollectRewardCsReq());

		// Token: 0x04003336 RID: 13110
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003337 RID: 13111
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04003338 RID: 13112
		private uint itemId_;
	}
}
