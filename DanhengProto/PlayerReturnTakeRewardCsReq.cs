using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CE1 RID: 3297
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerReturnTakeRewardCsReq : IMessage<PlayerReturnTakeRewardCsReq>, IMessage, IEquatable<PlayerReturnTakeRewardCsReq>, IDeepCloneable<PlayerReturnTakeRewardCsReq>, IBufferMessage
	{
		// Token: 0x17002966 RID: 10598
		// (get) Token: 0x06009315 RID: 37653 RVA: 0x0018603C File Offset: 0x0018423C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerReturnTakeRewardCsReq> Parser
		{
			get
			{
				return PlayerReturnTakeRewardCsReq._parser;
			}
		}

		// Token: 0x17002967 RID: 10599
		// (get) Token: 0x06009316 RID: 37654 RVA: 0x00186043 File Offset: 0x00184243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerReturnTakeRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002968 RID: 10600
		// (get) Token: 0x06009317 RID: 37655 RVA: 0x00186055 File Offset: 0x00184255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerReturnTakeRewardCsReq.Descriptor;
			}
		}

		// Token: 0x06009318 RID: 37656 RVA: 0x0018605C File Offset: 0x0018425C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnTakeRewardCsReq()
		{
		}

		// Token: 0x06009319 RID: 37657 RVA: 0x00186064 File Offset: 0x00184264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnTakeRewardCsReq(PlayerReturnTakeRewardCsReq other) : this()
		{
			this.gJDIBELBCCJ_ = other.gJDIBELBCCJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600931A RID: 37658 RVA: 0x00186089 File Offset: 0x00184289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnTakeRewardCsReq Clone()
		{
			return new PlayerReturnTakeRewardCsReq(this);
		}

		// Token: 0x17002969 RID: 10601
		// (get) Token: 0x0600931B RID: 37659 RVA: 0x00186091 File Offset: 0x00184291
		// (set) Token: 0x0600931C RID: 37660 RVA: 0x00186099 File Offset: 0x00184299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GJDIBELBCCJ
		{
			get
			{
				return this.gJDIBELBCCJ_;
			}
			set
			{
				this.gJDIBELBCCJ_ = value;
			}
		}

		// Token: 0x0600931D RID: 37661 RVA: 0x001860A2 File Offset: 0x001842A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerReturnTakeRewardCsReq);
		}

		// Token: 0x0600931E RID: 37662 RVA: 0x001860B0 File Offset: 0x001842B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerReturnTakeRewardCsReq other)
		{
			return other != null && (other == this || (this.GJDIBELBCCJ == other.GJDIBELBCCJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600931F RID: 37663 RVA: 0x001860E0 File Offset: 0x001842E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GJDIBELBCCJ != 0U)
			{
				num ^= this.GJDIBELBCCJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009320 RID: 37664 RVA: 0x0018611F File Offset: 0x0018431F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009321 RID: 37665 RVA: 0x00186127 File Offset: 0x00184327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009322 RID: 37666 RVA: 0x00186130 File Offset: 0x00184330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GJDIBELBCCJ != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GJDIBELBCCJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009323 RID: 37667 RVA: 0x00186164 File Offset: 0x00184364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GJDIBELBCCJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GJDIBELBCCJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009324 RID: 37668 RVA: 0x001861A2 File Offset: 0x001843A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerReturnTakeRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GJDIBELBCCJ != 0U)
			{
				this.GJDIBELBCCJ = other.GJDIBELBCCJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009325 RID: 37669 RVA: 0x001861D3 File Offset: 0x001843D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009326 RID: 37670 RVA: 0x001861DC File Offset: 0x001843DC
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
					this.GJDIBELBCCJ = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040038BB RID: 14523
		private static readonly MessageParser<PlayerReturnTakeRewardCsReq> _parser = new MessageParser<PlayerReturnTakeRewardCsReq>(() => new PlayerReturnTakeRewardCsReq());

		// Token: 0x040038BC RID: 14524
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038BD RID: 14525
		public const int GJDIBELBCCJFieldNumber = 1;

		// Token: 0x040038BE RID: 14526
		private uint gJDIBELBCCJ_;
	}
}
