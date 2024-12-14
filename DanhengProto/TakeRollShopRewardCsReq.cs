using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001335 RID: 4917
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeRollShopRewardCsReq : IMessage<TakeRollShopRewardCsReq>, IMessage, IEquatable<TakeRollShopRewardCsReq>, IDeepCloneable<TakeRollShopRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003DA5 RID: 15781
		// (get) Token: 0x0600DB6B RID: 56171 RVA: 0x00248754 File Offset: 0x00246954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeRollShopRewardCsReq> Parser
		{
			get
			{
				return TakeRollShopRewardCsReq._parser;
			}
		}

		// Token: 0x17003DA6 RID: 15782
		// (get) Token: 0x0600DB6C RID: 56172 RVA: 0x0024875B File Offset: 0x0024695B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeRollShopRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003DA7 RID: 15783
		// (get) Token: 0x0600DB6D RID: 56173 RVA: 0x0024876D File Offset: 0x0024696D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeRollShopRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600DB6E RID: 56174 RVA: 0x00248774 File Offset: 0x00246974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRollShopRewardCsReq()
		{
		}

		// Token: 0x0600DB6F RID: 56175 RVA: 0x0024877C File Offset: 0x0024697C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRollShopRewardCsReq(TakeRollShopRewardCsReq other) : this()
		{
			this.rollShopId_ = other.rollShopId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DB70 RID: 56176 RVA: 0x002487A1 File Offset: 0x002469A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRollShopRewardCsReq Clone()
		{
			return new TakeRollShopRewardCsReq(this);
		}

		// Token: 0x17003DA8 RID: 15784
		// (get) Token: 0x0600DB71 RID: 56177 RVA: 0x002487A9 File Offset: 0x002469A9
		// (set) Token: 0x0600DB72 RID: 56178 RVA: 0x002487B1 File Offset: 0x002469B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RollShopId
		{
			get
			{
				return this.rollShopId_;
			}
			set
			{
				this.rollShopId_ = value;
			}
		}

		// Token: 0x0600DB73 RID: 56179 RVA: 0x002487BA File Offset: 0x002469BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeRollShopRewardCsReq);
		}

		// Token: 0x0600DB74 RID: 56180 RVA: 0x002487C8 File Offset: 0x002469C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeRollShopRewardCsReq other)
		{
			return other != null && (other == this || (this.RollShopId == other.RollShopId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB75 RID: 56181 RVA: 0x002487F8 File Offset: 0x002469F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RollShopId != 0U)
			{
				num ^= this.RollShopId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DB76 RID: 56182 RVA: 0x00248837 File Offset: 0x00246A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DB77 RID: 56183 RVA: 0x0024883F File Offset: 0x00246A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB78 RID: 56184 RVA: 0x00248848 File Offset: 0x00246A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RollShopId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.RollShopId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DB79 RID: 56185 RVA: 0x0024887C File Offset: 0x00246A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RollShopId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RollShopId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DB7A RID: 56186 RVA: 0x002488BA File Offset: 0x00246ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeRollShopRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RollShopId != 0U)
			{
				this.RollShopId = other.RollShopId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DB7B RID: 56187 RVA: 0x002488EB File Offset: 0x00246AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB7C RID: 56188 RVA: 0x002488F4 File Offset: 0x00246AF4
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
					this.RollShopId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400575D RID: 22365
		private static readonly MessageParser<TakeRollShopRewardCsReq> _parser = new MessageParser<TakeRollShopRewardCsReq>(() => new TakeRollShopRewardCsReq());

		// Token: 0x0400575E RID: 22366
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400575F RID: 22367
		public const int RollShopIdFieldNumber = 6;

		// Token: 0x04005760 RID: 22368
		private uint rollShopId_;
	}
}
